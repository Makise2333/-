
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
            this.登录按钮 = new System.Windows.Forms.Button();
            this.注册按钮 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.状态 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.注册 = new System.Windows.Forms.Button();
            this.登录 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.用户名_text = new System.Windows.Forms.TextBox();
            this.密码_text = new System.Windows.Forms.TextBox();
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
            this.登录按钮.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.登录按钮.Location = new System.Drawing.Point(132, 0);
            this.登录按钮.Name = "登录按钮";
            this.登录按钮.Size = new System.Drawing.Size(57, 29);
            this.登录按钮.TabIndex = 13;
            this.登录按钮.Text = "登录";
            this.登录按钮.UseVisualStyleBackColor = false;
            this.登录按钮.Click += new System.EventHandler(this.登录按钮_Click);
            // 
            // 注册按钮
            // 
            this.注册按钮.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.注册按钮.Location = new System.Drawing.Point(185, 0);
            this.注册按钮.Name = "注册按钮";
            this.注册按钮.Size = new System.Drawing.Size(57, 29);
            this.注册按钮.TabIndex = 14;
            this.注册按钮.Text = "注册";
            this.注册按钮.UseVisualStyleBackColor = false;
            this.注册按钮.Click += new System.EventHandler(this.注册按钮_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.状态);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.注册);
            this.groupBox2.Controls.Add(this.登录);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.用户名_text);
            this.groupBox2.Controls.Add(this.密码_text);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.登录按钮);
            this.groupBox2.Controls.Add(this.注册按钮);
            this.groupBox2.Location = new System.Drawing.Point(197, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 302);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // 状态
            // 
            this.状态.AutoSize = true;
            this.状态.Location = new System.Drawing.Point(7, 284);
            this.状态.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.状态.Name = "状态";
            this.状态.Size = new System.Drawing.Size(82, 15);
            this.状态.TabIndex = 25;
            this.状态.Text = "状态：登录";
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
            this.注册.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.注册.Location = new System.Drawing.Point(142, 220);
            this.注册.Margin = new System.Windows.Forms.Padding(4);
            this.注册.Name = "注册";
            this.注册.Size = new System.Drawing.Size(100, 29);
            this.注册.TabIndex = 23;
            this.注册.Text = "注册";
            this.注册.UseVisualStyleBackColor = true;
            this.注册.Visible = false;
            this.注册.Click += new System.EventHandler(this.注册_Click);
            // 
            // 登录
            // 
            this.登录.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.登录.Location = new System.Drawing.Point(142, 220);
            this.登录.Margin = new System.Windows.Forms.Padding(4);
            this.登录.Name = "登录";
            this.登录.Size = new System.Drawing.Size(100, 29);
            this.登录.TabIndex = 22;
            this.登录.Text = "登录";
            this.登录.UseVisualStyleBackColor = true;
            this.登录.Click += new System.EventHandler(this.登录_Click);
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
            this.用户名_text.Location = new System.Drawing.Point(132, 60);
            this.用户名_text.Margin = new System.Windows.Forms.Padding(4);
            this.用户名_text.Name = "用户名_text";
            this.用户名_text.Size = new System.Drawing.Size(176, 25);
            this.用户名_text.TabIndex = 15;
            this.用户名_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 密码_text
            // 
            this.密码_text.Location = new System.Drawing.Point(132, 109);
            this.密码_text.Margin = new System.Windows.Forms.Padding(4);
            this.密码_text.Name = "密码_text";
            this.密码_text.Size = new System.Drawing.Size(176, 25);
            this.密码_text.TabIndex = 16;
            this.密码_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        private System.Windows.Forms.Button 登录按钮;
        private System.Windows.Forms.Button 注册按钮;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox 用户名_text;
        private System.Windows.Forms.TextBox 密码_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 注册;
        private System.Windows.Forms.Button 登录;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 状态;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}