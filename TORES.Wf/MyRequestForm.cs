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
    public partial class MyRequestForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True");

        public int id;

        public MyRequestForm()
        {

            InitializeComponent();
        }

        private void GridDoldur()
        {
            connection.Open();                                                                                      // sql verisi açılıyor
            SqlCommand cmd = new SqlCommand("select * from datReservation where ResUserID=@resUserId", connection); // sql içerisinde işlem yapılacak yer seçiliyor
            cmd.Parameters.AddWithValue("@resUserId", id);                                                          // giriş yapacak kişinin randevusu gösteriliyor.
            SqlDataAdapter da = new SqlDataAdapter(cmd);                                                            // veri çekmek için data adater kullanılıyor.
            DataSet ds = new DataSet();
            da.Fill(ds);                                                                                            // ds nin içine yazdırılıyor..
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }


        private void MyRequestForm_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            IstekIptal();
        }

        private void IstekIptal()
        {
            DialogResult dialogResult = MessageBox.Show("Toplantı isteğinizi iptal etmek istiyormusunuz ?", "İşlem Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {


                int status = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());

                if (status == 0)
                {
                    connection.Open();
                    SqlCommand cmd2 = new SqlCommand("Delete from datReservation where ResReqID=@ResReqID and ResStatus=0", connection);
                    cmd2.Parameters.AddWithValue("@ResReqID", dataGridView1.CurrentRow.Cells[0].Value);
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Seçtiğiniz Toplantı rezervasyonunuz iptal edilmiştir.");
                    GridDoldur();
                }
                else
                {
                    MessageBox.Show("Onaylanan Rezervasyon iptal edilemez lütfen kurumumuz ile iletişime geçiniz.");
                }

            }


        }


    }
}
