using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManage
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void admin_Load(object sender, EventArgs e)
        {
            string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn1 = new SqlConnection(str1);
            conn1.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn1);
            DataSet dds1 = new DataSet();
            sqlDap.Fill(dds1);
            DataTable _table1 = dds1.Tables[0];
            int count1 = _table1.Rows.Count;
            dataGridView_showbook.DataSource = _table1;
            conn1.Close();

            tushuyilan.Visible = true;
            tushuguanli.Visible = false;
            jieyueguanli.Visible = false;
            duzheguanli.Visible = false;
        }
        /*——————————————图书管理：添加、修改、删除—————————————————*/
        //添加图书
        private void button_addbook_Click(object sender, EventArgs e)
        {
            string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn1 = new SqlConnection(str1);
            conn1.Open();
            string selectsql1 = "Select * from book where id = '" + textBox1_id.Text + "'";
            SqlCommand cmd1 = new SqlCommand(selectsql1, conn1);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd1.CommandType = CommandType.Text;
            SqlDataReader sdr1;//声明对象 
            sdr1 = cmd1.ExecuteReader();  //读cmd取到的text文本
            if (sdr1.Read()) //读到相同的书号
            {
                MessageBox.Show("书号已存在！请重新填写");
            }
            else
            {
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string selectsql = "insert into book (id,name,number,author,press) values('" + textBox1_id.Text + "','" + textBox2_Bname.Text + "','" + textBox3_Bnu.Text + "','" + textBox2_Bauthor.Text + "','" + textBox1_Bpress.Text + "')";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("添加成功！", "添加图书", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                //刷新
                string str12 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn12 = new SqlConnection(str12);
                conn12.Open();
                SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn12);
                DataSet dds1 = new DataSet();
                sqlDap.Fill(dds1);
                DataTable _table1 = dds1.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView1_deleteBook.DataSource = _table1;
                conn12.Close();
            }
            conn1.Close();
        }

        //修改书名
        private void button2_alterbook_Click(object sender, EventArgs e)
        {
            if (textBox5_id.Text != "" && textBox6_Bname.Text != "")
            {
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string selectsql = "update book set name = '" + textBox6_Bname.Text + "' where id = '" + textBox5_id.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();
                //显示修改成功窗体
                MessageBox.Show("修改书名成功", "修改书名", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                //刷新数据库中的图书信息
                string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn1 = new SqlConnection(str1);
                conn1.Open();
                SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn1);
                DataSet dds1 = new DataSet();
                sqlDap.Fill(dds1);
                DataTable _table1 = dds1.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView1_deleteBook.DataSource = _table1;
                conn.Close();
            }
            else MessageBox.Show("图书id或者书名为空！");
        }


        //修改数量
        private void button3_alternum_Click(object sender, EventArgs e)
        {
            if(textBox5_id.Text !="" && textBox4_Bnum.Text != "")
            {
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string selectsql = "update book set number = " + textBox4_Bnum.Text + " where id = '" + textBox5_id.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("修改数量成功", "修改数量", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                //刷新数据库中的图书信息
                string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn1 = new SqlConnection(str1);
                conn1.Open();
                SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn1);
                DataSet dds1 = new DataSet();
                sqlDap.Fill(dds1);
                DataTable _table1 = dds1.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView1_deleteBook.DataSource = _table1;
                conn.Close();
            }
            else MessageBox.Show("图书id或者数量为空！");

        }
        //修改作者
        private void button_alterauthor_Click(object sender, EventArgs e)
        {
            if (textBox5_id.Text != "" && textBox_Bauthor.Text != "")
            {
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string selectsql = "update book set author = '" + textBox_Bauthor.Text + "' where id = '" + textBox5_id.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();
                //显示修改成功窗体
                MessageBox.Show("修改作者成功", "修改作者", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //刷新数据库中的图书信息
                string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn1 = new SqlConnection(str1);
                conn1.Open();
                SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn1);
                DataSet dds1 = new DataSet();
                sqlDap.Fill(dds1);
                DataTable _table1 = dds1.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView1_deleteBook.DataSource = _table1;
                conn.Close();
            }
            else MessageBox.Show("图书id或者作者为空！");
        }
        //修改出版社
        private void button_alterpress_Click(object sender, EventArgs e)
        {
            if (textBox5_id.Text != "" && textBox_Bpress.Text != "")
            {
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string selectsql = "update book set press = '" + textBox_Bpress.Text + "' where id = '" + textBox5_id.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();
                //显示修改成功窗体
                MessageBox.Show("修改出版社成功", "修改出版社", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //刷新数据库中的图书信息
                string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn1 = new SqlConnection(str1);
                conn1.Open();
                SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn1);
                DataSet dds1 = new DataSet();
                sqlDap.Fill(dds1);
                DataTable _table1 = dds1.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView1_deleteBook.DataSource = _table1;
                conn.Close();
            }
            else MessageBox.Show("图书id或者出版社为空！");
        }
        //删除图书
        private void button4_deletebook_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            if (dataGridView1_deleteBook.SelectedRows.Count != 1) return;
            if (dataGridView1_deleteBook.CurrentRow == null) return;
 
            DataRowView row = dataGridView1_deleteBook.CurrentRow.DataBoundItem as DataRowView;
            if (row["id"] == null) return;//可以进行快速监视
            string bd = Convert.ToString(row["id"]);
            string selectsql = "delete from book where id = " + bd + "";
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            cmd.CommandType = CommandType.Text;

            int ret = cmd.ExecuteNonQuery();//受影响的行数（总数）
            if (ret == -1)
            {
                MessageBox.Show("删除失败！");
                return;
            }
            else
            {
                MessageBox.Show("删除成功！");
            }
            conn.Close();
            //重新加载图书信息
            string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn1 = new SqlConnection(str1);
            conn1.Open();

            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn1);
            DataSet dds1 = new DataSet();
            sqlDap.Fill(dds1);
            DataTable _table1 = dds1.Tables[0];
            int count1 = _table1.Rows.Count;
            dataGridView1_deleteBook.DataSource = _table1;
            conn1.Close();
        }
  
        //图书管理界面按钮
        private void button_BookManage_Click(object sender, EventArgs e)
        {
            //只显示图书管理界面
            tushuyilan.Visible = false;
            tushuguanli.Visible = true;
            jieyueguanli.Visible = false;
            duzheguanli.Visible = false;

            //加载图书删除界面信息
            string str11 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn11 = new SqlConnection(str11);
            conn11.Open();
            SqlDataAdapter sqlDap11 = new SqlDataAdapter("Select * from book order by id", conn11);
            DataSet dds11 = new DataSet();
            sqlDap11.Fill(dds11);
            DataTable _table11 = dds11.Tables[0];
            int count11 = _table11.Rows.Count;
            dataGridView1_deleteBook.DataSource = _table11;
            conn11.Close();
        }

        /*——————————————图书一览—————————————————*/
        //图书一览界面按钮
        private void button_Show_Click(object sender, EventArgs e)
        {
            tushuyilan.Visible = true;
            tushuguanli.Visible = false;
            jieyueguanli.Visible = false;
            duzheguanli.Visible = false;

            //加载图书信息
            string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn1 = new SqlConnection(str1);
            conn1.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book order by id", conn1);
            DataSet dds1 = new DataSet();
            sqlDap.Fill(dds1);
            DataTable _table1 = dds1.Tables[0];
            int count1 = _table1.Rows.Count;
            dataGridView_showbook.DataSource = _table1;
            conn1.Close();
        }

        /*——————————————借阅管理—————————————————*/
        //还书查询
        private void select_retern_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //模糊查询
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from return_book where id like'%" + textBox5.Text + "%' and username like '%" + textBox6.Text + "%' and time like '%" + textBox4.Text + "%' order by username", conn);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView3.DataSource = _table;
            conn.Close();
        }
        //借书查询
        private void select_borrow_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //模糊查询
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from borrow where id like'%" + textBox5.Text + "%' and username like '%" + textBox6.Text + "%' and time like '%" + textBox4.Text + "%' order by username", conn);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView3.DataSource = _table;
            conn.Close();
        }
        //借阅管理界面按钮
        private void button_LendManage(object sender, EventArgs e)
        {
            tushuyilan.Visible = false;
            tushuguanli.Visible = false;
            jieyueguanli.Visible = true;
            duzheguanli.Visible = false;
        }

        /*——————————————读者管理:用户查询、添加、修改—————————————————*/
        private void button_Add_Click(object sender, EventArgs e)
        {
            groupBox_Add.Visible = true;
        }
        //按用户名查询
        private void button5_select_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from login where username like '%" + textBox11_usename.Text + "%'order by username", conn);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            conn.Close();
        }
        //返回按钮
        private void button_back_Click(object sender, EventArgs e)
        {
            groupBox_Add.Visible = false;
        }
        //添加用户
        private void Add_Click(object sender, EventArgs e)
        {
            string str454 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn454 = new SqlConnection(str454);//实例化cnn对象
            conn454.Open();//打开
            string selectsql454 = "Select * from login where username = '" + textBox11.Text + "'";
            SqlCommand cmd454 = new SqlCommand(selectsql454, conn454);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd454.CommandType = CommandType.Text;
            SqlDataReader sdr454;
            sdr454 = cmd454.ExecuteReader();
            if (sdr454.Read())
            {
                MessageBox.Show("用户已存在！");
            }
            else
            {//开始修改                      
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string selectsql = "insert into login values('" + textBox11.Text + "','" + textBox22.Text + "',0,'null',0)";
                SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                MessageBox.Show("添加用户成功!");
                conn.Close();

                string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn1 = new SqlConnection(str1);
                conn1.Open();
                SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from login order by username", conn1);
                DataSet dds1 = new DataSet();
                sqlDap.Fill(dds1);
                DataTable _table1 = dds1.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView1.DataSource = _table1;
                groupBox_Add.Visible = false;
                conn1.Close();
            }
            conn454.Close();
        }
        //读者信息修改
        //修改用户密码
        private void alter_pssword_Click(object sender, EventArgs e)
        {
            string str454 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn454 = new SqlConnection(str454);
            conn454.Open();
            string selectsql454 = "Select * from login where username = '" + textBox1_username.Text + "'";
            SqlCommand cmd454 = new SqlCommand(selectsql454, conn454);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd454.CommandType = CommandType.Text;
            SqlDataReader sdr454;
            sdr454 = cmd454.ExecuteReader();
            if (sdr454.Read())
            {
                if (textBox1_username.Text != "")
                {
                    //如果用户名存在且不为空，开始修改
                    string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    string selectsql = "update login set password = '" + textBox2_password.Text + "'  where username = '" + textBox1_username.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectsql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    conn.Close();
                    MessageBox.Show("修改密码成功", "修改密码", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //刷新读者信息
                    string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(str1);
                    conn1.Open();
                    SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from login order by username", conn1);
                    DataSet dds1 = new DataSet();
                    sqlDap.Fill(dds1);
                    DataTable _table1 = dds1.Tables[0];
                    int count1 = _table1.Rows.Count;
                    dataGridView1.DataSource = _table1;
                    conn1.Close();
                }
                else MessageBox.Show("请输入用户名！");
            }
            else MessageBox.Show("用户名不存在！");
            conn454.Close();
        
        }
        //修改性别
        private void alter_sex_Click(object sender, EventArgs e)
        {
            string str454 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn454 = new SqlConnection(str454);
            conn454.Open();
            string selectsql454 = "Select * from login where username = '" + textBox1_username.Text + "'";
            SqlCommand cmd454 = new SqlCommand(selectsql454, conn454);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd454.CommandType = CommandType.Text;
            SqlDataReader sdr454;
            sdr454 = cmd454.ExecuteReader();
            if (sdr454.Read())
            {   //如果用户名存在且不为空，开始修改
                if (textBox1_username.Text != "")
                {
                    string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    string selectsql = "update login set sex = '" + textBox3_sex.Text + "'  where username = '" + textBox1_username.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectsql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    conn.Close();
                    MessageBox.Show("修改性别成功", "修改性别", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //刷新读者信息
                    string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(str1);
                    conn1.Open();
                    SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from login order by username", conn1);
                    DataSet dds1 = new DataSet();
                    sqlDap.Fill(dds1);
                    DataTable _table1 = dds1.Tables[0];
                    int count1 = _table1.Rows.Count;
                    dataGridView1.DataSource = _table1;
                    conn1.Close();
                }
                else MessageBox.Show("请输入用户名！");
            }
            else MessageBox.Show("用户不存在！");
            conn454.Close();
        }
        //修改年龄
        private void alter_age_Click(object sender, EventArgs e)
        {
            //查找读者
            string str454 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn454 = new SqlConnection(str454);
            conn454.Open();
            string selectsql454 = "Select * from login where username = '" + textBox1_username.Text + "'";
            SqlCommand cmd454 = new SqlCommand(selectsql454, conn454);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd454.CommandType = CommandType.Text;

            SqlDataReader sdr454;
            sdr454 = cmd454.ExecuteReader();
            if (sdr454.Read())
            {    //如果用户名存在且不为空，开始修改
                if (textBox1_username.Text != "")
                {
                    string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    string selectsql = "update login set age = '" + textBox4_age.Text + "'  where username = '" + textBox1_username.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectsql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                    conn.Close();
                    MessageBox.Show("修改年龄成功", "修改年龄", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //刷新读者信息
                    string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(str1);
                    conn1.Open();
                    SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from login order by username", conn1);
                    DataSet dds1 = new DataSet();
                    sqlDap.Fill(dds1);
                    DataTable _table1 = dds1.Tables[0];
                    int count1 = _table1.Rows.Count;
                    dataGridView1.DataSource = _table1;
                    conn1.Close();
                }
                else MessageBox.Show("请输入用户名！");
            }
            else MessageBox.Show("用户不存在！");
            conn454.Close();
        }
        //修改Email
        private void alter_email_Click(object sender, EventArgs e)
        {
            //查找读者
            string str454 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn454 = new SqlConnection(str454);
            conn454.Open();
            string selectsql454 = "Select * from login where username = '" + textBox1_username.Text + "'";
            SqlCommand cmd454 = new SqlCommand(selectsql454, conn454);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd454.CommandType = CommandType.Text;
            SqlDataReader sdr454;
            sdr454 = cmd454.ExecuteReader();
            if (sdr454.Read())
            {   //如果用户名存在且不为空，开始修改
                if (textBox1_username.Text != "")
                {
                    string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    string selectsql = "update login set Email = '" + textBox5_Email.Text + "'  where username = '" + textBox1_username.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectsql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("修改Email成功", "修改Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //刷新读者信息
                    string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(str1);
                    conn1.Open();
                    SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from login order by username", conn1);
                    DataSet dds1 = new DataSet();
                    sqlDap.Fill(dds1);
                    DataTable _table1 = dds1.Tables[0];
                    int count1 = _table1.Rows.Count;
                    dataGridView1.DataSource = _table1;
                    conn1.Close();
                }
                else MessageBox.Show("请输入用户名！");
            }
            else MessageBox.Show("用户不存在！");
            conn454.Close();
        }

        private void button_UserManage_Click(object sender, EventArgs e)
        {
            tushuyilan.Visible = false;
            tushuguanli.Visible = false;
            jieyueguanli.Visible = false;
            duzheguanli.Visible = true;
            string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn1 = new SqlConnection(str1);
            conn1.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from login order by username", conn1);
            DataSet dds1 = new DataSet();
            sqlDap.Fill(dds1);
            DataTable _table1 = dds1.Tables[0];
            int count1 = _table1.Rows.Count;
            dataGridView1.DataSource = _table1;
            conn1.Close();
        }


    }
}
