
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
            this.dataGridView查看图书 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3辅助 = new System.Windows.Forms.TextBox();
            this.textBox2辅助1 = new System.Windows.Forms.TextBox();
            this.label1用户 = new System.Windows.Forms.Label();
            this.textBox书号 = new System.Windows.Forms.TextBox();
            this.dataGridView1借书表 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button借书按钮 = new System.Windows.Forms.Button();
            this.button查询 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox书名 = new System.Windows.Forms.TextBox();
            this.zs3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox1书号 = new System.Windows.Forms.TextBox();
            this.label书号 = new System.Windows.Forms.Label();
            this.label用户名 = new System.Windows.Forms.Label();
            this.用户 = new System.Windows.Forms.Label();
            this.button还书按钮 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView借阅信息 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView还书信息 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView查看图书)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1借书表)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView借阅信息)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView还书信息)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView查看图书);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图书一览";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView查看图书
            // 
            this.dataGridView查看图书.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView查看图书.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView查看图书.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bname,
            this.bnum});
            this.dataGridView查看图书.Location = new System.Drawing.Point(0, 0);
            this.dataGridView查看图书.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView查看图书.Name = "dataGridView查看图书";
            this.dataGridView查看图书.RowHeadersWidth = 51;
            this.dataGridView查看图书.RowTemplate.Height = 23;
            this.dataGridView查看图书.Size = new System.Drawing.Size(836, 424);
            this.dataGridView查看图书.TabIndex = 6;
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
            this.bname.DataPropertyName = "bname";
            this.bname.HeaderText = "书名";
            this.bname.MinimumWidth = 6;
            this.bname.Name = "bname";
            // 
            // bnum
            // 
            this.bnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bnum.DataPropertyName = "bnum";
            this.bnum.HeaderText = "数量";
            this.bnum.MinimumWidth = 6;
            this.bnum.Name = "bnum";
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
            this.tabPage2.Controls.Add(this.label1用户);
            this.tabPage2.Controls.Add(this.textBox书号);
            this.tabPage2.Controls.Add(this.dataGridView1借书表);
            this.tabPage2.Controls.Add(this.button借书按钮);
            this.tabPage2.Controls.Add(this.button查询);
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
            // label1用户
            // 
            this.label1用户.AutoSize = true;
            this.label1用户.BackColor = System.Drawing.Color.Chartreuse;
            this.label1用户.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1用户.Location = new System.Drawing.Point(513, 192);
            this.label1用户.Name = "label1用户";
            this.label1用户.Size = new System.Drawing.Size(55, 15);
            this.label1用户.TabIndex = 25;
            this.label1用户.Text = "label1";
            this.label1用户.Visible = false;
            // 
            // textBox书号
            // 
            this.textBox书号.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBox书号.Location = new System.Drawing.Point(141, 121);
            this.textBox书号.Name = "textBox书号";
            this.textBox书号.Size = new System.Drawing.Size(164, 34);
            this.textBox书号.TabIndex = 24;
            // 
            // dataGridView1借书表
            // 
            this.dataGridView1借书表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1借书表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1借书表.Location = new System.Drawing.Point(350, 6);
            this.dataGridView1借书表.Name = "dataGridView1借书表";
            this.dataGridView1借书表.RowHeadersWidth = 51;
            this.dataGridView1借书表.RowTemplate.Height = 27;
            this.dataGridView1借书表.Size = new System.Drawing.Size(472, 329);
            this.dataGridView1借书表.TabIndex = 23;
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
            // button借书按钮
            // 
            this.button借书按钮.BackColor = System.Drawing.Color.LightGray;
            this.button借书按钮.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button借书按钮.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button借书按钮.Location = new System.Drawing.Point(516, 354);
            this.button借书按钮.Name = "button借书按钮";
            this.button借书按钮.Size = new System.Drawing.Size(166, 44);
            this.button借书按钮.TabIndex = 22;
            this.button借书按钮.Text = "借阅书籍";
            this.button借书按钮.UseVisualStyleBackColor = false;
            this.button借书按钮.UseWaitCursor = true;
            this.button借书按钮.Click += new System.EventHandler(this.button借书按钮_Click);
            // 
            // button查询
            // 
            this.button查询.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button查询.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button查询.Location = new System.Drawing.Point(55, 302);
            this.button查询.Name = "button查询";
            this.button查询.Size = new System.Drawing.Size(163, 33);
            this.button查询.TabIndex = 20;
            this.button查询.Text = "查询";
            this.button查询.UseVisualStyleBackColor = true;
            this.button查询.UseWaitCursor = true;
            this.button查询.Click += new System.EventHandler(this.button查询_Click);
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
            this.tabPage3.Controls.Add(this.用户);
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
            // 用户
            // 
            this.用户.AutoSize = true;
            this.用户.BackColor = System.Drawing.Color.Snow;
            this.用户.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.用户.Location = new System.Drawing.Point(367, 77);
            this.用户.Name = "用户";
            this.用户.Size = new System.Drawing.Size(55, 15);
            this.用户.TabIndex = 8;
            this.用户.Text = "label2";
            this.用户.UseWaitCursor = true;
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
            this.tabPage4.Controls.Add(this.dataGridView借阅信息);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(836, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "借阅信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView借阅信息
            // 
            this.dataGridView借阅信息.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView借阅信息.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView借阅信息.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView借阅信息.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView借阅信息.Location = new System.Drawing.Point(-4, -3);
            this.dataGridView借阅信息.Name = "dataGridView借阅信息";
            this.dataGridView借阅信息.RowHeadersWidth = 51;
            this.dataGridView借阅信息.RowTemplate.Height = 27;
            this.dataGridView借阅信息.Size = new System.Drawing.Size(837, 424);
            this.dataGridView借阅信息.TabIndex = 2;
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
            this.tabPage5.Controls.Add(this.dataGridView还书信息);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(836, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "还书信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView还书信息
            // 
            this.dataGridView还书信息.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView还书信息.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView还书信息.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView还书信息.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView还书信息.Location = new System.Drawing.Point(-4, -3);
            this.dataGridView还书信息.Name = "dataGridView还书信息";
            this.dataGridView还书信息.RowHeadersWidth = 51;
            this.dataGridView还书信息.RowTemplate.Height = 27;
            this.dataGridView还书信息.Size = new System.Drawing.Size(844, 427);
            this.dataGridView还书信息.TabIndex = 23;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView查看图书)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1借书表)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView借阅信息)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView还书信息)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button借书按钮;
        private System.Windows.Forms.Button button查询;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox书名;
        private System.Windows.Forms.Button zs3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView1借书表;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox textBox书号;
        private System.Windows.Forms.TextBox textBox1书号;
        private System.Windows.Forms.Label label书号;
        private System.Windows.Forms.Label label用户名;
        private System.Windows.Forms.Label 用户;
        private System.Windows.Forms.Button button还书按钮;
        private System.Windows.Forms.TextBox textBox3辅助;
        private System.Windows.Forms.TextBox textBox2辅助1;
        private System.Windows.Forms.Label label1用户;
        private System.Windows.Forms.DataGridView dataGridView还书信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView借阅信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridView dataGridView查看图书;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bnum;
    }
}

