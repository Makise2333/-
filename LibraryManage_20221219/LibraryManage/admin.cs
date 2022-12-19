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
            string str1 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
        }

        //添加图书
        private void button_addbook_Click(object sender, EventArgs e)
        {
            string str1 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
                string str = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string selectsql = "insert into book (id,name,number) values('" + textBox1_id.Text + "','" + textBox2_Bname.Text + "','" + textBox3_Bnu.Text + "')";
                SqlCommand cmd = new SqlCommand(selectsql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader sdr;
                sdr = cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("添加成功！", "添加图书", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                //刷新
                string str12 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
        }//

        //修改书名
        private void button2_alterbook_Click(object sender, EventArgs e)
        {
            if (textBox5_id.Text != "" && textBox6_Bname.Text != "")
            {
                string str = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
                string str1 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
        }//修改书名


        //修改数量
        private void button3_alternum_Click(object sender, EventArgs e)
        {
            if(textBox5_id.Text !="" && textBox4_Bnum.Text != "")
            {
                string str = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
                string str1 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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

        //删除图书
        private void button4_deletebook_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
            string str1 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
        private void button6_bookmanage_Click(object sender, EventArgs e)
        {
            tushuyilan.Visible = false;
            tushuguanli.Visible = true;

            //加载图书删除界面信息
            string str11 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
        //图书一览界面按钮
        private void button_show_Click(object sender, EventArgs e)
        {
            tushuyilan.Visible = true;
            tushuguanli.Visible = false;

            //加载图书信息
            string str1 = @"Data Source=LAPTOP-VTH29KJQ;Initial catalog=BookDB;integrated Security=True";
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
    }
}
