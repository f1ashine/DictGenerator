using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DictGenerator
{
    public partial class EditForm : MetroForm
    {
        public EditForm()
        {
            InitializeComponent();
        }
        public void setText(String s)
        {
            this.richTextBox1.Text = s;
        }
    }
}
