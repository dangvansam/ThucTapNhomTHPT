using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
namespace ThucTapNhom_QuanLyTHPT
{
    public partial class FormLogin : Form
    {
        private string conn;
        private SqlConnection connection;
        public bool check_true = false;

        public FormLogin()
        {

            InitializeComponent();
            label3.Text = "";
;
        }

        private void init_conection()
        {
                conn = @"Data Source=DESKTOP-9JAUKO7\SQLEXPRESS;Initial Catalog=TTN_THPT;Integrated Security=True";
                connection = new SqlConnection(conn);
                connection.Open();
        }
        private bool check_login(string username, string password)
        {
            init_conection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from GiaoVien where username = @username and password = @password";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Connection = connection;
            SqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username_tb.Text.ToUpper();
            string pass = password_tb.Text;
            if (user == "" || pass == "")
            {
                label3.Text = "Vui lòng nhập tên đăng nhập và mật khẩu!";

            }
            else
            {
                if(check_login(user,pass) == false)
                {
                    label3.Text = "Tên đăng nhập và mật khẩu không đúng!";
                }
                else
                {
                    
                    label3.Text = "Đăng nhập thành công!";
                    check_true = true;
                    Close();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
