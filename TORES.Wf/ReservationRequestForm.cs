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
                cbxMeetingStart.Items.Add(i +":00" );


                cbxMeetingEnd.Items.Add((i +1)+":00"); 

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
        private string BindTime(string time)
        {
            
            string newTime = "";
            
            for (int i = 0; i < time.Length; i++) // cboxdaki saat değerlerinin arasındaki ':' i kaldırmak
            {

                if (time[i] != ':')
                {
                    newTime += time[i];
                }
            }

            return newTime;

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

            //using (SqlConnection con = new SqlConnection(conString))
            //{
            //    vsSQLCommand = "SELECT ResRoomID,ResDate,ResStartDT,ResEndDT,ResStatus ";
            //    vsSQLCommand += "FROM datReservation WHERE ResStatus=1 ";


            //    using (SqlCommand cmd = new SqlCommand(vsSQLCommand, con))
            //    {
            //        cmd.CommandType = CommandType.Text;

            //        using(SqlDataAdapter sda = new SqlDataAdapter(cmd))
            //        {
            //            using(DataSet dSet = new DataSet())
            //            {
            //                sda.Fill(dSet);

            //                //DataTable dataTable= dSet.Tables[0];

            //                // dset table da serverda isteği kabul edilmiş olan gündeki saatler enable false yapılacak 
            //                // sql de sütun eklemede problem yaşadım.
            //                // RoomId -> onaylı tarihler -> saatler 
            //                // bu sırada kontrol sağlanması lazım  ve bunun bir döngüyle olması lazım
            //                // ama döngü nerde bitecek nasıl bir komut olacak çözemedim






            //                ;
            //                for (int roomCount = 0; roomCount < dSet.Tables[0].Rows.Count; roomCount++)   // oda sayısı kadar dönüyor bir nevi id si kadar
            //                {
            //                    for (int resDate = 0; resDate < dSet.Tables[0].Columns.Count; resDate++)
            //                    {
            //                        label1.Text = dSet.Tables[0].Columns.ToString();
            //                    }
            //                }

            //            }
            //        }
            //    }
            //}

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            // butona basıldığında admine oda rezervasyon isteği gönderilecek
            
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
                        vsSQLCommand = "Insert into datReservation (ResRoomID,ResDate,ResStartDT,ResEndDT,ResUserID,ResDesc,ResStatus) values (@resRoomId,@resDate,@resStartDt,@resEndDt,@resUserId,@resDesc,@resStatus)";
                        using (SqlCommand cmd2 = new SqlCommand(vsSQLCommand, con))
                        {
                            cmd2.CommandType = CommandType.Text;
                            cmd2.Parameters.AddWithValue("@resRoomId", cbxRooms.SelectedValue);
                            cmd2.Parameters.AddWithValue("@resDate", dtpMeetingDate.Value);
                            cmd2.Parameters.AddWithValue("@resStartDt", BindTime(cbxMeetingStart.SelectedItem.ToString()));
                            cmd2.Parameters.AddWithValue("@resEndDt", BindTime(cbxMeetingEnd.SelectedItem.ToString()));
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

        private void cbxMeetingStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basSaat, sonSaat;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select ResStartDT,ResEndDT From datReservation where ResRoomID=@roomId and ResDate=@meetDt and ResStatus=1", connection);
            cmd.Parameters.AddWithValue("@roomId", cbxRooms.SelectedValue);
            cmd.Parameters.AddWithValue("@meetDt", dtpMeetingDate.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                basSaat =  (int)dr["ResStartDT"];
                sonSaat = (int)dr["ResEndDT"];
                for (int i = 0; i <= cbxMeetingStart.Items.Count; i++)
                {

                    BindTime(cbxMeetingStart.Items.ToString()); // : yi kaldırıyor.

                    // Burada if e girmiyor 
                    // koşulu dikkatli yazmamız lazım 
                    if (BindTime(cbxMeetingStart.Items.ToString()).Contains(basSaat.ToString()))
                    {
                        cbxMeetingStart.Items.Remove(basSaat);
                        cbxMeetingStart.Items.Remove(basSaat + 100);
                    }

                }
                for (int i = 0; i <= cbxMeetingEnd.Items.Count; i++)
                {
                    if (cbxMeetingEnd.Items.Contains(sonSaat))
                    {
                        cbxMeetingEnd.Items.Remove(sonSaat);
                        cbxMeetingEnd.Items.Remove(sonSaat - 100);
                    }

                }
            }

            dr.Close();
            connection.Close();

            /*sql üzerinde start/end saatleri time(0) a dönüştürüp.
            formda sql de olduğu gibi 'substring' metoduda benzeyen bir metot bulup saatin ilk iki karakterini karşılaştırabiliriz ama saat 10 da iş başı yapılması koşuluyla*/
        }
    }
}
