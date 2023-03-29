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
    public partial class PendingRequestForm : Form
    {


        public PendingRequestForm()
        {
            InitializeComponent();
        }

        SqlConnection connection= new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True"); // SQL Bağlantısı kuruldu

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnayBekleyen() //Onay bekleyen data gridi açıldı
        {
            connection.Open(); //Bağlantı açıldı 
            SqlCommand cmd = new SqlCommand("Select * From datReservation Where ResStatus=0",connection); //SQL Rezervasyon sistemi için bağlanyı açıldı
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwOnayBekleyen.DataSource = dt;
            connection.Close(); //Bağlantı kapandı
        }
        private void OnayVerilen()//Onay verilen data gridi açıld
        {
            connection.Open();//Bağlantı açıldı 
            SqlCommand cmd2 = new SqlCommand("Select * From datReservation Where ResStatus=1",connection);//SQL Rezervasyon sistemi için bağlanyı açıldı
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgwOnayVerilen.DataSource = dt2;
            connection.Close();//Bağlantı kapandı
        }

        private void PendingRequestForm_Load(object sender, EventArgs e)
        {
            OnayBekleyen();
            OnayVerilen ();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            connection.Open ();
            SqlCommand cmd3 = new SqlCommand("update datReservation set ResStatus=1 where ResReqID=@resReqID",connection);
            cmd3.Parameters.AddWithValue("@resReqID", dgwOnayBekleyen.CurrentRow.Cells[0].Value);
            cmd3.ExecuteNonQuery();
            connection.Close();
            OnayBekleyen();
            OnayVerilen();
            MessageBox.Show("Reservation Request Approved ", "Reservation Request");

        }
    }
}
