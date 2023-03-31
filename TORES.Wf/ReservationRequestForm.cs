﻿using System;
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
        public int userIdRR; // userId değişkeninini login sayfasından  giriş yapan kullanıcıdan alacağız..
        public string depName;
        public string nameSurname;
        // SQL Bağlantı
        string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True";
        string vsSQLCommand = "";

        public int lastSelectedRoomId;
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True");
        public ReservationRequestForm()
        {
            InitializeComponent();
        }
        private void ListHours()
        {
            #region cbxMeeting(Start/End)

            cbxMeetingStart.Items.Clear();
            cbxMeetingEnd.Items.Clear();

            for (int i = 9; i < 19; i++)   // cbxMeetingStart ve cbxMeetingEnd 09:00 - 18:00 arası dolduruldu
            {
                cbxMeetingStart.Items.Add(i); //+ ":00"



                cbxMeetingEnd.Items.Add(i+1); //+ ":00"

            }
            cbxMeetingStart.SelectedIndex = 0;      // saatleri ilk indekste seçili
            cbxMeetingEnd.SelectedIndex = 0;

            #endregion
        }
        private void ReservationRequestForm_Load(object sender, EventArgs e)
        {
            ListHours();

            GetRooms(); // oda isimlerini cbxRooms'a çekti

            GetReservationInfo(); // server'dan rezervasyon bilgilerini çekti
            lblUserInfo.Text = nameSurname + " / " + depName;
            lblId.Text = userIdRR.ToString();
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
                            newRow["RoomName"] = "                   Choose   ";
                            dSet.Tables[0].Rows.InsertAt(newRow, 0);

                            cbxRooms.DataSource = dSet.Tables[0];
                            cbxRooms.ValueMember = "RoomID";
                            cbxRooms.DisplayMember = "RoomName";                           
                        }
                    }
                }
            }
            #endregion
            try
            {
                cbxRooms.SelectedIndex = lastSelectedRoomId;

            }
            catch 
            {

            }
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

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dSet = new DataSet())
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
        private void rescontrol()
        {
            int basSaat, sonSaat;
            connection.Open();
            SqlCommand cmd5 = new SqlCommand("Select ResStartDT,ResEndDT From datReservation where ResRoomID=@roomId and ResMeetingDT=@meetDt and ResStatus=1", connection);
            cmd5.Parameters.AddWithValue("@roomId", cbxRooms.SelectedValue);
            cmd5.Parameters.AddWithValue("@meetDt", dtpMeetingDate.Text);
            SqlDataReader dr3 = cmd5.ExecuteReader();
            while (dr3.Read())
            {
                basSaat = (int)dr3["ResStartDT"];
                sonSaat = (int)dr3["ResEndDT"];
                for (int j = basSaat; j < sonSaat; j++)
                {
                    if (cbxMeetingStart.Items.Contains(j))
                    {
                        cbxMeetingStart.Items.Remove(j);
                    }
                }
                for (int k = basSaat; k <= sonSaat; k++)
                {
                    if (cbxMeetingEnd.Items.Contains(k))
                    {
                        cbxMeetingEnd.Items.Remove(k);
                    }
                }
            }
            dr3.Close();
            connection.Close();
        }
        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            #region Admine oda rezervasyon isteği gönderme

            if (cbxRooms.SelectedIndex < 1)
            {
                MessageBox.Show("Please select a room.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (dtpMeetingDate.Value <= DateTime.UtcNow) // Novas Şirketi Estonya kuruluşlu olduğu için UTC..
            {
                MessageBox.Show("Please select a valid date.");

            }
            else if (int.Parse(cbxMeetingStart.Text) >= int.Parse(cbxMeetingEnd.Text))
            {
                MessageBox.Show("Please check your clock selection.");
            }       
            else
            {
                // butona basıldığında admine oda rezervasyon isteği gönderilecek
                using (SqlConnection con = new SqlConnection(conString))  // TORESDB bağlantı
                {
                    vsSQLCommand = "Insert into datReservation (ResRoomID,ResStartDT,ResEndDT,ResUserID,ResDesc,ResStatus,ResMeetingDT) values (@resRoomId,@resStartDt,@resEndDt,@resUserId,@resDesc,@resStatus,@resMeetingDT)";
                    using (SqlCommand cmd2 = new SqlCommand(vsSQLCommand, con))
                    {
                        cmd2.CommandType = CommandType.Text;
                        cmd2.Parameters.AddWithValue("@resRoomId", cbxRooms.SelectedValue);
                        cmd2.Parameters.AddWithValue("@resStartDt", cbxMeetingStart.SelectedItem);
                        cmd2.Parameters.AddWithValue("@resEndDt", cbxMeetingEnd.SelectedItem);
                        cmd2.Parameters.AddWithValue("@resUserId", userIdRR);
                        cmd2.Parameters.AddWithValue("@resDesc", txtDetails.Text);
                        cmd2.Parameters.AddWithValue("@resStatus", 0);
                        cmd2.Parameters.AddWithValue("@resMeetingDT", dtpMeetingDate.Text);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Reservation request created successfully. Waiting for admin approval.", "Reservation Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        this.Close();
                    }
                }
            }

            #endregion   
        }

        private void btnRoomFeatures_Click_1(object sender, EventArgs e)
        {
            // MeetRoomForm 'a yönlendirecek
            MeetRoomForm mt = new MeetRoomForm();
            mt.userIdMR = userIdRR;
            mt.lastSelectedRoomIdMR = cbxRooms.SelectedIndex;
            mt.nameS = nameSurname;
            mt.depnameMR = depName;
            mt.Show();
            
        }

        private void btnShowHour_Click(object sender, EventArgs e)
        {
            if (cbxRooms.SelectedIndex > 0)
            {
                if (cbxMeetingStart.Visible == false || cbxMeetingEnd.Visible == false || lblStartEnd.Visible == false)
                {
                    cbxMeetingStart.Visible = true;
                    cbxMeetingEnd.Visible = true;
                    lblStartEnd.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please Choose Room", "Show Available Hours Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            //ReservationTimeControl();
            ListHours(); // Eğer tarih değişirse combobox saatleri standrt hale döndürmek içindir..
            rescontrol();
            cbxMeetingStart.SelectedIndex = 0;
            cbxMeetingEnd.SelectedIndex = 0;
            
        }

        #region ReservationTimeControl
        //private void ReservationTimeControl()
        //{
        //    List<Meeting> meetingHourList = new List<Meeting>();
        //    connection.Open();
        //    SqlCommand cmd = new SqlCommand("Select ResStartDT,ResEndDT From datReservation where ResRoomID=@roomId and ResMeetingDT=@meetDt and ResStatus=1", connection);
        //    cmd.Parameters.AddWithValue("@roomId", cbxRooms.SelectedValue);
        //    cmd.Parameters.AddWithValue("@meetDt", dtpMeetingDate.Text);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        Meeting meeting = new Meeting();
        //        meeting.ResStartDT = (int)dr["ResStartDT"];
        //        meeting.ResEndDT = (int)dr["ResEndDT"];
        //        meetingHourList.Add(meeting);
        //    }
        //    dr.Close();
        //    connection.Close();

        //    foreach (var item in meetingHourList)
        //    {
        //        for (int i = item.ResStartDT; i < item.ResEndDT; i++)
        //        {
        //            var startTime = cbxMeetingStart.Items.Cast<int>().SingleOrDefault(x => x == i);
        //            if (startTime != null)
        //            {
        //                cbxMeetingStart.Items.Remove(startTime);
        //            }
        //        }
        //        for (int i = item.ResStartDT; i < item.ResEndDT + 1; i++)
        //        {
        //            var endTime = cbxMeetingEnd.Items.Cast<int>().SingleOrDefault(y => y == i);

        //            if (endTime != null)
        //            {
        //                cbxMeetingEnd.Items.Remove(endTime);
        //            }
        //        }

        //    }
        //}
        //public class Meeting
        //{
        //    public int ResStartDT { get; set; }
        //    public int ResEndDT { get; set; }
        //}
        #endregion

    }
}