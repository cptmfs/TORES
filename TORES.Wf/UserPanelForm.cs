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
    public partial class UserPanelForm : Form
    {
        public string userStatus = "user";
        public int userid;
        
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
            mf.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReservationRequestForm rs = new ReservationRequestForm();   
            rs.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyRequestForm rf = new MyRequestForm();
            rf.id= userid;
            rf.ShowDialog();
        }
    }
}
