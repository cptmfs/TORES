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
    public partial class MeetRoomForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True");
        public string userControl;
        public MeetRoomForm()
        {
            InitializeComponent();
        }
        private void cbxMeetRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combobox ın seçili indexinden checkboxta Enabled : True/False mu ayarlamasını yapacağız
            
            
        }

        private void RoomLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM datRoom", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxMeetRoom.DataSource = dt;
            cbxMeetRoom.DisplayMember = "RoomName";
            cbxMeetRoom.ValueMember = "RoomID";
            connection.Close();
        }

        private void RoomPropLoad()
        {

        }
        private void DatagwLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM datRoom", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwMeetRoom.DataSource = dt;
            connection.Close();

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            // Kullanıcının karar verdiği odanın SelectedValue değerini rezervasyon istek formuna parametre olarak gönderilecek
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MeetRoomForm_Load(object sender, EventArgs e)
        {
            RoomLoad();
            DatagwLoad();
            CheckedListBoxLoad();
            if (userControl == "user")
            {
                checkedListBox1.Enabled = false;
                nudRoomCapacity.Enabled = false;
                cbxMeetRoom.DropDownStyle = ComboBoxStyle.DropDownList;
                checkedListBox1.Visible = false;
            }
            checkedListBox1.Visible=false;
        }
        private void CheckedListBoxLoad()
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("Delete from jnkRoomSpec where  ");
            connection.Close();
        }

        private void cbxMeetRoom_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("Select j.SpecID,RoomID,p.SpecDesc from jnkRoomSpec j inner join prmSpec p on p.SpecID=j.SpecID where RoomID=@roomId", connection);
            cmd2.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            checkedListBox1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i]["SpecID"].ToString());
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    checkedListBox1.SetItemChecked(j, true);
                }

            }

            if (checkedListBox1.Items != null)
            {
                if (checkedListBox1.CheckedItems.Contains("1"))
                {
                    chckbProjection.Checked = true;
                }
                if (checkedListBox1.CheckedItems.Contains("2"))
                {
                    chckbIBoard.Checked = true;
                }
                if (checkedListBox1.CheckedItems.Contains("3"))
                {
                    chckbInternet.Checked = true;
                }
                if (checkedListBox1.CheckedItems.Contains("4"))
                {
                    chckbIPTV.Checked = true;
                }
                if (checkedListBox1.CheckedItems.Contains("5"))
                {
                    chckbVOIP.Checked = true;
                }
            }
            connection.Close();
        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {
            ReservationRequestForm res = new ReservationRequestForm();
            res.lastSelectedRoomId = cbxMeetRoom.SelectedIndex + 1;
            res.ShowDialog();
            this.Close();
        }
    }
}
