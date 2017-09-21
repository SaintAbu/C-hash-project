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
    public partial class StudentAdd : Form
    {
        private DBCL.DBEntities db = new DBCL.DBEntities();
        private void InitControls()
        {
            lbMessage.Text = " ";
        }
        public StudentAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strID = "";
            string strName = "";
            lbMessage.Text = " ";
          

            if (tbID.Text.Trim() == "")
            {
                lbMessage.Text = "学号不能为空!";
                //MessageBox.Show("学号不能为空!");
                tbID.Focus();
                return;
            }
            if (tbName.Text.Trim() == "")
            {
                lbMessage.Text = "修改密码不能为空!";
                tbName.Focus();
                return;
            }

            // 获取数据
            strID = tbID.Text.Trim();
            strName = tbName.Text.Trim();

            // 检验密码确认密码是否相同
          

           

            try
            {
                DBCL.student model = new DBCL.student();

                model.username = strID;
                model.password = strName;
                db.student.Add(model);
                db.SaveChanges();
                this.Close();
                Login frmMain = new Login();
                frmMain.Show();
            }
            catch
            {
                MessageBox.Show("添加失败!");
                return;
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frmMain = new Login();
            frmMain.Show();
        }

        private void lbMessage_Click(object sender, EventArgs e)
        {

        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            lbMessage.Text = "";
        }
    }
}
