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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
        int num1 = 0;
        private void user_Load(object sender, EventArgs e)
        {
            
            label1用户.Text = LibraryManage.login.msg;
            用户.Text = LibraryManage.login.msg;
            //图书目录展示
            string str1515 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn1515 = new SqlConnection(str1515);
            conn1515.Open();
            SqlDataAdapter sqlDap1515 = new SqlDataAdapter("Select * from book order by id", conn1515);
            DataSet dds1515 = new DataSet();
            sqlDap1515.Fill(dds1515);
            DataTable _table1515 = dds1515.Tables[0];
            int count1515 = _table1515.Rows.Count;
            dataGridView查看图书.DataSource = _table1515;
            conn1515.Close();
            //借书记录展示
            string str152 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn152 = new SqlConnection(str152);
            conn152.Open();
            SqlDataAdapter sqlDap31 = new SqlDataAdapter("Select * from borrow where username = '" + label1用户.Text + "' order by username", conn152);
            DataSet dds152 = new DataSet();
            sqlDap31.Fill(dds152);
            DataTable _table11 = dds152.Tables[0];
            int count11 = _table11.Rows.Count;
            dataGridView借阅信息.DataSource = _table11;
            conn152.Close();
            //还书记录展示
            string str = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from return_book where username = '" + label1用户.Text + "' order by username", conn);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView还书信息.DataSource = _table;
            conn.Close();
        }
        //借书
        private void button查询_Click(object sender, EventArgs e)
        {
            //连接数据库
            string str = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book where id like '%" + textBox书号.Text + "%' and name like '%" + textBox书名.Text + "%'order by id", conn);
            DataSet ds = new DataSet();//创建一个临时数据库
            sqlDap.Fill(ds);
            DataTable _table = ds.Tables[0]; //将DataSet的第一张表赋值给DataTable。
            int count = _table.Rows.Count;  //Rows.Count属性获取总行数
            dataGridView1借书表.DataSource = _table;  
            conn.Close();
        }
        private void button借书按钮_Click(object sender, EventArgs e)
        {
            //连接数据库 取得数据
            string str4 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn2 = new SqlConnection(str4);
            conn2.Open();
            if (dataGridView1借书表.SelectedRows.Count != 1) return;
            if (dataGridView1借书表.CurrentRow == null) return;

            DataRowView row1 = dataGridView1借书表.CurrentRow.DataBoundItem as DataRowView;  //获取用于填充行的数据绑定对象
            if (row1["id"] == null) return;//可以进行快速监视

            string bd1 = Convert.ToString(row1["id"]);  //Convert.ToString(null)不会抛出异常而是返回空字符串
            //查询借书表
            string selectsql4 = "Select * from borrow where username = '" + 用户.Text + "' and id='" + bd1 + "'"; 
            SqlCommand cmd4 = new SqlCommand(selectsql4, conn2);  //SqlCommand对象允许在指定数据库上执行的操作的类型。
            cmd4.CommandType = CommandType.Text;
            SqlDataReader sdr4;
            sdr4 = cmd4.ExecuteReader();
            if (sdr4.Read()) //查询该用户已经借了这本书
            {
                MessageBox.Show("你已经借阅了本书！");
            }
            else//如果当前没有借过这本书，则执行下面操作
            {
                num1 = 0;
                //取得数据
                string str = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                if (dataGridView1借书表.SelectedRows.Count != 1) return;   //查看是否选中至少1行
                if (dataGridView1借书表.CurrentRow == null) return;    //获取包含当前单元格的行  如果没有当前单元格，则为 null
                //首先判断当前数量是否可借出
                DataRowView row = dataGridView1借书表.CurrentRow.DataBoundItem as DataRowView;
                if (row["id"] == null) return;//可以进行快速监视
                string bd = Convert.ToString(row["id"]);  //bd作为图书id
                string selectsql = "select number from book where id= " + bd + "";  //查看图书数量
                SqlCommand cmd = new SqlCommand(selectsql, conn); 
                object i = cmd.ExecuteScalar();    //返回结果的第一行第一列的值
                textBox2辅助1.Text = i.ToString();    
                num1 = int.Parse(textBox2辅助1.Text);  //num1为原始数量
                int num2 = 0;
                num1 = num1 - 1;  //借书后 数量减1
                num2 = num1 + 1;   //原始数量
                textBox3辅助.Text = Convert.ToString(num1);  //借出后数量

                if (num2 > 0)  //原始数量大于0
                {
                    conn.Close();
                    //查询数量完成 开始借书
                    string str21 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn21 = new SqlConnection(str21);
                    conn21.Open();
                    if (dataGridView1借书表.SelectedRows.Count != 1) return;
                    if (dataGridView1借书表.CurrentRow == null) return;
                   
                    DataRowView row21 = dataGridView1借书表.CurrentRow.DataBoundItem as DataRowView;
                    if (row21["id"] == null) return;//可以进行快速监视
                    string bd21 = Convert.ToString(row21["id"]);
                    //更新图书表
                    string selectsql21 = "update book set number = " + textBox3辅助.Text + " where id = '" + bd21 + "'";
                    SqlCommand cmd21 = new SqlCommand(selectsql21, conn21);
                    cmd21.CommandType = CommandType.Text;
                    SqlDataReader sdr21;
                    sdr21 = cmd21.ExecuteReader();           
                    conn.Close();//完成book更新

                    //写借书信息表
                    string str12 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn12 = new SqlConnection(str12);
                    conn12.Open();
                    if (dataGridView1借书表.SelectedRows.Count != 1) return;
                    if (dataGridView1借书表.CurrentRow == null) return;      
                    DataRowView row12 = dataGridView1借书表.CurrentRow.DataBoundItem as DataRowView;
                    if (row12["id"] == null) return;//可以进行快速监视
                    string bd12 = Convert.ToString(row12["id"]);
                    label1用户.Text = LibraryManage.login.msg;  //label1用户是当前登录用户
                    string usetime = DateTime.Now.ToString(); //借书时间
                    //更新借书表
                    string selectsql12 = "insert into borrow values('" + label1用户.Text + "','" + bd + "','" + usetime + "')";
                    SqlCommand cmd12 = new SqlCommand(selectsql12, conn12);
                    cmd12.CommandType = CommandType.Text;
                    SqlDataReader sdr12;
                    sdr12 = cmd12.ExecuteReader();
                    conn12.Close();
                    //更新完成显示
                    MessageBox.Show("用户 " + label1用户.Text + " 借阅成功,书号：" + bd + " 剩余数量：" + textBox3辅助.Text);

                    //刷新图书目录
                    string str1 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(str1);
                    conn1.Open();
                    SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book where id like '%" + textBox书号.Text + "%' and number like '%" + textBox书名.Text + "%'order by id", conn1);
                    DataSet dds1 = new DataSet();
                    sqlDap.Fill(dds1);
                    DataTable _table1 = dds1.Tables[0];
                    int count1 = _table1.Rows.Count;
                    dataGridView1借书表.DataSource = _table1;
                    dataGridView查看图书.DataSource = _table1;
                    conn1.Close();

                    //刷新借书信息目录
                    string str151 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn151 = new SqlConnection(str151);
                    conn151.Open();
                    SqlDataAdapter sqlDap31 = new SqlDataAdapter("Select * from borrow where username = '" + label1用户.Text + "' order by username", conn151);
                    DataSet dds151 = new DataSet();
                    sqlDap31.Fill(dds151);  
                    DataTable _table11 = dds151.Tables[0];
                    int count11 = _table11.Rows.Count;
                    dataGridView借阅信息.DataSource = _table11;
                    conn151.Close();

                }
                else MessageBox.Show("查询完成，图书 " + bd + " 剩余数量：0 。请选择其他书籍借阅。");
            }
        }

        //还书
        private void button还书按钮_Click(object sender, EventArgs e)
        {
            //查询借书信息
            string str4 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn4 = new SqlConnection(str4);
            conn4.Open();
            string selectsql4 = "Select * from borrow where username = '" + 用户.Text + "' and id='" + textBox1书号.Text + "'";
            SqlCommand cmd4 = new SqlCommand(selectsql4, conn4);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd4.CommandType = CommandType.Text;
            SqlDataReader sdr4;
            sdr4 = cmd4.ExecuteReader();

            if (sdr4.Read())  //查询到借书信息
            {
                string str = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                //还书数量加1
                string selectsql = "update book set number = number+1 where id = '" + textBox1书号.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();

                //删除借阅信息
                string str9 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn9 = new SqlConnection(str9);
                conn9.Open();
                string selectsql9 = "delete from borrow where id='" + textBox1书号.Text + "' and username='" + 用户.Text + "'";
                SqlCommand cmd9 = new SqlCommand(selectsql9, conn9);
                cmd9.CommandType = CommandType.Text;
                SqlDataReader sdr9;
                sdr9 = cmd9.ExecuteReader();
                conn9.Close();

                //写还书记录
                string str7 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn7 = new SqlConnection(str7);
                conn7.Open();
                string usetime1 = DateTime.Now.ToString();
                string selectsql7 = "insert into return_book values('" + 用户.Text + "','" + textBox1书号.Text + "','" + usetime1 + "')";
                SqlCommand cmd7 = new SqlCommand(selectsql7, conn7);
                cmd7.CommandType = CommandType.Text;
                SqlDataReader sdr7;
                sdr7 = cmd7.ExecuteReader();
                conn7.Close();
                //还书信息展示
                MessageBox.Show("用户：" + 用户.Text + " 还书成功!书号：" + textBox1书号.Text, "还书信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //刷新图书表
                string str6 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn6 = new SqlConnection(str6);
                conn6.Open();
                SqlDataAdapter sqlDap6 = new SqlDataAdapter("Select * from book order by id", conn6);
                DataSet dds6 = new DataSet();
                sqlDap6.Fill(dds6);
                DataTable _table6 = dds6.Tables[0];
                int count6 = _table6.Rows.Count;
                dataGridView1借书表.DataSource = _table6;
                dataGridView查看图书.DataSource = _table6;
                conn6.Close();

                //更新借阅表展示界面
                string str15 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn15 = new SqlConnection(str15);
                conn15.Open();
                SqlDataAdapter sqlDap3 = new SqlDataAdapter("Select * from borrow where username = '" + label1用户.Text + "' order by username", conn15);
                DataSet dds15 = new DataSet();
                sqlDap3.Fill(dds15);
                DataTable _table1 = dds15.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView借阅信息.DataSource = _table1;
                conn15.Close();

                //更新还书表展示界面
                string str1523 = @"Data Source=DESKTOP-QMBQVMT;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn1523 = new SqlConnection(str1523);
                conn1523.Open();
                SqlDataAdapter sqlDap323 = new SqlDataAdapter("Select * from return_book where username = '" + label1用户.Text + "' order by username", conn1523);
                DataSet dds1523 = new DataSet();
                sqlDap323.Fill(dds1523);
                DataTable _table123 = dds1523.Tables[0];
                int count123 = _table123.Rows.Count;
                dataGridView还书信息.DataSource = _table123;
                conn1523.Close();
               
            }
            else
            {
                MessageBox.Show("还书失败，用户: " + 用户.Text + " 无此项借书记录!", "还书信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn4.Close();
        }


    }
}
