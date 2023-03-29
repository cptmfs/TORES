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
        public string depName;
        public string nameSurname;
        
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
            MessageBox.Show(" ----  TORES  ----\r\n Novas Works Şirketi Toplantı Odaları Rezervasyon Sistemi.\r\nAdmin girişi için;\r\nKullanıcı Adı = Admin\r\n Şifre = Q1w2e3\r\nEmail = umit.karacivi@outlook.com","Support Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pnlMeetRooms_Click(object sender, EventArgs e)
        {
            //Toplantı Odası
            MeetRoomForm mf = new MeetRoomForm();
            mf.userControl = userStatus;
            mf.userIdMR= userId;
            mf.ShowDialog();
        }

        private void pnlLogData_Click_1(object sender, EventArgs e)
        {
            //Giriş Kayıtları
            LogDataForm log = new LogDataForm();
            log.Show();
        }

        private void pnlRezReq_Click(object sender, EventArgs e)
        {
            //Rezervasyon listesi
            ReservationRequestForm requestForm = new ReservationRequestForm();
            requestForm.userIdRR = this.userId;
            requestForm.depName = this.depName;
            requestForm.nameSurname = this.nameSurname;
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


        private void pnlPendingRequest_Click_1(object sender, EventArgs e)
        {
            //Bekleyen Rezervasyon istekleri açılacak
            PendingRequestForm pendingrequestForm = new PendingRequestForm();
            pendingrequestForm.ShowDialog();
        }
    }
}
