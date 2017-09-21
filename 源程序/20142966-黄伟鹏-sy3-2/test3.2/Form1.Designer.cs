namespace test3._2
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show = new System.Windows.Forms.ListBox();
            this.dance = new System.Windows.Forms.CheckBox();
            this.study = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.woman = new System.Windows.Forms.RadioButton();
            this.sing = new System.Windows.Forms.CheckBox();
            this.major = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.man = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(72, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dance);
            this.groupBox1.Controls.Add(this.study);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.woman);
            this.groupBox1.Controls.Add(this.sing);
            this.groupBox1.Controls.Add(this.major);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.man);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // show
            // 
            this.show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.show.FormattingEnabled = true;
            this.show.ItemHeight = 12;
            this.show.Location = new System.Drawing.Point(32, 278);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(208, 122);
            this.show.TabIndex = 5;
            // 
            // dance
            // 
            this.dance.AutoSize = true;
            this.dance.Location = new System.Drawing.Point(126, 171);
            this.dance.Name = "dance";
            this.dance.Size = new System.Drawing.Size(48, 16);
            this.dance.TabIndex = 9;
            this.dance.Text = "跳舞";
            this.dance.UseVisualStyleBackColor = true;
            // 
            // study
            // 
            this.study.AutoSize = true;
            this.study.Location = new System.Drawing.Point(180, 171);
            this.study.Name = "study";
            this.study.Size = new System.Drawing.Size(48, 16);
            this.study.TabIndex = 8;
            this.study.Text = "编程";
            this.study.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "专业";
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Location = new System.Drawing.Point(137, 89);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(35, 16);
            this.woman.TabIndex = 6;
            this.woman.TabStop = true;
            this.woman.Text = "女";
            this.woman.UseVisualStyleBackColor = true;
            // 
            // sing
            // 
            this.sing.AutoSize = true;
            this.sing.Location = new System.Drawing.Point(72, 172);
            this.sing.Name = "sing";
            this.sing.Size = new System.Drawing.Size(48, 16);
            this.sing.TabIndex = 3;
            this.sing.Text = "唱歌";
            this.sing.UseVisualStyleBackColor = true;
            // 
            // major
            // 
            this.major.FormattingEnabled = true;
            this.major.Location = new System.Drawing.Point(72, 124);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(121, 20);
            this.major.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "爱好";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别";
            // 
            // num
            // 
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num.Location = new System.Drawing.Point(72, 52);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 21);
            this.num.TabIndex = 3;
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(72, 89);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(35, 16);
            this.man.TabIndex = 2;
            this.man.TabStop = true;
            this.man.Text = "男";
            this.man.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.show);
            this.Name = "Form1";
            this.Text = "黄伟鹏";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.CheckBox sing;
        private System.Windows.Forms.ComboBox major;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox show;
        private System.Windows.Forms.CheckBox dance;
        private System.Windows.Forms.CheckBox study;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

