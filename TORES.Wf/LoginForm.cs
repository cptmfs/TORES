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

namespace TORES.Wf
{
    public partial class LoginForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True"); // burada SQL bağlantı kurduk.
        int userId=0;
        public LoginForm()
        {
            InitializeComponent();
        }
      
        DateTime loginTime, errorTime, logoutTime; // burada giriş/çıkı,hata günlerini tanımladık.
        string message;
        string username , password;
        private void btnExıt_Click_1(object sender, EventArgs e)
        {
            logoutTime = DateTime.Now;
            try // En sevdigimsin <3
            {
             LogMsg();
            }
            catch 
            {
            }
            Application.Exit();
        }

        private void btnSıgnIn_Click_1(object sender, EventArgs e) //btnSignIn_Click
        {
            connection.Open();
             username = txtUserName.Text;
             password = txtUserPass.Text;
            SqlCommand cmd = new SqlCommand("Select UserID,UserName,UserPass,p.DeptName,FName+' '+LName as Name From datUser d inner join prmDepartment p on p.DeptID=d.DeptID where UserName=@userName and UserPass=@userPass", connection); // SQL komut vererek verileri birbirlerini bağladık
            cmd.Parameters.AddWithValue("@userName", username);
            cmd.Parameters.AddWithValue("@userPass", password);
            SqlDataReader dr = cmd.ExecuteReader(); // bu verileri veritabanından  oku 
            if (dr.Read()) // degerleri okuduysan
            {
                int id = dr.GetInt32(0);
                string depName=dr.GetString(3);
                string nameSurname=dr.GetString(4);
                userId = id;
                loginTime = DateTime.Now; // logintime 'a giriş saaatini ve tarihini atadık..
                //Ana panel formundan bir nesne üret
                //anapaneli göster Show ile
                //bunu gizle
                if (id==1)
                {
                    AdminPanelForm admin = new AdminPanelForm();
                    admin.userId = id;
                    admin.depName= depName; 
                    admin.nameSurname= nameSurname;
                    admin.ShowDialog();

                }
                UserPanelForm user = new UserPanelForm();
                user.userIdUP= id;
                user.depName= depName;
                user.nameSurname = nameSurname;
                user.Show();

            }
            else
            {
                errorTime = DateTime.Now;
                dr.Close();
                LogErMsg();
                MessageBox.Show("UserName or UserPass Wrong! Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// hatalı girişler için mesaj kutusu oluşturduk.
                

            }
            connection.Close();
        }

        private void txtTORES_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogMsg()// SQL den aldığımız komutlar ile kullanıcı isimlerini parametrelere çevirerek veri tabanına işledik.
        {
            connection.Open();
            string userName = txtUserName.Text;
            message = $"Login Message:{userName} successfully login";
            SqlCommand cmd2 = new SqlCommand("Insert into datLog (UserID,LoginDT,LogoutDT,LogNotes) values (@userId,@loginDt,@logoutDt,@logNotes)", connection);
            cmd2.Parameters.AddWithValue("@userId", userId);
            cmd2.Parameters.AddWithValue("@loginDt", loginTime);
            cmd2.Parameters.AddWithValue("@logoutDt", logoutTime);
            cmd2.Parameters.AddWithValue("@logNotes", message);
            cmd2.ExecuteNonQuery(); // değişiklikleri veritabanına yansıt .. Kaydet gibi
            connection.Close();
        }
        private void LogErMsg()
        {
            string userName = txtUserName.Text;
            message = $"Error Message:{userName} Unauthorized login error";
            SqlCommand cmd3 = new SqlCommand("Insert into datLog (ErrorDT,LogNotes) values (@errorDT,@logNotes)", connection); 
            cmd3.Parameters.AddWithValue("@errorDT", errorTime);
            cmd3.Parameters.AddWithValue("@logNotes", message);
            cmd3.ExecuteNonQuery(); // değişiklikleri veritabanına yansıt .. Kaydet gibi
            connection.Close();
        }
    }
}
