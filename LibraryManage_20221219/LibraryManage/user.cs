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
        /*---------该模块功能：当用户登录时，可以实现自动显示所有图书信息以及该用户所有的借书记录和还书记录，方便用户查看---------*/
        private void user_Load(object sender, EventArgs e)
        {
            label1user.Text = LibraryManage.login.msg;
            label2_user.Text = LibraryManage.login.msg;
            //图书一览
            string str1515 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn1515 = new SqlConnection(str1515);
            conn1515.Open();
            SqlDataAdapter sqlDap1515 = new SqlDataAdapter("Select * from book order by id", conn1515);
            DataSet dds1515 = new DataSet();
            sqlDap1515.Fill(dds1515);
            DataTable _table1515 = dds1515.Tables[0];
            int count1515 = _table1515.Rows.Count;//信息全部显示
            dataGridView_showbook.DataSource = _table1515;
            conn1515.Close();

            //借书记录展示
            string str152 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn152 = new SqlConnection(str152);
            conn152.Open();
            SqlDataAdapter sqlDap31 = new SqlDataAdapter("Select * from borrow where username = '" + label1user.Text + "' order by username", conn152);
            DataSet dds152 = new DataSet();
            sqlDap31.Fill(dds152);
            DataTable _table11 = dds152.Tables[0];
            int count11 = _table11.Rows.Count;
            dataGridView_showborrow.DataSource = _table11;
            conn152.Close();

            //还书记录展示
            string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from return_book where username = '" + label1user.Text + "' order by username", conn);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView_showreturn.DataSource = _table;
            conn.Close();
        }
        /*-----借书模块：可以实现借书功能，通过查询找到需要借阅的书籍，只有选中书籍后点击借阅书籍按钮才可开始借阅，若借阅成功则会显示当前借阅书籍号以及剩余数量，并且实时
        更新借书表和图书一览中的剩余数量；若剩余数量为0，则提示“剩余数量：0 。请选择其他书籍借阅！”；如果此前已经借过该书，则会提示"你已经借阅了本书！"。--------*/
        //查询书籍
        private void button_select_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book where id like '%" + textBox_shuhao.Text + "%' and name like '%" + textBox_shuming.Text + "%'order by id", conn);
            DataSet ds = new DataSet();//创建一个临时数据库
            sqlDap.Fill(ds);//将查询到的信息放进临时数据库中
            DataTable _table = ds.Tables[0]; //将DataSet的第一张表赋值给DataTable。
            int count = _table.Rows.Count;  //Rows.Count属性获取总行数
            dataGridView1_show.DataSource = _table;  
            conn.Close();
        }
        //借阅
        private void button_borrow_Click(object sender, EventArgs e)
        {   
            //连接数据库 取得数据
            string str4 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn2 = new SqlConnection(str4);
            conn2.Open();
            if (dataGridView1_show.SelectedRows.Count != 1) return;
            if (dataGridView1_show.CurrentRow == null) return;

            DataRowView row1 = dataGridView1_show.CurrentRow.DataBoundItem as DataRowView;  //获取用于填充行的数据绑定对象
            if (row1["id"] == null) return;//可以进行快速监视

            string bd1 = Convert.ToString(row1["id"]);  //Convert.ToString(null)不会抛出异常而是返回空字符串
            //查询借书表
            string selectsql4 = "Select * from borrow where username = '" + label2_user.Text + "' and id='" + bd1 + "'"; 
            SqlCommand cmd4 = new SqlCommand(selectsql4, conn2);  //SqlCommand对象允许在指定数据库上执行的操作的类型。
            cmd4.CommandType = CommandType.Text;
            SqlDataReader sdr4;
            sdr4 = cmd4.ExecuteReader();
            if (sdr4.Read()) //查询到该用户已经借了这本书，进行消息提示
            {
                MessageBox.Show("你已经借阅了本书！");
            }
            else//如果当前没有借过这本书，则执行下面操作
            {
                num1 = 0;
                //取得数据
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                if (dataGridView1_show.SelectedRows.Count != 1) return;   //查看是否选中至少1行
                if (dataGridView1_show.CurrentRow == null) return;    //获取包含当前单元格的行  如果没有当前单元格，则为 null
                //首先判断当前数量是否可借出
                DataRowView row = dataGridView1_show.CurrentRow.DataBoundItem as DataRowView;
                if (row["id"] == null) return;//可以进行快速监视
                string bd = Convert.ToString(row["id"]);  //bd作为图书id
                string selectsql = "select number from book where id= " + bd + "";  //查看图书数量
                SqlCommand cmd = new SqlCommand(selectsql, conn); 
                object i = cmd.ExecuteScalar();    //返回结果的第一行第一列的值
                textBox2_fuzhu1.Text = i.ToString();    

                num1 = int.Parse(textBox2_fuzhu1.Text);  //num1为原始数量
                int num2 = 0;
                num2 = num1;
                num1 = num1 - 1;  //借书后 数量减1
                //num2 = num1 + 1;   //原始数量
                textBox3_fuzhu.Text = Convert.ToString(num1);  //借出后数量

                if (num2 > 0)  //原始数量大于0
                {
                    conn.Close();
                    //查询数量完成 开始借书
                    string str21 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn21 = new SqlConnection(str21);
                    conn21.Open();
                    if (dataGridView1_show.SelectedRows.Count != 1) return;
                    if (dataGridView1_show.CurrentRow == null) return;
                   
                    DataRowView row21 = dataGridView1_show.CurrentRow.DataBoundItem as DataRowView;
                    if (row21["id"] == null) return;//可以进行快速监视
                    string bd21 = Convert.ToString(row21["id"]);
                    //更新图书表
                    string selectsql21 = "update book set number = " + textBox3_fuzhu.Text + " where id = '" + bd21 + "'";
                    SqlCommand cmd21 = new SqlCommand(selectsql21, conn21);
                    cmd21.CommandType = CommandType.Text;
                    SqlDataReader sdr21;
                    sdr21 = cmd21.ExecuteReader();           
                    conn.Close();//完成book更新

                    //写借书信息表
                    string str12 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn12 = new SqlConnection(str12);
                    conn12.Open();
                    if (dataGridView1_show.SelectedRows.Count != 1) return;
                    if (dataGridView1_show.CurrentRow == null) return;      
                    DataRowView row12 = dataGridView1_show.CurrentRow.DataBoundItem as DataRowView;
                    if (row12["id"] == null) return;//可以进行快速监视
                    string bd12 = Convert.ToString(row12["id"]);
                    label1user.Text = LibraryManage.login.msg;  //label1用户是当前登录用户
                    string usetime = DateTime.Now.ToString(); //借书时间

                    string selectsql12 = "insert into borrow values('" + label1user.Text + "','" + bd + "','" + usetime + "')";
                    SqlCommand cmd12 = new SqlCommand(selectsql12, conn12);
                    cmd12.CommandType = CommandType.Text;
                    SqlDataReader sdr12;
                    sdr12 = cmd12.ExecuteReader();
                    conn12.Close();
                    //更新完成显示
                    MessageBox.Show("用户 " + label1user.Text + " 借阅成功,书号：" + bd + " 剩余数量：" + textBox3_fuzhu.Text);

                    //借书后刷新图书目录
                    string str1 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(str1);
                    conn1.Open();
                    SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from book where id like '%" + textBox_shuhao.Text + "%' and number like '%" + textBox_shuming.Text + "%'order by id", conn1);
                    DataSet dds1 = new DataSet();
                    sqlDap.Fill(dds1);
                    DataTable _table1 = dds1.Tables[0];
                    int count1 = _table1.Rows.Count;
                    dataGridView1_show.DataSource = _table1;//查询图书表会自动更新
                    dataGridView_showbook.DataSource = _table1;//图书一览自动更新
                    conn1.Close();

                    //刷新借书信息目录
                    string str151 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn151 = new SqlConnection(str151);
                    conn151.Open();
                    SqlDataAdapter sqlDap31 = new SqlDataAdapter("Select * from borrow where username = '" + label1user.Text + "' order by username", conn151);
                    DataSet dds151 = new DataSet();
                    sqlDap31.Fill(dds151);  
                    DataTable _table11 = dds151.Tables[0];
                    int count11 = _table11.Rows.Count;
                    dataGridView_showborrow.DataSource = _table11;
                    conn151.Close();

                }
                else MessageBox.Show("查询完成，图书 " + bd + " 剩余数量：0 。请选择其他书籍借阅！");
            }
        }
        /*--------还书模块:可以实现还书功能，输入需要还书的书号，如果有该书的借书记录，点击还书即可还书成功，之后更新图书表中图书数量，删除借阅信息，写还书记录，并且刷新
         借阅信息以及还书信息；否则提示“还书失败，无此项借书记录!”---------*/
        //还书
        private void button还书按钮_Click(object sender, EventArgs e)
        {
            //查询借书信息
            string str4 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
            SqlConnection conn4 = new SqlConnection(str4);
            conn4.Open();
            string selectsql4 = "Select * from borrow where username = '" + label2_user.Text + "' and id='" + textBox1_shuhao.Text + "'";
            SqlCommand cmd4 = new SqlCommand(selectsql4, conn4);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
            cmd4.CommandType = CommandType.Text;
            SqlDataReader sdr4;
            sdr4 = cmd4.ExecuteReader();

            if (sdr4.Read())  //查询到借书信息
            {
                string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                //还书数量加1
                string selectsql = "update book set number = number+1 where id = '" + textBox1_shuhao.Text + "'";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();

                //删除借阅信息
                string str9 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn9 = new SqlConnection(str9);
                conn9.Open();
                string selectsql9 = "delete from borrow where id='" + textBox1_shuhao.Text + "' and username='" + label2_user.Text + "'";
                SqlCommand cmd9 = new SqlCommand(selectsql9, conn9);
                cmd9.CommandType = CommandType.Text;
                SqlDataReader sdr9;
                sdr9 = cmd9.ExecuteReader();
                conn9.Close();

                //写还书记录
                string str7 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn7 = new SqlConnection(str7);
                conn7.Open();
                string usetime1 = DateTime.Now.ToString();
                string selectsql7 = "insert into return_book values('" + label2_user.Text + "','" + textBox1_shuhao.Text + "','" + usetime1 + "')";
                SqlCommand cmd7 = new SqlCommand(selectsql7, conn7);
                cmd7.CommandType = CommandType.Text;
                SqlDataReader sdr7;
                sdr7 = cmd7.ExecuteReader();
                conn7.Close();
                //还书信息展示
                MessageBox.Show("用户：" + label2_user.Text + " 还书成功!书号：" + textBox1_shuhao.Text, "还书信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //刷新图书表
                string str6 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn6 = new SqlConnection(str6);
                conn6.Open();
                SqlDataAdapter sqlDap6 = new SqlDataAdapter("Select * from book order by id", conn6);
                DataSet dds6 = new DataSet();
                sqlDap6.Fill(dds6);
                DataTable _table6 = dds6.Tables[0];
                int count6 = _table6.Rows.Count;
                dataGridView1_show.DataSource = _table6;
                dataGridView_showbook.DataSource = _table6;
                conn6.Close();

                //更新借阅表展示界面
                string str15 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn15 = new SqlConnection(str15);
                conn15.Open();
                SqlDataAdapter sqlDap3 = new SqlDataAdapter("Select * from borrow where username = '" + label1user.Text + "' order by username", conn15);
                DataSet dds15 = new DataSet();
                sqlDap3.Fill(dds15);
                DataTable _table1 = dds15.Tables[0];
                int count1 = _table1.Rows.Count;
                dataGridView_showborrow.DataSource = _table1;
                conn15.Close();

                //更新还书表展示界面
                string str1523 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn1523 = new SqlConnection(str1523);
                conn1523.Open();
                SqlDataAdapter sqlDap323 = new SqlDataAdapter("Select * from return_book where username = '" + label1user.Text + "' order by username", conn1523);
                DataSet dds1523 = new DataSet();
                sqlDap323.Fill(dds1523);
                DataTable _table123 = dds1523.Tables[0];
                dataGridView_showreturn.DataSource = _table123;
                conn1523.Close();
               
            }
            else
            {
                MessageBox.Show("还书失败，用户: " + label2_user.Text + " 无此项借书记录!", "还书信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn4.Close();
        }


    }
}
