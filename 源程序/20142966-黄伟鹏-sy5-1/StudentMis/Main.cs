using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMis
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
           Login Login1 = new Login();
           Login1.Show();
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAdd frmStudentAdd = new StudentAdd();
            frmStudentAdd.ShowDialog(this);
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentUpdate frmStudentAdd = new StudentUpdate();
            frmStudentAdd.ShowDialog(this);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
