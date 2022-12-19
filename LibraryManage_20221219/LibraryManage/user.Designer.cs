
namespace LibraryManage
{
    partial class user
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_showbook = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3辅助 = new System.Windows.Forms.TextBox();
            this.textBox2辅助1 = new System.Windows.Forms.TextBox();
            this.label1user = new System.Windows.Forms.Label();
            this.textBox_书号 = new System.Windows.Forms.TextBox();
            this.dataGridView1_show = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_borrow = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox书名 = new System.Windows.Forms.TextBox();
            this.zs3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1书号 = new System.Windows.Forms.TextBox();
            this.label书号 = new System.Windows.Forms.Label();
            this.label用户名 = new System.Windows.Forms.Label();
            this.label2_user = new System.Windows.Forms.Label();
            this.button还书按钮 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView_showborrow = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView_showreturn = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showbook)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_show)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showborrow)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showreturn)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_showbook);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图书一览";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_showbook
            // 
            this.dataGridView_showbook.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView_showbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bname,
            this.bnum,
            this.Column6,
            this.Column10});
            this.dataGridView_showbook.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_showbook.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_showbook.Name = "dataGridView_showbook";
            this.dataGridView_showbook.RowHeadersWidth = 51;
            this.dataGridView_showbook.RowTemplate.Height = 23;
            this.dataGridView_showbook.Size = new System.Drawing.Size(836, 424);
            this.dataGridView_showbook.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 453);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.textBox3辅助);
            this.tabPage2.Controls.Add(this.textBox2辅助1);
            this.tabPage2.Controls.Add(this.label1user);
            this.tabPage2.Controls.Add(this.textBox_书号);
            this.tabPage2.Controls.Add(this.dataGridView1_show);
            this.tabPage2.Controls.Add(this.button_borrow);
            this.tabPage2.Controls.Add(this.button_select);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBox书名);
            this.tabPage2.Controls.Add(this.zs3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "借书";
            // 
            // textBox3辅助
            // 
            this.textBox3辅助.Location = new System.Drawing.Point(486, 220);
            this.textBox3辅助.Name = "textBox3辅助";
            this.textBox3辅助.Size = new System.Drawing.Size(100, 25);
            this.textBox3辅助.TabIndex = 27;
            this.textBox3辅助.Visible = false;
            // 
            // textBox2辅助1
            // 
            this.textBox2辅助1.Location = new System.Drawing.Point(486, 155);
            this.textBox2辅助1.Name = "textBox2辅助1";
            this.textBox2辅助1.Size = new System.Drawing.Size(100, 25);
            this.textBox2辅助1.TabIndex = 26;
            this.textBox2辅助1.Visible = false;
            // 
            // label1user
            // 
            this.label1user.AutoSize = true;
            this.label1user.BackColor = System.Drawing.Color.Chartreuse;
            this.label1user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1user.Location = new System.Drawing.Point(513, 192);
            this.label1user.Name = "label1user";
            this.label1user.Size = new System.Drawing.Size(55, 15);
            this.label1user.TabIndex = 25;
            this.label1user.Text = "label1";
            this.label1user.Visible = false;
            // 
            // textBox_书号
            // 
            this.textBox_书号.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox_书号.Location = new System.Drawing.Point(141, 121);
            this.textBox_书号.Name = "textBox_书号";
            this.textBox_书号.Size = new System.Drawing.Size(164, 34);
            this.textBox_书号.TabIndex = 24;
            // 
            // dataGridView1_show
            // 
            this.dataGridView1_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1_show.Location = new System.Drawing.Point(350, 6);
            this.dataGridView1_show.Name = "dataGridView1_show";
            this.dataGridView1_show.RowHeadersWidth = 51;
            this.dataGridView1_show.RowTemplate.Height = 27;
            this.dataGridView1_show.Size = new System.Drawing.Size(472, 329);
            this.dataGridView1_show.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "书号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "书名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
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
            // Column5
            // 
            this.Column5.DataPropertyName = "number";
            this.Column5.HeaderText = "数量";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // button_borrow
            // 
            this.button_borrow.BackColor = System.Drawing.Color.LightGray;
            this.button_borrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_borrow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_borrow.Location = new System.Drawing.Point(516, 354);
            this.button_borrow.Name = "button_borrow";
            this.button_borrow.Size = new System.Drawing.Size(166, 44);
            this.button_borrow.TabIndex = 22;
            this.button_borrow.Text = "借阅书籍";
            this.button_borrow.UseVisualStyleBackColor = false;
            this.button_borrow.UseWaitCursor = true;
            this.button_borrow.Click += new System.EventHandler(this.button_borrow_Click);
            // 
            // button_select
            // 
            this.button_select.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_select.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_select.Location = new System.Drawing.Point(55, 302);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(163, 33);
            this.button_select.TabIndex = 20;
            this.button_select.Text = "查询";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.UseWaitCursor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(13, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "书名";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "书号";
            this.label2.UseWaitCursor = true;
            // 
            // textBox书名
            // 
            this.textBox书名.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox书名.Location = new System.Drawing.Point(141, 209);
            this.textBox书名.Name = "textBox书名";
            this.textBox书名.Size = new System.Drawing.Size(164, 34);
            this.textBox书名.TabIndex = 17;
            this.textBox书名.UseWaitCursor = true;
            // 
            // zs3
            // 
            this.zs3.BackColor = System.Drawing.Color.LightGray;
            this.zs3.Location = new System.Drawing.Point(334, -1);
            this.zs3.Name = "zs3";
            this.zs3.Size = new System.Drawing.Size(10, 424);
            this.zs3.TabIndex = 15;
            this.zs3.Text = "button1";
            this.zs3.UseVisualStyleBackColor = false;
            this.zs3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "查询条件";
            this.label1.UseWaitCursor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.textBox1书号);
            this.tabPage3.Controls.Add(this.label书号);
            this.tabPage3.Controls.Add(this.label用户名);
            this.tabPage3.Controls.Add(this.label2_user);
            this.tabPage3.Controls.Add(this.button还书按钮);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(836, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "还书";
            // 
            // textBox1书号
            // 
            this.textBox1书号.Location = new System.Drawing.Point(370, 147);
            this.textBox1书号.Name = "textBox1书号";
            this.textBox1书号.Size = new System.Drawing.Size(165, 25);
            this.textBox1书号.TabIndex = 11;
            this.textBox1书号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1书号.UseWaitCursor = true;
            // 
            // label书号
            // 
            this.label书号.AutoSize = true;
            this.label书号.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label书号.Location = new System.Drawing.Point(249, 157);
            this.label书号.Name = "label书号";
            this.label书号.Size = new System.Drawing.Size(68, 15);
            this.label书号.TabIndex = 10;
            this.label书号.Text = "书  号：";
            this.label书号.UseWaitCursor = true;
            // 
            // label用户名
            // 
            this.label用户名.AutoSize = true;
            this.label用户名.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label用户名.Location = new System.Drawing.Point(249, 77);
            this.label用户名.Name = "label用户名";
            this.label用户名.Size = new System.Drawing.Size(67, 15);
            this.label用户名.TabIndex = 9;
            this.label用户名.Text = "用户名：";
            this.label用户名.UseWaitCursor = true;
            // 
            // label2_user
            // 
            this.label2_user.AutoSize = true;
            this.label2_user.BackColor = System.Drawing.Color.Snow;
            this.label2_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2_user.Location = new System.Drawing.Point(367, 77);
            this.label2_user.Name = "label2_user";
            this.label2_user.Size = new System.Drawing.Size(55, 15);
            this.label2_user.TabIndex = 8;
            this.label2_user.Text = "label2";
            this.label2_user.UseWaitCursor = true;
            // 
            // button还书按钮
            // 
            this.button还书按钮.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button还书按钮.Location = new System.Drawing.Point(282, 251);
            this.button还书按钮.Name = "button还书按钮";
            this.button还书按钮.Size = new System.Drawing.Size(172, 50);
            this.button还书按钮.TabIndex = 7;
            this.button还书按钮.Text = "还书";
            this.button还书按钮.UseVisualStyleBackColor = true;
            this.button还书按钮.UseWaitCursor = true;
            this.button还书按钮.Click += new System.EventHandler(this.button还书按钮_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView_showborrow);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(836, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "借阅信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView_showborrow
            // 
            this.dataGridView_showborrow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_showborrow.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView_showborrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showborrow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView_showborrow.Location = new System.Drawing.Point(-4, -3);
            this.dataGridView_showborrow.Name = "dataGridView_showborrow";
            this.dataGridView_showborrow.RowHeadersWidth = 51;
            this.dataGridView_showborrow.RowTemplate.Height = 27;
            this.dataGridView_showborrow.Size = new System.Drawing.Size(837, 424);
            this.dataGridView_showborrow.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "username";
            this.Column7.HeaderText = "用户名";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "id";
            this.Column8.HeaderText = "书号";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "time";
            this.Column9.HeaderText = "时间";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView_showreturn);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(836, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "还书信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView_showreturn
            // 
            this.dataGridView_showreturn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_showreturn.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView_showreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_showreturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView_showreturn.Location = new System.Drawing.Point(-4, -3);
            this.dataGridView_showreturn.Name = "dataGridView_showreturn";
            this.dataGridView_showreturn.RowHeadersWidth = 51;
            this.dataGridView_showreturn.RowTemplate.Height = 27;
            this.dataGridView_showreturn.Size = new System.Drawing.Size(844, 427);
            this.dataGridView_showreturn.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn1.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "书号";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn3.HeaderText = "时间";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "书号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // bname
            // 
            this.bname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bname.DataPropertyName = "name";
            this.bname.HeaderText = "书名";
            this.bname.MinimumWidth = 6;
            this.bname.Name = "bname";
            // 
            // bnum
            // 
            this.bnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bnum.DataPropertyName = "number";
            this.bnum.HeaderText = "数量";
            this.bnum.MinimumWidth = 6;
            this.bnum.Name = "bnum";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "author";
            this.Column6.HeaderText = "作者";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "press";
            this.Column10.HeaderText = "出版社";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 452);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "user";
            this.Text = "图书管理系统-学生界面";
            this.Load += new System.EventHandler(this.user_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showbook)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_show)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showborrow)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_showreturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_borrow;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox书名;
        private System.Windows.Forms.Button zs3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBox_书号;
        private System.Windows.Forms.TextBox textBox1书号;
        private System.Windows.Forms.Label label书号;
        private System.Windows.Forms.Label label用户名;
        private System.Windows.Forms.Label label2_user;
        private System.Windows.Forms.Button button还书按钮;
        private System.Windows.Forms.TextBox textBox3辅助;
        private System.Windows.Forms.TextBox textBox2辅助1;
        private System.Windows.Forms.Label label1user;
        private System.Windows.Forms.DataGridView dataGridView_showreturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView_showborrow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dataGridView_showbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

