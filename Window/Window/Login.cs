using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Data.SqlClient;

namespace Window
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            CommonClass commClass = new CommonClass();
            this.LblValid.Text = commClass.RandomNum(4);
        }

        private void SaveLogin_Click(object sender, EventArgs e)
        {
            //连接数据库
            DBClass db = new DBClass();
            db.GetConnection();
            //拿到控件
            String username = uName.Text.Trim();
            String password = pWord.Text.Trim();
            //Sql语句
            String SqlStr = "SELECT AdminName,PassWord from tb_Admin where AdminName='" + username + "' and PassWord= '" + password + "'";
            SqlCommand cmd = new SqlCommand(SqlStr, db.GetConnection());
            SqlDataReader dr = db.reDr(SqlStr);
            //读取下一跳记录
            dr.Read();
            if (username == "" || password == "")
            {
                LblError.Text = "请输入用户名或者密码";
            }
            else if (txtValid.Text.Trim() == "")
            {
                LblError.Text = "请输入验证码";
            }
            else if (dr.HasRows)
            {
                if (txtValid.Text.Trim() == LblValid.Text.Trim())
                {
                    int isOK = cmd.ExecuteNonQuery();
                    if (isOK < 0)
                    {
                        WinAdmin win = new WinAdmin();
                        win.Show();
                        this.Hide();
                    }
                }
                else
                {
                    LblError.Text = "请输入正确的验证码！";
                }
            }
            else
            {
                LblError.Text = "登录有误，请核对再重新登录！";
            }
        }
    }
}