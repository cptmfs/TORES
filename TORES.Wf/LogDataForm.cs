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
    public partial class LogDataForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True");
        public LogDataForm()
        {
            InitializeComponent();
        }

        private void ListLog()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from datLog", connection); //cmd olusturup tüm Kayıtları getirme.
            SqlDataAdapter da = new SqlDataAdapter(cmd);                            //(da)dataAdapter ile  
            DataTable dt = new DataTable();                                         //
            da.Fill(dt);                                                            //
            dgwLog.DataSource = dt;
            connection.Close();



        }

        private void LogDataForm_Load(object sender, EventArgs e)
        {
            ListLog();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListLog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("DELETE FROM datLog WHERE LogID=@LogID",connection);
            cmd2.Parameters.AddWithValue("@LogID", dgwLog.CurrentRow.Cells[0].Value);
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"ID No : {dgwLog.CurrentRow.Cells[0].Value} olan Log Kaydı Veritabanından başarılı bir şekilde silinmiştir.","Log Kaydı Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ListLog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("DELETE FROM datLog WHERE LogID=@LogID", connection);
            cmd2.Parameters.AddWithValue("@LogID", dgwLog.CurrentRow.Cells[0].Value);
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"Log Kaydı : {dgwLog.CurrentRow.Cells[0].Value} olan Log Kaydı Veritabanından başarılı bir şekilde silinmiştir.", "Tüm kaydı Silme", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            ListLog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
