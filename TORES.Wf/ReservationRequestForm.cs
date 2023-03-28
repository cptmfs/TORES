using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TORES.Wf
{
    public partial class ReservationRequestForm : Form
    {

        public int userId; // userId değişkeninini login sayfasından  giriş yapan kullanıcıdan alacağız..
        // SQL Bağlantı
        string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True";
        string vsSQLCommand = "";
        string vsSQLQuery = "";


        public int lastSelectedRoomId;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True");
        
        
        public ReservationRequestForm()
        {
            InitializeComponent();
        }




        private void btnRoomFeatures_Click(object sender, EventArgs e)
        {
            // MeetRoomForm 'a yönlendirecek
            MeetRoomForm meetRoomForm = new MeetRoomForm();
            meetRoomForm.ShowDialog();

        }

        private void lblHedingBottom_Click(object sender, EventArgs e)
        {

        }
        private void lblDetails_Click(object sender, EventArgs e)
        {

        }

        private void ReservationRequestForm_Load(object sender, EventArgs e)
        {
            #region cbxMeeting(Start/End)

            cbxMeetingStart.Items.Clear();

            for (int i = 9; i <= 19; i++)   // cbxMeetingStart ve cbxMeetingEnd 09:00 - 18:00 arası dolduruldu
            {
                cbxMeetingStart.Items.Add(i + ":00");


                cbxMeetingEnd.Items.Add(i + ":00");




            }

            cbxMeetingStart.SelectedIndex = 0;      // saatleri ilk indekste seçili
            cbxMeetingEnd.SelectedIndex = 0;

            #endregion

            GetRooms(); // oda isimlerini cbxRooms'a çekti

            GetReservationInfo(); // server'dan rezervasyon bilgilerini çekti




            // Kullanıcıya göre lblUserInfo Ad Soyad - Departman olarak değişecek
            // oda isimlerine göre rezerve edilen tarihler çekilecek - db den
            // tarih bilgisi girilecek bu bilgilere göre db ki tablo çekilecek (dbo.dtReservation)
            // yeni girilen ve önceden kayıtlı olan bilgiler kıyaslanacak
            // uygun saatler comboda gösterilecek ? 




            lblId.Text = userId.ToString();
            
        }

        #region tarih karşılaştırma
        /* datReservation'dan toplantı başlangıç ve bitiş tarihleri alınacak
         * bunlar bir tabloda tutulacak
         * seçilmiş olan başlangıç ve bitiş tarih+saat BindDateTime() ile birleşecek 
         * bunlar serverdan gelen tarih tablosuyla kıyaslanacak 
         * string olarak tutulan tarih bilgisinin birbirine eşitliği kontrol edilecek
         * eşitse o tarih dolu uyarısı verilecek
         
         
         */
        #endregion


        private string BindDateTime(string date,string time)
        {
            // burada amacım gelen tarih ve saat bilgilerini birleştirmek. Format -> (GGAAYYYYSSDD)

            date  = dtpMeetingDate.Text  ;   // dtpMeetingDate teki tarihi string olarak aldım
            
            string newDate = ""; // gg.aa.yyyy formatında gelen date değişkeni arasındaki noktaları silip atacağım yeni değişken           
            string newTime = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] != '.' )
                {
                    newDate += date[i];
                }

            }
            for (int i = 0; i < time.Length; i++) // cboxdaki saatdeğerlerinin arasındaki ':' i kaldırmak
            {

                if (time[i] != ':')
                {
                    newTime += time[i];
                }
            }

            newDate += newTime;


            return newDate;
            
        }
        
        

        private void GetRooms()
        {
            #region cbxRooms a TORESDB den Oda isimlerini ekleme 
            // Oda isimleri cbxRooms a eklendi.
            using (SqlConnection con = new SqlConnection(conString))  // TORESDB bağlantı
            {
                vsSQLCommand = "SELECT * FROM datRoom";
                using (SqlCommand cmd = new SqlCommand(vsSQLCommand, con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dSet = new DataSet())
                        {
                            sda.Fill(dSet);


                            DataRow newRow = dSet.Tables[0].NewRow(); // birinci indekste "Seçiniz" eklendi ve seçili
                            newRow["RoomID"] = 0;
                            newRow["RoomName"] = "Seçiniz";
                            dSet.Tables[0].Rows.InsertAt(newRow, 0);

                            cbxRooms.DataSource = dSet.Tables[0];
                            cbxRooms.ValueMember = "RoomID";
                            cbxRooms.DisplayMember = "RoomName";

                        }
                    }
                }
            }
            #endregion
        }

        private void GetReservationInfo()
        {
            // Server'dan datReservtion u çekecek

            using (SqlConnection con = new SqlConnection(conString))
            {
                vsSQLCommand = "SELECT * FROM datReservation";

                using (SqlCommand cmd = new SqlCommand(vsSQLCommand, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using(SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using(DataSet dSet = new DataSet())
                        {
                            sda.Fill(dSet);

                            
                            

                        }
                    }
                }
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            // butona basıldığında admine oda rezervasyon isteği gönderilecek
            string dateStart = BindDateTime(dtpMeetingDate.Text,cbxMeetingStart.SelectedItem.ToString());
            string dateEnd= BindDateTime(dtpMeetingDate.Text, cbxMeetingEnd.SelectedItem.ToString());

            #region Admine oda rezervasyon isteği gönderme

            if (cbxRooms.SelectedIndex < 1)
            {
                MessageBox.Show("Lüften oda seçiniz.");
            }

                if (dtpMeetingDate.Value < DateTime.Now)
                {
                    MessageBox.Show("Lütfen geçerli bir tarih seçiniz.");

                }
                else
                {



                    using (SqlConnection con = new SqlConnection(conString))  // TORESDB bağlantı
                    {
                        vsSQLCommand = "Insert into datReservation (ResRoomID,ResStartDT,ResEndDT,ResUserID,ResDesc,ResStatus) values (@resRoomId,@resStartDt,@resEndDt,@resUserId,@resDesc,@resStatus)";
                        using (SqlCommand cmd2 = new SqlCommand(vsSQLCommand, con))
                        {
                            cmd2.CommandType = CommandType.Text;
                            cmd2.Parameters.AddWithValue("@resRoomId", cbxRooms.SelectedValue);
                            cmd2.Parameters.AddWithValue("@resStartDt", dateStart);
                            cmd2.Parameters.AddWithValue("@resEndDt", dateEnd);
                            cmd2.Parameters.AddWithValue("@resUserId", userId);
                            cmd2.Parameters.AddWithValue("@resDesc", txtDetails.Text);
                            cmd2.Parameters.AddWithValue("@resStatus", 0);
                            con.Open();
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Rezervasyon isteği başarılı bir şekilde oluşturuldu. Admin onayı bekliyor.", "Reservation Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();

                            this.Close();  // Admin menüsüne dönüyor 
                        }
                    }
                }
            
            #endregion

        }
    }
}
