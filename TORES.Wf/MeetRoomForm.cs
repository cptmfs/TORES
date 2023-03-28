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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TORES.Wf
{
    public partial class MeetRoomForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToresDB;Integrated Security=True");

        public string userControl;
        public int userId;
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
            SqlCommand cmd = new SqlCommand("SELECT RoomID,RoomName FROM datRoom", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            DataRow newRow = dt.NewRow();
            newRow["RoomID"] = 0;
            newRow["RoomName"] = "---Seçiniz---";
            dt.Rows.InsertAt(newRow, 0);

            cbxMeetRoom.DataSource = dt;
            cbxMeetRoom.ValueMember = "RoomID";
            cbxMeetRoom.DisplayMember = "RoomName";


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
                gbxRoomSpec.Enabled = false;
                nudRoomCapacity.Enabled = false;
                cbxMeetRoom.DropDownStyle = ComboBoxStyle.DropDownList;
                checkedListBox1.Visible = false;
                btnUpdate.Enabled = false;
            }
            checkedListBox1.Visible = false;

        }
        private void CheckedListBoxLoad()
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("Delete from jnkRoomSpec where ");
            connection.Close();
        }


        private void btnGetir_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();

            connection.Open();
            SqlCommand cmd2 = new SqlCommand("Select j.SpecID,j.RoomID,p.SpecDesc,r.RoomCapacity from jnkRoomSpec j inner join prmSpec p on p.SpecID=j.SpecID inner join datRoom r on r.RoomID=j.RoomID where j.RoomID=@roomId", connection);
            cmd2.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);

            SqlDataReader dr = cmd2.ExecuteReader();

            if (dr.Read())
            {
                //"nudRoomCapacity.Value = (byte)dr.GetSqlByte(3);" kodu, SqlDataReader nesnesinden "3" numaralı sütundaki veriyi alır ve bir byte türüne dönüştürerek "nudRoomCapacity" adlı bir NumericUpDown kontrolünün "Value" özelliğine atar. Veri, "GetSqlByte" yöntemiyle alınır ve bir "byte" türüne dönüştürülür. Bu, veri tipi uyumsuzluğunu önlemek için yapılır. Örneğin, "RoomCapacity" sütunu "tinyint" türünde bir sütunsa ve NumericUpDown kontrolünün "Value" özelliği "byte" türünde olduğundan, SqlDataReader nesnesinden "byte" türünde veri alınması gerekir. Bu nedenle, "GetSqlByte" yöntemi, SqlDataReader nesnesinden "byte" türünde bir değer döndürür. Ayrıca, bu örnekte veri tipi dönüşümü, "nudRoomCapacity.Value" özelliğine atamadan önce bir "byte" türüne dönüştürülmüştür.

                nudRoomCapacity.Value = (byte)dr.GetSqlByte(3);


            }
            else
            {
                nudRoomCapacity.Value = 0;
            }
            dr.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i]["SpecID"].ToString());
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    checkedListBox1.SetItemChecked(j, true);
                }

            }
            connection.Close();


            if (checkedListBox1.Items != null)
            {
                if (checkedListBox1.CheckedItems.Contains("1"))
                {
                    chckbProjection.Checked = true;
                }
                else
                {
                    chckbProjection.Checked = false;
                }

                if (checkedListBox1.CheckedItems.Contains("2"))
                {
                    chckbIBoard.Checked = true;
                }
                else
                {
                    chckbIBoard.Checked = false;
                }

                if (checkedListBox1.CheckedItems.Contains("3"))
                {
                    chckbInternet.Checked = true;
                }
                else
                {
                    chckbInternet.Checked = false;
                }

                if (checkedListBox1.CheckedItems.Contains("4"))
                {
                    chckbIPTV.Checked = true;
                }
                else
                {
                    chckbIPTV.Checked = false;
                }

                if (checkedListBox1.CheckedItems.Contains("5"))
                {
                    chckbVOIP.Checked = true;
                }
                else
                {
                    chckbVOIP.Checked = false;
                }

                if (checkedListBox1.CheckedItems.Contains("6"))
                {
                    chckbKlima.Checked = true;
                }
                else
                {
                    chckbKlima.Checked = false;
                }

            }


        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {
            ReservationRequestForm res = new ReservationRequestForm();
            res.lastSelectedRoomId = cbxMeetRoom.SelectedIndex;
            res.userId = this.userId;
            res.ShowDialog();
            this.Close();
        }

        private void chckbProjection_CheckedChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (chckbProjection.Checked == false)
            {
                SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=1", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
                cmd.ExecuteNonQuery();
            }
            else if (chckbProjection.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                cmd.Parameters.AddWithValue("@specId", 1); // Manuel olarak specId ataması gerçekleştirdim.
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void chckbIBoard_CheckedChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (chckbIBoard.Checked == false)
            {
                SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=2", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
                cmd.ExecuteNonQuery();
            }
            else if (chckbIBoard.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                cmd.Parameters.AddWithValue("@specId", 2); // Manuel olarak specId ataması gerçekleştirdim.
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void chckbInternet_CheckedChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (chckbInternet.Checked == false)
            {
                SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=3", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
                cmd.ExecuteNonQuery();
            }
            else if (chckbInternet.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                cmd.Parameters.AddWithValue("@specId", 3); // Manuel olarak specId ataması gerçekleştirdim.
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void chckbIPTV_CheckedChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (chckbIPTV.Checked == false)
            {
                SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=4", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
                cmd.ExecuteNonQuery();
            }
            else if (chckbIPTV.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                cmd.Parameters.AddWithValue("@specId", 4); // Manuel olarak specId ataması gerçekleştirdim.
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void chckbVOIP_CheckedChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (chckbVOIP.Checked == false)
            {
                SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=5", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
                cmd.ExecuteNonQuery();
            }
            else if (chckbVOIP.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                cmd.Parameters.AddWithValue("@specId", 5); // Manuel olarak specId ataması gerçekleştirdim.
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void chckbKlima_CheckedChanged(object sender, EventArgs e)
        {
            connection.Open();
            if (chckbKlima.Checked == false)
            {
                SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=6", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
                cmd.ExecuteNonQuery();
            }
            else if (chckbKlima.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
                cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
                cmd.Parameters.AddWithValue("@specId", 6); // Manuel olarak specId ataması gerçekleştirdim.
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}

