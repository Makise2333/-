
namespace LibraryManage
{
    partial class admin
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
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6_bookmanage = new System.Windows.Forms.Button();
            this.tushuguanli = new System.Windows.Forms.GroupBox();
            this.图书夹 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3_Bnu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox2_Bname = new System.Windows.Forms.TextBox();
            this.button_addbook = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3_alternum = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4_Bnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5_id = new System.Windows.Forms.TextBox();
            this.textBox6_Bname = new System.Windows.Forms.TextBox();
            this.button2_alterbook = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4_deletebook = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1_deleteBook = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tushuyilan = new System.Windows.Forms.GroupBox();
            this.dataGridView_showbook = new System.Windows.Forms.DataGridView();
            this.button_show = new System.Windows.Forms.Button();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tushuguanli.SuspendLayout();
            this.图书夹.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_deleteBook)).BeginInit();
            this.tushuyilan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showbook)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "借阅管理";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "读者管理";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6_bookmanage
            // 
            this.button6_bookmanage.Location = new System.Drawing.Point(12, 136);
            this.button6_bookmanage.Name = "button6_bookmanage";
            this.button6_bookmanage.Size = new System.Drawing.Size(194, 66);
            this.button6_bookmanage.TabIndex = 18;
            this.button6_bookmanage.Text = "图书管理";
            this.button6_bookmanage.UseVisualStyleBackColor = true;
            this.button6_bookmanage.Click += new System.EventHandler(this.button6_bookmanage_Click);
            // 
            // tushuguanli
            // 
            this.tushuguanli.Controls.Add(this.图书夹);
            this.tushuguanli.Location = new System.Drawing.Point(212, 3);
            this.tushuguanli.Name = "tushuguanli";
            this.tushuguanli.Size = new System.Drawing.Size(703, 422);
            this.tushuguanli.TabIndex = 19;
            this.tushuguanli.TabStop = false;
            // 
            // 图书夹
            // 
            this.图书夹.Controls.Add(this.tabPage1);
            this.图书夹.Controls.Add(this.tabPage2);
            this.图书夹.Controls.Add(this.tabPage3);
            this.图书夹.Location = new System.Drawing.Point(7, 10);
            this.图书夹.Margin = new System.Windows.Forms.Padding(4);
            this.图书夹.Name = "图书夹";
            this.图书夹.SelectedIndex = 0;
            this.图书夹.Size = new System.Drawing.Size(689, 405);
            this.图书夹.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox3_Bnu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox1_id);
            this.tabPage1.Controls.Add(this.textBox2_Bname);
            this.tabPage1.Controls.Add(this.button_addbook);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(696, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图书入库";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3_Bnu
            // 
            this.textBox3_Bnu.Location = new System.Drawing.Point(269, 199);
            this.textBox3_Bnu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3_Bnu.Name = "textBox3_Bnu";
            this.textBox3_Bnu.Size = new System.Drawing.Size(173, 25);
            this.textBox3_Bnu.TabIndex = 6;
            this.textBox3_Bnu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "数量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "书名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "书号：";
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(268, 56);
            this.textBox1_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(175, 25);
            this.textBox1_id.TabIndex = 1;
            this.textBox1_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2_Bname
            // 
            this.textBox2_Bname.Location = new System.Drawing.Point(268, 125);
            this.textBox2_Bname.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_Bname.Name = "textBox2_Bname";
            this.textBox2_Bname.Size = new System.Drawing.Size(175, 25);
            this.textBox2_Bname.TabIndex = 2;
            this.textBox2_Bname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_addbook
            // 
            this.button_addbook.Location = new System.Drawing.Point(294, 294);
            this.button_addbook.Margin = new System.Windows.Forms.Padding(4);
            this.button_addbook.Name = "button_addbook";
            this.button_addbook.Size = new System.Drawing.Size(100, 29);
            this.button_addbook.TabIndex = 0;
            this.button_addbook.Text = "添加图书";
            this.button_addbook.UseVisualStyleBackColor = true;
            this.button_addbook.Click += new System.EventHandler(this.button_addbook_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3_alternum);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox4_Bnum);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textBox5_id);
            this.tabPage2.Controls.Add(this.textBox6_Bname);
            this.tabPage2.Controls.Add(this.button2_alterbook);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(696, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图书修改";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3_alternum
            // 
            this.button3_alternum.Location = new System.Drawing.Point(387, 281);
            this.button3_alternum.Margin = new System.Windows.Forms.Padding(4);
            this.button3_alternum.Name = "button3_alternum";
            this.button3_alternum.Size = new System.Drawing.Size(100, 29);
            this.button3_alternum.TabIndex = 15;
            this.button3_alternum.Text = "修改数量";
            this.button3_alternum.UseVisualStyleBackColor = true;
            this.button3_alternum.Click += new System.EventHandler(this.button3_alternum_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "请输入书号，选择修改项目：";
            // 
            // textBox4_Bnum
            // 
            this.textBox4_Bnum.Location = new System.Drawing.Point(289, 191);
            this.textBox4_Bnum.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4_Bnum.Name = "textBox4_Bnum";
            this.textBox4_Bnum.Size = new System.Drawing.Size(173, 25);
            this.textBox4_Bnum.TabIndex = 13;
            this.textBox4_Bnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "数量:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "书名：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "书号：";
            // 
            // textBox5_id
            // 
            this.textBox5_id.Location = new System.Drawing.Point(287, 84);
            this.textBox5_id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5_id.Name = "textBox5_id";
            this.textBox5_id.Size = new System.Drawing.Size(175, 25);
            this.textBox5_id.TabIndex = 8;
            this.textBox5_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6_Bname
            // 
            this.textBox6_Bname.Location = new System.Drawing.Point(289, 136);
            this.textBox6_Bname.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6_Bname.Name = "textBox6_Bname";
            this.textBox6_Bname.Size = new System.Drawing.Size(175, 25);
            this.textBox6_Bname.TabIndex = 9;
            this.textBox6_Bname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2_alterbook
            // 
            this.button2_alterbook.Location = new System.Drawing.Point(230, 281);
            this.button2_alterbook.Margin = new System.Windows.Forms.Padding(4);
            this.button2_alterbook.Name = "button2_alterbook";
            this.button2_alterbook.Size = new System.Drawing.Size(100, 29);
            this.button2_alterbook.TabIndex = 7;
            this.button2_alterbook.Text = "修改书名";
            this.button2_alterbook.UseVisualStyleBackColor = true;
            this.button2_alterbook.Click += new System.EventHandler(this.button2_alterbook_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4_deletebook);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dataGridView1_deleteBook);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(681, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "删除图书";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4_deletebook
            // 
            this.button4_deletebook.Location = new System.Drawing.Point(271, 321);
            this.button4_deletebook.Margin = new System.Windows.Forms.Padding(4);
            this.button4_deletebook.Name = "button4_deletebook";
            this.button4_deletebook.Size = new System.Drawing.Size(100, 35);
            this.button4_deletebook.TabIndex = 2;
            this.button4_deletebook.Text = "删除";
            this.button4_deletebook.UseVisualStyleBackColor = true;
            this.button4_deletebook.Click += new System.EventHandler(this.button4_deletebook_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "图书信息如下：";
            // 
            // dataGridView1_deleteBook
            // 
            this.dataGridView1_deleteBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_deleteBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1_deleteBook.Location = new System.Drawing.Point(8, 22);
            this.dataGridView1_deleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1_deleteBook.Name = "dataGridView1_deleteBook";
            this.dataGridView1_deleteBook.RowHeadersWidth = 51;
            this.dataGridView1_deleteBook.RowTemplate.Height = 23;
            this.dataGridView1_deleteBook.Size = new System.Drawing.Size(668, 274);
            this.dataGridView1_deleteBook.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "书号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "书名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "number";
            this.Column2.HeaderText = "数量";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "author";
            this.Column3.HeaderText = "作者";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "press";
            this.Column4.HeaderText = "出版社";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // tushuyilan
            // 
            this.tushuyilan.Controls.Add(this.dataGridView_showbook);
            this.tushuyilan.Location = new System.Drawing.Point(212, 3);
            this.tushuyilan.Name = "tushuyilan";
            this.tushuyilan.Size = new System.Drawing.Size(711, 429);
            this.tushuyilan.TabIndex = 20;
            this.tushuyilan.TabStop = false;
            // 
            // dataGridView_showbook
            // 
            this.dataGridView_showbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column5,
            this.Column6});
            this.dataGridView_showbook.Location = new System.Drawing.Point(11, 14);
            this.dataGridView_showbook.Name = "dataGridView_showbook";
            this.dataGridView_showbook.RowHeadersWidth = 51;
            this.dataGridView_showbook.RowTemplate.Height = 27;
            this.dataGridView_showbook.Size = new System.Drawing.Size(681, 382);
            this.dataGridView_showbook.TabIndex = 0;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(12, 12);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(194, 66);
            this.button_show.TabIndex = 20;
            this.button_show.Text = "图书一览";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "id";
            this.Column10.HeaderText = "书号";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "name";
            this.Column11.HeaderText = "书名";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 130;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "number";
            this.Column12.HeaderText = "数量";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "author";
            this.Column5.HeaderText = "作者";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "press";
            this.Column6.HeaderText = "出版社";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 135;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(913, 413);
            this.Controls.Add(this.tushuyilan);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.tushuguanli);
            this.Controls.Add(this.button6_bookmanage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "admin";
            this.Text = "图书管理系统-管理员界面";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tushuguanli.ResumeLayout(false);
            this.图书夹.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_deleteBook)).EndInit();
            this.tushuyilan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showbook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6_bookmanage;
        private System.Windows.Forms.GroupBox tushuguanli;
        private System.Windows.Forms.TabControl 图书夹;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox3_Bnu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox2_Bname;
        private System.Windows.Forms.Button button_addbook;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3_alternum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4_Bnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5_id;
        private System.Windows.Forms.TextBox textBox6_Bname;
        private System.Windows.Forms.Button button2_alterbook;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4_deletebook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1_deleteBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox tushuyilan;
        private System.Windows.Forms.DataGridView dataGridView_showbook;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}