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
    public partial class Login : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAdd frmStudentAdd = new StudentAdd();
            frmStudentAdd.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUserName = "";
            string strPWD = "";
            lbMessage.Text = " ";
            if (tbusername.Text.Trim() == "")
            {
                lbMessage.Text = "账号不能为空!";
                //MessageBox.Show("学号不能为空!");
                tbusername.Focus();
                return;
            }
            if (tbpassword.Text.Trim() == "")
            {
                lbMessage.Text = "密码不能为空!";
                tbpassword.Focus();
                return;
            }
            strUserName = tbusername.Text.Trim();
            strPWD = tbpassword.Text.Trim();
            var model = db.student.FirstOrDefault(m => m.username == strUserName);

            if (model == null)
            {
                lbMessage.Text = "账号不存在，请重新输入!";
                return;
            }
            if (strPWD == model.password)
            {
                this.Hide();
                Main frmMain = new Main();
                frmMain.Show();
            }
            else
            {
                lbMessage.Text = "用户名与密码不匹配!";
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbMessage.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
