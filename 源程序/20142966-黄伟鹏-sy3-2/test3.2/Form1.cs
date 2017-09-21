using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            major.DropDownStyle = ComboBoxStyle.DropDownList;
            major.Items.Add("软件工程");
            major.Items.Add("计算机科学与技术");
            major.Items.Add("网络工程");
            major.Items.Add("数字媒体");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            show.Items.Add(name.Text.Trim());
            show.Items.Add(num.Text.Trim());

            if (man.Checked == true)
            {
                show.Items.Add(man.Text.Trim());
            }
            else if (woman.Checked == true)
            {
                show.Items.Add(woman.Text.Trim());
            }

            if (sing.CheckState == CheckState.Checked)
            {
                show.Items.Add(sing.Text.Trim());
            }
            if (dance.CheckState == CheckState.Checked)
            {
                show.Items.Add(dance.Text.Trim());
            }
            if (study.CheckState == CheckState.Checked)
            {
                show.Items.Add(study.Text.Trim());
            }
            show.Items.Add(major.Text.Trim());

        }
    }
}
