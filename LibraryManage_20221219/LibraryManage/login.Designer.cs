
namespace LibraryManage
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.图书管理系统 = new System.Windows.Forms.Label();
            this.denglubutton = new System.Windows.Forms.Button();
            this.zhucebutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.zhuangtai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.zhuce = new System.Windows.Forms.Button();
            this.denglu = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 图书管理系统
            // 
            this.图书管理系统.AutoSize = true;
            this.图书管理系统.Font = new System.Drawing.Font("华文楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.图书管理系统.Location = new System.Drawing.Point(217, 31);
            this.图书管理系统.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.图书管理系统.Name = "图书管理系统";
            this.图书管理系统.Size = new System.Drawing.Size(349, 30);
            this.图书管理系统.TabIndex = 8;
            this.图书管理系统.Text = "安徽财经大学图书管理系统";
            // 
            // 登录按钮
            // 
            this.denglubutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.denglubutton.Location = new System.Drawing.Point(132, 0);
            this.denglubutton.Name = "登录按钮";
            this.denglubutton.Size = new System.Drawing.Size(57, 29);
            this.denglubutton.TabIndex = 13;
            this.denglubutton.Text = "登录";
            this.denglubutton.UseVisualStyleBackColor = false;
            this.denglubutton.Click += new System.EventHandler(this.denglubutton_Click);
            // 
            // 注册按钮
            // 
            this.zhucebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.zhucebutton.Location = new System.Drawing.Point(185, 0);
            this.zhucebutton.Name = "注册按钮";
            this.zhucebutton.Size = new System.Drawing.Size(57, 29);
            this.zhucebutton.TabIndex = 14;
            this.zhucebutton.Text = "注册";
            this.zhucebutton.UseVisualStyleBackColor = false;
            this.zhucebutton.Click += new System.EventHandler(this.zhucebutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zhuangtai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.zhuce);
            this.groupBox2.Controls.Add(this.denglu);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.username_text);
            this.groupBox2.Controls.Add(this.password_text);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.denglubutton);
            this.groupBox2.Controls.Add(this.zhucebutton);
            this.groupBox2.Location = new System.Drawing.Point(197, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 302);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // 状态
            // 
            this.zhuangtai.AutoSize = true;
            this.zhuangtai.Location = new System.Drawing.Point(7, 284);
            this.zhuangtai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zhuangtai.Name = "状态";
            this.zhuangtai.Size = new System.Drawing.Size(82, 15);
            this.zhuangtai.TabIndex = 25;
            this.zhuangtai.Text = "状态：登录";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(177, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "  ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 注册
            // 
            this.zhuce.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zhuce.Location = new System.Drawing.Point(142, 220);
            this.zhuce.Margin = new System.Windows.Forms.Padding(4);
            this.zhuce.Name = "注册";
            this.zhuce.Size = new System.Drawing.Size(100, 29);
            this.zhuce.TabIndex = 23;
            this.zhuce.Text = "注册";
            this.zhuce.UseVisualStyleBackColor = true;
            this.zhuce.Visible = false;
            this.zhuce.Click += new System.EventHandler(this.zhuce_Click);
            // 
            // 登录
            // 
            this.denglu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.denglu.Location = new System.Drawing.Point(142, 220);
            this.denglu.Margin = new System.Windows.Forms.Padding(4);
            this.denglu.Name = "登录";
            this.denglu.Size = new System.Drawing.Size(100, 29);
            this.denglu.TabIndex = 22;
            this.denglu.Text = "登录";
            this.denglu.UseVisualStyleBackColor = true;
            this.denglu.Click += new System.EventHandler(this.denglu_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 180);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "学生";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(220, 180);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.Text = "管理员";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // 用户名_text
            // 
            this.username_text.Location = new System.Drawing.Point(132, 60);
            this.username_text.Margin = new System.Windows.Forms.Padding(4);
            this.username_text.Name = "用户名_text";
            this.username_text.Size = new System.Drawing.Size(176, 25);
            this.username_text.TabIndex = 15;
            this.username_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 密码_text
            // 
            this.password_text.Location = new System.Drawing.Point(132, 109);
            this.password_text.Margin = new System.Windows.Forms.Padding(4);
            this.password_text.Name = "密码_text";
            this.password_text.Size = new System.Drawing.Size(176, 25);
            this.password_text.TabIndex = 16;
            this.password_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "密  码";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.图书管理系统);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "login";
            this.Text = "图书管理系统";
            this.Load += new System.EventHandler(this.login_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 图书管理系统;
        private System.Windows.Forms.Button denglubutton;
        private System.Windows.Forms.Button zhucebutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zhuce;
        private System.Windows.Forms.Button denglu;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label zhuangtai;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}