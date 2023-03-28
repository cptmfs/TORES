using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TORES.Wf
{
    public partial class AdminPanelForm : Form
    {
        public int userId;
        
        public AdminPanelForm()
        {
            InitializeComponent();
        }
        public string userStatus = "admin";
        private void pnlExit_Click(object sender, EventArgs e)
        {
            //Uygulamadan çıkış
            Application.Exit();
        }

        private void pnlSupport_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Novas Works Toplantı Odaları Rezervasyon sistemindesiniz. TORES sizlerin toplantılarınızın çakışmasını engelemek için yapılmıştır. " +
              "\r\n Admin girişi için;\r\n Kullanıcı Adı = Admin" +
              "\r\n Şifre = Q1w2e3" +
              "\r\n EMail = umit.karacivi@outlook.com","Support Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pnlMeetRooms_Click(object sender, EventArgs e)
        {
            //Toplantı Odası
            MeetRoomForm mf = new MeetRoomForm();
            mf.userControl = userStatus;
            mf.ShowDialog();
           




        }

        private void pnlLogData_Click_1(object sender, EventArgs e)
        {
            //Giriş Kayıtları


        }

        private void pnlRezReq_Click(object sender, EventArgs e)
        {
            //Rezervasyon listesi
            ReservationRequestForm requestForm = new ReservationRequestForm();
            requestForm.userId = this.userId;
            requestForm.ShowDialog();

        }

        private void pnlRoomList_Click_1(object sender, EventArgs e)
        {
            //Oda Listesi açılacak
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            lblusID.Text=userId.ToString();
        }



        private void pnlRoomList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
