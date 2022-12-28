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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"D:\86137\Library-System\LibraryManage_20221219\安徽财经大学图书馆背景照.jpg");//文件路径
            this.BackgroundImageLayout = ImageLayout.Stretch;//图片自动延展
        }

        private void login_Load(object sender, EventArgs e)
        {
            password_text.PasswordChar = '*'; //设置文本框的PasswordChar属性为字符@
            password_text.UseSystemPasswordChar = true;
            denglubutton.BackColor = Color.LightSkyBlue;
            zhucebutton.BackColor = Color.White;
                     
        }
        public static string msg = "";   //用户名msg
        public static int dlflag = 2;   //学生是2  管理员是1
        private void denglu_Click(object sender, EventArgs e)
        {
            //登录
            if (username_text.Text != "" && password_text.Text != "")  //只有用户名和密码都不为空才能登录
            {

                if (radioButton1.Checked) dlflag = 1;   //管理员
                if (radioButton2.Checked) dlflag = 2;   //学生

                if (dlflag == 2) //学生登录
                {
                    //数据库连接字符串
                    string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn = new SqlConnection(str);//实例化sql连接对象
                    conn.Open();//打开链接
                    //写sqlserver语句
                    string selectsql = "Select * from login where username = '" + username_text.Text + "' and password='" + password_text.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
                    cmd.CommandType = CommandType.Text;
                    //cmd执行的sql是赋给CommandText的值里写出的sql语句，
                    //CommandType是SqlCommand对象的一个属性，CommandType是一个枚举类型，用于指定执行动作的形式，它告诉接下来执行的是一个文本(text)。
                    //有三个值：text、StoredProcedure、TableDirect，用于表示SqlCommand对象CommandType的执行形式。

                    SqlDataReader sdr;//声明对象 
                    sdr = cmd.ExecuteReader();  //读cmd取到的text文本
                    if (sdr.Read())//读到存在账号密码
                    {
                        MessageBox.Show("登陆学生成功!");
                        msg = username_text.Text;  //跳转主界面
                        this.DialogResult = DialogResult.OK;//调用program中的函数方法 
                        this.Dispose(); //登陆成功显示主界面  
                        this.Close();   //关闭当前页面
                    }
                    else
                    {
                        label3.Text = "登陆学生失败!"; //label3在界面没有显示，因为设置了显示为一个空格，label控件用以显示提示登录信息
                        password_text.Text = "";

                    }
                    conn.Close();//关闭对象
                }
                if (dlflag == 1)
                {
                    string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn = new SqlConnection(str);
                    conn.Open();
                    string selectsql = "Select * from loginad where username = '" + username_text.Text + "' and password='" + password_text.Text + "'";
                    SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader sdr;
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("登陆管理员成功!");
                        //label3.Text = "登陆管理员成功!";
                        msg = username_text.Text;
                        this.DialogResult = DialogResult.Yes;
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        label3.Text = "登陆管理员失败!";
                        password_text.Text = "";
                    }
                    conn.Close();
                }
            }
            else label3.Text = "用户名或密码为空!";
        }

        private void zhuce_Click(object sender, EventArgs e)
        {

            if (username_text.Text != "" && password_text.Text != "")
            {
                //注册
                if (radioButton1.Checked) dlflag = 1;
                if (radioButton2.Checked) dlflag = 2;
                if (dlflag == 2)
                {
                    //查找读者 判断是否注册过   与登录代码基本一致
                    string str2 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn2 = new SqlConnection(str2);//实例化cnn对象
                    conn2.Open();//打开
                    string selectsql2 = "Select * from login where username = '" + username_text.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(selectsql2, conn2);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
                    cmd2.CommandType = CommandType.Text;
                    SqlDataReader sdr2;//声明对象 
                    sdr2 = cmd2.ExecuteReader(); //读cmd2取到的text文本
                    if (sdr2.Read()) //读到存在账号密码
                    {
                        MessageBox.Show("用户已存在！请直接登录");
                    }
                    else
                    {//开始修改                      
                        string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                        SqlConnection conn = new SqlConnection(str);
                        conn.Open();
                        //插入操作
                        string selectsql = "insert into login values('" + username_text.Text + "','" + password_text.Text + "',0,'null',0)";
                        SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader sdr;
                        sdr = cmd.ExecuteReader();
                        MessageBox.Show("注册学生成功!");
                        conn.Close();
                    }
                    conn2.Close();
                }
                if (dlflag == 1)  //查找管理员
                {
                    string str3 = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                    SqlConnection conn3 = new SqlConnection(str3);
                    conn3.Open();
                    string selectsql3 = "Select * from loginad where username = '" + username_text.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(selectsql3, conn3);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
                    cmd3.CommandType = CommandType.Text;
                    SqlDataReader sdr3;
                    sdr3 = cmd3.ExecuteReader();
                    if (sdr3.Read())
                    {
                        MessageBox.Show("管理员已存在！请直接登录  ");
                    }
                    else
                    {
                        string str = @"Data Source=.;Initial catalog=BookDB;integrated Security=True";
                        SqlConnection conn = new SqlConnection(str);
                        conn.Open();
                        string selectsql = "insert into loginad values('" + username_text.Text + "','" + password_text.Text + "')";
                        SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader sdr;
                        sdr = cmd.ExecuteReader();
                        MessageBox.Show("注册管理员成功!");
                        conn.Close();
                    }
                    conn3.Close();
                }
            }
            else label3.Text = "用户名或密码为空！";
        }
        private void denglubutton_Click(object sender, EventArgs e)
        {
            //切换登录状态
            denglu.Visible = true;
            zhuce.Visible = false;
            zhuangtai.Text = "状态：登录";
            denglubutton.BackColor = Color.LightSkyBlue;
            zhucebutton.BackColor = Color.White;
        }
        private void zhucebutton_Click(object sender, EventArgs e)
        {
            //切换注册状态
            zhuce.Visible = true;
            denglu.Visible = false;
            zhuangtai.Text = "状态：注册";
            zhucebutton.BackColor = Color.LightSkyBlue;
            denglubutton.BackColor = Color.White;
        }

    }
}
