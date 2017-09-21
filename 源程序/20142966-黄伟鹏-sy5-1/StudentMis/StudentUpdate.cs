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

    public partial class StudentUpdate : Form
    {
        // 变量 ***************************************************************
        private string mstrID = "";
        private DBCL.DBEntities db = new DBCL.DBEntities();
        private void InitControls()
        {
            lbMessage.Text = " ";
        }
        
        public StudentUpdate()
        {
            InitializeComponent();
        }
        public StudentUpdate(string strID)
        {
            InitializeComponent();
            mstrID = strID;
        }
        private void StudentUpdate_Load(object sender, EventArgs e)
        {
            lbMessage.Text = "";

            var model = db.student.FirstOrDefault(m => m.username == mstrID);

            if (model == null)
            {
                return;
            }


            tbusername.Text = model.username;
            tbusername.ReadOnly = true;
            tbpassword.Text = model.password;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strID = "";
            string strName = "";

            lbMessage.Text = "";

            if (tbpassword.Text.Trim() == "")
            {
                lbMessage.Text = "密码不能为空!";
                //MessageBox.Show("学号不能为空!");
                tbpassword.Focus();
                return;
            }
            if (tbfox.Text.Trim() == "")
            {
                lbMessage.Text = "确认密码不能为空!";
                tbfox.Focus();
                return;
            }

            // 检验密码确认密码是否相同
            if (tbpassword.Text.Trim() != tbfox.Text.Trim())
            {
                lbMessage.Text = "密码与确认密码不相同!";
                tbfox.Focus();
                return;
            }
            // 获取数据
            strID = tbusername.Text.Trim();
            strName = tbfox.Text.Trim();
            var modell = db.student.FirstOrDefault(m => m.username == strID);
            if (modell == null)
            {
                MessageBox.Show("该学号在数据库中不存在!");
                return;
            }

            modell.username = strID;
            modell.password = strName;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("编辑失败!");
                return;
            }

            this.Close();
         /*   try
            {
                DBCL.student model = new DBCL.student();

                model.username = strID;
                model.password = strName;
                db.student.Add(model);
                db.SaveChanges();

            }
            catch
            {
                MessageBox.Show("添加失败!");
                return;
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
