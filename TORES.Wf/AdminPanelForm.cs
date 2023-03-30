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
            MessageBox.Show("Hello,\r\n\r\nWelcome to the Novas Works Meeting Automation System! This automation system is designed to make planning and managing meetings in your company easier and more efficient.\r\n\r\nAfter logging in as an admin, you will see a message that includes important company information, as well as your username, password, and email address. Please ensure the accuracy of this information and only share it with those who need to know.\r\n\r\nBefore you start planning your meetings, please check your profile page and update any necessary information. You can also check out the 'Meeting Rooms' page to learn more about available rooms and their features.\r\n\r\nIf you have any questions or need assistance, please contact the Novas Works IT team. Contact information can be found at the bottom of the page.\r\n\r\nWe wish you a productive and successful meeting experience!\r\n\r\nBest regards,\r\n\r\nThe Novas Works Meeting Automation Team\r\nFor Admin Entry;\r\nUser Name = Admin\r\nPassword = Q1w2e3\r\nEmail = umit.karacivi@outlook.com", "Support Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        // 
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
