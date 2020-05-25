using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Runtime.Remoting.Messaging;
using MetroFramework;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Reflection;

namespace DictGenerator
{
    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// 获取exe文件路径
        /// </summary>
        private String path = "";
        /// <summary>
        /// 配置文件内容
        /// </summary>
        private Config config;
        /// <summary>
        /// 选中结点集合
        /// </summary>
        private List<TreeNode> symbolSelectedList = new List<TreeNode>();
        private List<TreeNode> symbolList = new List<TreeNode>();
        /// <summary>
        /// 设置各个勾选项在排列中的对应关系
        /// </summary>
        private Dictionary<CheckBox, List<String>> AListGroup = new Dictionary<CheckBox, List<String>>();
        private Dictionary<CheckBox, MetroTextBox> textboxes = new Dictionary<CheckBox, MetroTextBox>();
        private List<String> AList = new List<String>();
        private List<String> BList = new List<String>();
        private List<String> CList = new List<String>();
        private HashSet<String> appendedDict = new HashSet<string>();
        /// <summary>
        /// 设置是否全选特殊符号
        /// </summary>
        private Boolean symbolChecked = false;
        private Boolean isOver = false;
        private int Bindex = 1;
        public MainForm()
        {
            String exePath = this.GetType().Assembly.Location;
            this.path = exePath.Substring(0, exePath.LastIndexOf('\\') + 1);
            InitializeComponent();
            loadConfig();
            Dictionary<String, Int32> data = new Dictionary<string, int>();
            data.Add("符号组合", 0);
            data.Add("默认配置", 1);
            this.metroComboBox1.DataSource = new BindingSource(data, null);
            this.metroComboBox1.DisplayMember = "key";
            this.metroComboBox1.ValueMember = "value";
            this.metroComboBox1.SelectedIndex = 1;
            this.tabControl1.SelectedIndex = 1;
            createSymbolTree();
            this.AListGroup.Add(titleLab, new List<String>());
            this.AListGroup.Add(siteLab, new List<String>());
            this.AListGroup.Add(yearLab, new List<String>());
            this.AListGroup.Add(phonenumberLab, new List<String>());
            this.AListGroup.Add(nameLab, new List<String>());
            this.AListGroup.Add(birthdayLab, new List<String>());
            this.AListGroup.Add(username, new List<string>());
            this.AListGroup.Add(defineLab, new List<String>());
            this.textboxes.Add(titleLab, titleText);
            this.textboxes.Add(siteLab, siteText);
            this.textboxes.Add(phonenumberLab, phonenumberText);
        }

        /// <summary>
        /// 设置符号列表
        /// </summary>
        private void createSymbolTree()
        {
            String[] symbols = new string[] {"!","@","#","$","%","^","&","*","(",")","-","=","-","/","\\","+","`","[","]","<",">","?","{","}","|",",","~" };
            foreach (String i in symbols)
            {
                TreeNode node = new TreeNode(i);
                this.treeView1.Nodes.Add(node);
                this.symbolList.Add(node);
            }
        }

        /// <summary>
        /// 检查输入的值是否符合格式，并初始化三类数据
        /// </summary>
        /// 
        private bool checkParam()
        {
            foreach (CheckBox i in this.textboxes.Keys)
            {
                if (i.CheckState == CheckState.Checked)
                {
                    String s = this.textboxes[i].Text.Trim();
                    if (!String.IsNullOrEmpty(s))
                    {
                        this.AListGroup[i].Add(s);
                    }
                }
            }
            if(this.nameLab.CheckState == CheckState.Checked)
            {
                String s = this.nameText.Text.Trim();
                if (!String.IsNullOrEmpty(s))
                {
                    String[] name = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if(name.Length > 1) 
                    { 
                        this.AListGroup[this.nameLab].Add(Tool.mergeArray(name));
                        this.AListGroup[this.nameLab].AddRange(Tool.getNameList(name));
                    }
                    else if(name.Length == 1)
                    {
                        this.AListGroup[this.nameLab].Add(name[0]);
                    }
                }
            }
            if (birthdayLab.CheckState == CheckState.Checked)
            {
                String str = dateTimePicker1.Value.ToString("yyyyMMdd");
                this.AListGroup[this.birthdayLab].Add(str);//20200428
                this.AListGroup[this.birthdayLab].Add(str.Substring(4));//0428
            }
            if (defineLab.CheckState == CheckState.Checked)
            {
                String text = defineText.Text;
                String[] definewords = text.Trim().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (String word in definewords)
                {
                    this.AListGroup[this.defineLab].Add(word);
                }
            }
            if (yearLab.CheckState == CheckState.Checked)
            {
                if (!String.IsNullOrEmpty(botYear.Text) && !String.IsNullOrEmpty(topYear.Text))
                {
                    if (botYear.Text.Length != 4 || topYear.Text.Length != 4)
                    {
                        MessageBox.Show("输入的年份格式错误！");
                        return false;
                    }
                    else
                    {
                        int top = Convert.ToInt32(topYear.Text);
                        int bot = Convert.ToInt32(botYear.Text);
                        if (bot > top)
                        {
                            MessageBox.Show("年份输入错误！");
                            return false;
                        }
                        for (int i = bot; i <= top; i++)
                            this.AListGroup[this.yearLab].Add(i.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("选中年份选项后，需要输入年份的间隔时间，若只需要单独一个年份，请输入到自定义内容中");
                    return false;
                }
            }
            if(this.Bindex == 0)
            {
                this.BList = Tool.generateList(Tool.convertNodeToList(this.symbolSelectedList), Convert.ToInt32(comboBox2.Text));
            }
            else if(this.Bindex == 1)
            {
                this.BList = this.config.Symobls;
            }
            this.CList = this.config.commonString;
            this.AList.Clear();
            foreach (List<String> i in this.AListGroup.Values)
            {
                this.AList.AddRange(i);
            }
            return true;
        }
        /// <summary>
        /// 生成字典按钮触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateDict_Click(object sender, EventArgs e)
        {
           if (checkParam()){
                String defineGroup = this.richTextBox1.Text.Trim();
                String[] groups = defineGroup.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                this.generateDict.Enabled = false;
                fillList(groups);
                foreach (CheckBox i in AListGroup.Keys)
                {
                    AListGroup[i].Clear();
                }
                this.generateDict.Enabled = true;
            }
        }

        private void fillList(String[] groups)
        {
            try { 
                using (StreamWriter writer = new StreamWriter(this.path + "password.txt"))
                {
                    //生成的组合密码
                    foreach (String group in groups)
                    {
                        Stack<List<String>> stack = new Stack<List<String>>();
                        foreach(char i in group)
                        {
                            switch (i)
                            {
                                case 'A': stack.Push(this.AList);break;
                                case 'B': stack.Push(this.BList);break;
                                case 'C': stack.Push(this.CList);break;
                            }
                        }
                        List<String> res = Tool.combineDict(stack);
                        if (res != null) {
                            foreach (String i in res)
                            {
                                writer.WriteLine(i);
                            }
                        }
                    }
                    if(this.appendedDict.Count != 0)
                    {
                        foreach (String s in this.appendedDict)
                        {
                            writer.WriteLine(s);
                        }
                    }
                    writer.Flush();
                }
                MessageBox.Show("字典生成完毕！");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /// <summary>
        /// 特殊符号全选/全不选点击事件
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            if (symbolChecked)
            {
                foreach (TreeNode i in symbolList)
                {
                    i.Checked = false;
                }
                this.symbolChecked = false;
            }
            else
            {
                foreach (TreeNode i in symbolList)
                {
                    i.Checked = true;
                }
                this.symbolChecked = true;
            }
        }

        /// <summary>
        /// 配置只允许输入数字
        /// </summary>
        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "文本文件(*.txt)|*.txt";
            dialog.ValidateNames = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.metroTextBox1.Text = dialog.FileName;
            }
            try
            {
                using (StreamReader sr = new StreamReader(dialog.FileName, Encoding.Default))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        AListGroup[this.username].Add(line.Trim());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                this.symbolSelectedList.Add(e.Node);
            }
            else
            {
                this.symbolSelectedList.Remove(e.Node);
            }
            int count = this.symbolSelectedList.Count;
            if (count <= 3)
            {
                String[] source = new string[count];
                for (int i = 0; i < count; i++)
                {
                    source[i] = (i + 1).ToString();
                }
                this.comboBox2.DataSource = source;
            }
            else
            {
                this.comboBox2.DataSource = new String[] { "1", "2", "3" };
            }
        }
        /// <summary>
        /// 选择B类配置项
        /// </summary>
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Bindex = ((KeyValuePair<string, Int32>)this.metroComboBox1.SelectedItem).Value; 
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            loadConfig();
        }
        /// <summary>
        /// 加载配置文件
        /// </summary>
        private void loadConfig()
        {
            if(!File.Exists(this.path + "config.json"))
            {
                this.config = Tool.parseJsonByResource(Properties.Resources.config);
                using (StreamWriter writer = new StreamWriter(this.path + "config.json"))
                {
                    writer.Write(Properties.Resources.config);
                    writer.Flush();
                }
            }
            else
            {
                this.config = Tool.parseJsonByFile(this.path + "config.json");
            }
            if (config != null)
            {
                this.richTextBox1.Text = this.config.combinedGroup;
                this.BListBox.DataSource = this.config.Symobls;
                this.CListBox.DataSource = this.config.commonString;
            }
            else
            {
                MessageBox.Show("config.json文件格式错误或文件不存在！");
            }
            //this.isOver = true;
        }
        /// <summary>
        /// 设置BListBox符号居中显示
        /// </summary>
        private void BListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            StringFormat strFmt = new System.Drawing.StringFormat();
            strFmt.Alignment = StringAlignment.Center;
            strFmt.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(BListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds, strFmt);
        }

        private void 字符大写并追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tmp = this.defineText.SelectedText.Trim();
            if (!String.IsNullOrEmpty(tmp))
            {
                String handled = tmp.ToUpper();
                if(handled != tmp)
                    this.defineText.Text = this.defineText.Text + "\n" + handled;
            }
        }

        private void 首字母大写并追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tmp = this.defineText.SelectedText.Trim();
            if (!String.IsNullOrEmpty(tmp))
            {
                String handled = Tool.ToFirstUpper(tmp);
                if(handled != tmp)
                    this.defineText.Text = this.defineText.Text + "\n" + handled;
            }
        }

        private void 字符转置并追加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tmp = this.defineText.SelectedText.Trim();
            if (!String.IsNullOrEmpty(tmp))
            {
                this.defineText.Text = this.defineText.Text + "\n" + Tool.ToReverse(tmp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.isOver)
            {
                this.timer1.Tick -= new System.EventHandler(this.timer1_Tick);
                this.isOver = false;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("项目链接：http://github.com/f1ashine/Dictgenerator");
        }

        private void appendfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "文本文件(*.txt)|*.txt";
            dialog.ValidateNames = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (String name in dialog.FileNames)
                    {
                        richTextBox2.Text += name + "\n";
                        using (StreamReader sr = new StreamReader(name, Encoding.Default))
                        {
                            appendedDict.Add(sr.ReadLine().Trim());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.save.Enabled = false;
            try
            {
                using(StreamWriter writer = new StreamWriter(this.path + "config.json"))
                {
                    JObject obj = config.getObj();
                    obj["combination"] = richTextBox1.Text;
                    string output = JsonConvert.SerializeObject(obj, Formatting.Indented);
                    writer.Write(output);
                    writer.Flush();
                    MessageBox.Show("保存成功！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.save.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "文本文件(*.txt)|*.txt";
            dialog.ValidateNames = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(dialog.FileName))
                    {
                        String context = reader.ReadToEnd();
                        EditForm form = new EditForm();
                        form.Show();
                        form.setText(Tool.toJsonFormat(context));
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
