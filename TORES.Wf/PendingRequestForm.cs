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

        SqlConnection connection= new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True");

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OnayBekleyen()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From datReservation Where ResStatus=0",connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwOnayBekleyen.DataSource = dt;
            connection.Close();
        }
        private void OnayVerilen()
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("Select * From datReservation Where ResStatus=1",connection);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgwOnayVerilen.DataSource = dt2;
            connection.Close();
        }

        private void PendingRequestForm_Load(object sender, EventArgs e)
        {
            OnayBekleyen();
            OnayVerilen ();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            

        }
    }
}
