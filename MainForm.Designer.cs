namespace DictGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defineText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.字符大写并追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.首字母大写并追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字符转置并追加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineLab = new System.Windows.Forms.CheckBox();
            this.openFile = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePicker1 = new MetroFramework.Controls.MetroDateTime();
            this.titleLab = new System.Windows.Forms.CheckBox();
            this.titleText = new MetroFramework.Controls.MetroTextBox();
            this.siteLab = new System.Windows.Forms.CheckBox();
            this.siteText = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLab = new System.Windows.Forms.CheckBox();
            this.phonenumberText = new MetroFramework.Controls.MetroTextBox();
            this.nameText = new MetroFramework.Controls.MetroTextBox();
            this.username = new System.Windows.Forms.CheckBox();
            this.birthdayLab = new System.Windows.Forms.CheckBox();
            this.botYear = new MetroFramework.Controls.MetroTextBox();
            this.phonenumberLab = new System.Windows.Forms.CheckBox();
            this.yearLab = new System.Windows.Forms.CheckBox();
            this.topYear = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.save = new MetroFramework.Controls.MetroButton();
            this.appendfile = new MetroFramework.Controls.MetroButton();
            this.appendDict = new System.Windows.Forms.CheckBox();
            this.generateDict = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroComboBox1);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(583, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 452);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B类";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DisplayFocus = true;
            this.metroComboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(3, 19);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(205, 29);
            this.metroComboBox1.TabIndex = 14;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(3, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(205, 391);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(197, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "符号组合";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "限定组合的最大个数";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 23;
            this.comboBox2.Location = new System.Drawing.Point(155, 328);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(36, 29);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.UseSelectable = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "全选/全不选";
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(-4, 32);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(205, 290);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(197, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "默认配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BListBox
            // 
            this.BListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BListBox.FormattingEnabled = true;
            this.BListBox.ItemHeight = 20;
            this.BListBox.Location = new System.Drawing.Point(3, 3);
            this.BListBox.Name = "BListBox";
            this.BListBox.Size = new System.Drawing.Size(191, 357);
            this.BListBox.TabIndex = 0;
            this.BListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.BListBox_DrawItem);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CListBox);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(800, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 452);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "C类";
            // 
            // CListBox
            // 
            this.CListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CListBox.FormattingEnabled = true;
            this.CListBox.ItemHeight = 19;
            this.CListBox.Location = new System.Drawing.Point(3, 19);
            this.CListBox.Name = "CListBox";
            this.CListBox.Size = new System.Drawing.Size(206, 430);
            this.CListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defineText);
            this.groupBox1.Controls.Add(this.defineLab);
            this.groupBox1.Controls.Add(this.openFile);
            this.groupBox1.Controls.Add(this.metroTextBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.titleLab);
            this.groupBox1.Controls.Add(this.titleText);
            this.groupBox1.Controls.Add(this.siteLab);
            this.groupBox1.Controls.Add(this.siteText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameLab);
            this.groupBox1.Controls.Add(this.phonenumberText);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.birthdayLab);
            this.groupBox1.Controls.Add(this.botYear);
            this.groupBox1.Controls.Add(this.phonenumberLab);
            this.groupBox1.Controls.Add(this.yearLab);
            this.groupBox1.Controls.Add(this.topYear);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 452);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A类";
            // 
            // defineText
            // 
            this.defineText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defineText.ContextMenuStrip = this.contextMenuStrip1;
            this.defineText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defineText.Location = new System.Drawing.Point(348, 55);
            this.defineText.Name = "defineText";
            this.defineText.Size = new System.Drawing.Size(219, 391);
            this.defineText.TabIndex = 17;
            this.defineText.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字符大写并追加ToolStripMenuItem,
            this.首字母大写并追加ToolStripMenuItem,
            this.字符转置并追加ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 70);
            // 
            // 字符大写并追加ToolStripMenuItem
            // 
            this.字符大写并追加ToolStripMenuItem.Name = "字符大写并追加ToolStripMenuItem";
            this.字符大写并追加ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.字符大写并追加ToolStripMenuItem.Text = "字符全部大写并追加";
            this.字符大写并追加ToolStripMenuItem.Click += new System.EventHandler(this.字符大写并追加ToolStripMenuItem_Click);
            // 
            // 首字母大写并追加ToolStripMenuItem
            // 
            this.首字母大写并追加ToolStripMenuItem.Name = "首字母大写并追加ToolStripMenuItem";
            this.首字母大写并追加ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.首字母大写并追加ToolStripMenuItem.Text = "字符首字母大写并追加";
            this.首字母大写并追加ToolStripMenuItem.Click += new System.EventHandler(this.首字母大写并追加ToolStripMenuItem_Click);
            // 
            // 字符转置并追加ToolStripMenuItem
            // 
            this.字符转置并追加ToolStripMenuItem.Name = "字符转置并追加ToolStripMenuItem";
            this.字符转置并追加ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.字符转置并追加ToolStripMenuItem.Text = "字符转置并追加";
            this.字符转置并追加ToolStripMenuItem.Click += new System.EventHandler(this.字符转置并追加ToolStripMenuItem_Click);
            // 
            // defineLab
            // 
            this.defineLab.AutoSize = true;
            this.defineLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.defineLab.Location = new System.Drawing.Point(408, 22);
            this.defineLab.Name = "defineLab";
            this.defineLab.Size = new System.Drawing.Size(107, 20);
            this.defineLab.TabIndex = 0;
            this.defineLab.Text = "自定义字符";
            this.defineLab.UseVisualStyleBackColor = true;
            // 
            // openFile
            // 
            this.openFile.Highlight = true;
            this.openFile.Location = new System.Drawing.Point(255, 299);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 15;
            this.openFile.Text = "打开";
            this.openFile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.openFile.UseSelectable = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(106, 299);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "选择文件";
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(143, 23);
            this.metroTextBox1.TabIndex = 14;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "选择文件";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 242);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 29);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleLab.Location = new System.Drawing.Point(9, 61);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(91, 20);
            this.titleLab.TabIndex = 0;
            this.titleLab.Text = "网站标题";
            this.titleLab.UseVisualStyleBackColor = true;
            // 
            // titleText
            // 
            // 
            // 
            // 
            this.titleText.CustomButton.Image = null;
            this.titleText.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.titleText.CustomButton.Name = "";
            this.titleText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.titleText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.titleText.CustomButton.TabIndex = 1;
            this.titleText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.titleText.CustomButton.UseSelectable = true;
            this.titleText.CustomButton.Visible = false;
            this.titleText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.titleText.Lines = new string[0];
            this.titleText.Location = new System.Drawing.Point(106, 55);
            this.titleText.MaxLength = 32767;
            this.titleText.Name = "titleText";
            this.titleText.PasswordChar = '\0';
            this.titleText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.titleText.SelectedText = "";
            this.titleText.SelectionLength = 0;
            this.titleText.SelectionStart = 0;
            this.titleText.ShortcutsEnabled = true;
            this.titleText.Size = new System.Drawing.Size(224, 26);
            this.titleText.TabIndex = 1;
            this.titleText.UseSelectable = true;
            this.titleText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.titleText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // siteLab
            // 
            this.siteLab.AutoSize = true;
            this.siteLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.siteLab.Location = new System.Drawing.Point(9, 107);
            this.siteLab.Name = "siteLab";
            this.siteLab.Size = new System.Drawing.Size(91, 20);
            this.siteLab.TabIndex = 0;
            this.siteLab.Text = "网站域名";
            this.siteLab.UseVisualStyleBackColor = true;
            // 
            // siteText
            // 
            // 
            // 
            // 
            this.siteText.CustomButton.Image = null;
            this.siteText.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.siteText.CustomButton.Name = "";
            this.siteText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.siteText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.siteText.CustomButton.TabIndex = 1;
            this.siteText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.siteText.CustomButton.UseSelectable = true;
            this.siteText.CustomButton.Visible = false;
            this.siteText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.siteText.Lines = new string[0];
            this.siteText.Location = new System.Drawing.Point(106, 101);
            this.siteText.MaxLength = 32767;
            this.siteText.Name = "siteText";
            this.siteText.PasswordChar = '\0';
            this.siteText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.siteText.SelectedText = "";
            this.siteText.SelectionLength = 0;
            this.siteText.SelectionStart = 0;
            this.siteText.ShortcutsEnabled = true;
            this.siteText.Size = new System.Drawing.Size(224, 26);
            this.siteText.TabIndex = 4;
            this.siteText.UseSelectable = true;
            this.siteText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.siteText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLab.Location = new System.Drawing.Point(9, 154);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(59, 20);
            this.nameLab.TabIndex = 0;
            this.nameLab.Text = "姓名";
            this.nameLab.UseVisualStyleBackColor = true;
            // 
            // phonenumberText
            // 
            // 
            // 
            // 
            this.phonenumberText.CustomButton.Image = null;
            this.phonenumberText.CustomButton.Location = new System.Drawing.Point(201, 2);
            this.phonenumberText.CustomButton.Name = "";
            this.phonenumberText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phonenumberText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phonenumberText.CustomButton.TabIndex = 1;
            this.phonenumberText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phonenumberText.CustomButton.UseSelectable = true;
            this.phonenumberText.CustomButton.Visible = false;
            this.phonenumberText.Lines = new string[0];
            this.phonenumberText.Location = new System.Drawing.Point(106, 192);
            this.phonenumberText.MaxLength = 11;
            this.phonenumberText.Name = "phonenumberText";
            this.phonenumberText.PasswordChar = '\0';
            this.phonenumberText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phonenumberText.SelectedText = "";
            this.phonenumberText.SelectionLength = 0;
            this.phonenumberText.SelectionStart = 0;
            this.phonenumberText.ShortcutsEnabled = true;
            this.phonenumberText.Size = new System.Drawing.Size(225, 26);
            this.phonenumberText.TabIndex = 6;
            this.phonenumberText.UseSelectable = true;
            this.phonenumberText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phonenumberText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.phonenumberText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPress);
            // 
            // nameText
            // 
            // 
            // 
            // 
            this.nameText.CustomButton.Image = null;
            this.nameText.CustomButton.Location = new System.Drawing.Point(200, 2);
            this.nameText.CustomButton.Name = "";
            this.nameText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameText.CustomButton.TabIndex = 1;
            this.nameText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameText.CustomButton.UseSelectable = true;
            this.nameText.CustomButton.Visible = false;
            this.nameText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameText.Lines = new string[0];
            this.nameText.Location = new System.Drawing.Point(106, 148);
            this.nameText.MaxLength = 32767;
            this.nameText.Name = "nameText";
            this.nameText.PasswordChar = '\0';
            this.nameText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameText.SelectedText = "";
            this.nameText.SelectionLength = 0;
            this.nameText.SelectionStart = 0;
            this.nameText.ShortcutsEnabled = true;
            this.nameText.Size = new System.Drawing.Size(224, 26);
            this.nameText.TabIndex = 5;
            this.nameText.UseSelectable = true;
            this.nameText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.username.Location = new System.Drawing.Point(9, 299);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(75, 20);
            this.username.TabIndex = 0;
            this.username.Text = "用户名";
            this.username.UseVisualStyleBackColor = true;
            // 
            // birthdayLab
            // 
            this.birthdayLab.AutoSize = true;
            this.birthdayLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.birthdayLab.Location = new System.Drawing.Point(9, 248);
            this.birthdayLab.Name = "birthdayLab";
            this.birthdayLab.Size = new System.Drawing.Size(59, 20);
            this.birthdayLab.TabIndex = 0;
            this.birthdayLab.Text = "生日";
            this.birthdayLab.UseVisualStyleBackColor = true;
            // 
            // botYear
            // 
            // 
            // 
            // 
            this.botYear.CustomButton.Image = null;
            this.botYear.CustomButton.Location = new System.Drawing.Point(16, 2);
            this.botYear.CustomButton.Name = "";
            this.botYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.botYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.botYear.CustomButton.TabIndex = 1;
            this.botYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.botYear.CustomButton.UseSelectable = true;
            this.botYear.CustomButton.Visible = false;
            this.botYear.Lines = new string[0];
            this.botYear.Location = new System.Drawing.Point(107, 347);
            this.botYear.MaxLength = 4;
            this.botYear.Name = "botYear";
            this.botYear.PasswordChar = '\0';
            this.botYear.PromptText = "最小";
            this.botYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.botYear.SelectedText = "";
            this.botYear.SelectionLength = 0;
            this.botYear.SelectionStart = 0;
            this.botYear.ShortcutsEnabled = true;
            this.botYear.Size = new System.Drawing.Size(40, 26);
            this.botYear.TabIndex = 2;
            this.botYear.UseSelectable = true;
            this.botYear.WaterMark = "最小";
            this.botYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.botYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.botYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPress);
            // 
            // phonenumberLab
            // 
            this.phonenumberLab.AutoSize = true;
            this.phonenumberLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phonenumberLab.Location = new System.Drawing.Point(9, 198);
            this.phonenumberLab.Name = "phonenumberLab";
            this.phonenumberLab.Size = new System.Drawing.Size(75, 20);
            this.phonenumberLab.TabIndex = 0;
            this.phonenumberLab.Text = "手机号";
            this.phonenumberLab.UseVisualStyleBackColor = true;
            // 
            // yearLab
            // 
            this.yearLab.AutoSize = true;
            this.yearLab.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yearLab.Location = new System.Drawing.Point(9, 353);
            this.yearLab.Name = "yearLab";
            this.yearLab.Size = new System.Drawing.Size(59, 20);
            this.yearLab.TabIndex = 0;
            this.yearLab.Text = "年份";
            this.yearLab.UseVisualStyleBackColor = true;
            // 
            // topYear
            // 
            // 
            // 
            // 
            this.topYear.CustomButton.Image = null;
            this.topYear.CustomButton.Location = new System.Drawing.Point(16, 2);
            this.topYear.CustomButton.Name = "";
            this.topYear.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.topYear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.topYear.CustomButton.TabIndex = 1;
            this.topYear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.topYear.CustomButton.UseSelectable = true;
            this.topYear.CustomButton.Visible = false;
            this.topYear.Lines = new string[0];
            this.topYear.Location = new System.Drawing.Point(171, 347);
            this.topYear.MaxLength = 4;
            this.topYear.Name = "topYear";
            this.topYear.PasswordChar = '\0';
            this.topYear.PromptText = "最大";
            this.topYear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.topYear.SelectedText = "";
            this.topYear.SelectionLength = 0;
            this.topYear.SelectionStart = 0;
            this.topYear.ShortcutsEnabled = true;
            this.topYear.Size = new System.Drawing.Size(40, 26);
            this.topYear.TabIndex = 3;
            this.topYear.UseSelectable = true;
            this.topYear.WaterMark = "最大";
            this.topYear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.topYear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.topYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.appendfile);
            this.panel1.Controls.Add(this.appendDict);
            this.panel1.Controls.Add(this.generateDict);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 559);
            this.panel1.TabIndex = 18;
            // 
            // save
            // 
            this.save.Highlight = true;
            this.save.Location = new System.Drawing.Point(9, 67);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(80, 23);
            this.save.TabIndex = 19;
            this.save.Text = "保存配置";
            this.save.Theme = MetroFramework.MetroThemeStyle.Light;
            this.save.UseSelectable = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // appendfile
            // 
            this.appendfile.Highlight = true;
            this.appendfile.Location = new System.Drawing.Point(348, 67);
            this.appendfile.Name = "appendfile";
            this.appendfile.Size = new System.Drawing.Size(80, 23);
            this.appendfile.TabIndex = 18;
            this.appendfile.Text = "打开";
            this.appendfile.Theme = MetroFramework.MetroThemeStyle.Light;
            this.appendfile.UseSelectable = true;
            this.appendfile.Click += new System.EventHandler(this.appendfile_Click);
            // 
            // appendDict
            // 
            this.appendDict.AutoSize = true;
            this.appendDict.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.appendDict.Location = new System.Drawing.Point(348, 40);
            this.appendDict.Name = "appendDict";
            this.appendDict.Size = new System.Drawing.Size(91, 20);
            this.appendDict.TabIndex = 14;
            this.appendDict.Text = "追加字典";
            this.appendDict.UseVisualStyleBackColor = true;
            // 
            // generateDict
            // 
            this.generateDict.BackColor = System.Drawing.Color.WhiteSmoke;
            this.generateDict.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.generateDict.Location = new System.Drawing.Point(803, 37);
            this.generateDict.Name = "generateDict";
            this.generateDict.Size = new System.Drawing.Size(195, 53);
            this.generateDict.TabIndex = 0;
            this.generateDict.Text = "生成字典";
            this.generateDict.UseVisualStyleBackColor = false;
            this.generateDict.Click += new System.EventHandler(this.generateDict_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(445, 37);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(349, 53);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(132, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 53);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "字典组合方式";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(108, 22);
            this.toolStripButton1.Text = "重新加载配置文件";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(110, 22);
            this.toolStripButton3.Text = "txt文件转json格式";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton4.Text = "帮助";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(20, 60);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1013, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 639);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "字典生成器";
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroComboBox comboBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton openFile;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroDateTime dateTimePicker1;
        private System.Windows.Forms.CheckBox titleLab;
        private MetroFramework.Controls.MetroTextBox titleText;
        private System.Windows.Forms.CheckBox siteLab;
        private MetroFramework.Controls.MetroTextBox siteText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox nameLab;
        private MetroFramework.Controls.MetroTextBox phonenumberText;
        private MetroFramework.Controls.MetroTextBox nameText;
        private System.Windows.Forms.CheckBox username;
        private System.Windows.Forms.CheckBox birthdayLab;
        private System.Windows.Forms.CheckBox defineLab;
        private MetroFramework.Controls.MetroTextBox botYear;
        private System.Windows.Forms.CheckBox phonenumberLab;
        private System.Windows.Forms.CheckBox yearLab;
        private MetroFramework.Controls.MetroTextBox topYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox defineText;
        private System.Windows.Forms.Button generateDict;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListBox BListBox;
        private System.Windows.Forms.ListBox CListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 字符大写并追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 首字母大写并追加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字符转置并追加ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton appendfile;
        private System.Windows.Forms.CheckBox appendDict;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MetroFramework.Controls.MetroButton save;
    }
}

