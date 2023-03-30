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
    public partial class UserPanelForm : Form
    {
        public string userStatus = "user";
        public int userIdUP;
        public string depName;
        public string nameSurname;

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True"); // burada SQL bağlantı kurduk.

        public UserPanelForm()
        {
            InitializeComponent();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeetRoomForm mf = new MeetRoomForm();
            mf.userControl = userStatus;
            mf.userIdMR = userIdUP; 
            
            this.Hide();
            mf.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReservationRequestForm rs = new ReservationRequestForm();  
            rs.userIdRR= userIdUP;
            rs.nameSurname= nameSurname;
            rs.depName= depName;
            rs.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyRequestForm rf = new MyRequestForm();
            rf.id= userIdUP;
            rf.Show();
        }

        private void UserPanelForm_Load(object sender, EventArgs e)
        {

            lblUserInfo.Text = nameSurname+" / "+depName;
        }
    }
}
