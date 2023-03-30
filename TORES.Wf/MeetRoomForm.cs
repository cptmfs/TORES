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
        public int userIdMR;
        public MeetRoomForm()
        {
            InitializeComponent();
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
            newRow["RoomName"] = "          Choose";
            dt.Rows.InsertAt(newRow, 0);

            cbxMeetRoom.DataSource = dt;
            cbxMeetRoom.ValueMember = "RoomID";
            cbxMeetRoom.DisplayMember = "RoomName";


            connection.Close();
        }
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MeetRoomForm_Load(object sender, EventArgs e)
        {
            RoomLoad();


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


        private void btnList_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd4 = new SqlCommand("Select RoomID,RoomCapacity,Projection,IBoard,Internet,IpTV,VOIP,AirConditioning from datRoom where RoomID=@roomId", connection);
            cmd4.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
            SqlDataReader dr2 = cmd4.ExecuteReader();
            if (dr2.Read())
            {
                nudRoomCapacity.Value = (byte)dr2.GetSqlByte(1);
                chkProjection.Checked=(bool)dr2.GetSqlBoolean(2);
                chkIBoard.Checked=(bool)dr2.GetSqlBoolean(3);
                chkInternet.Checked=(bool)dr2.GetSqlBoolean(4);
                chkIPTV.Checked=(bool)dr2.GetSqlBoolean(5);
                chkVOIP.Checked=(bool)dr2.GetSqlBoolean(6);
                chkAirCond.Checked=(bool)dr2.GetSqlBoolean(7);
            }
            else
            {
                nudRoomCapacity.Value = 0;
            }
            dr2.Close();
            connection.Close();
        }

        private void btnRequest_Click_1(object sender, EventArgs e)
        {
            ReservationRequestForm res = new ReservationRequestForm();
            res.lastSelectedRoomId = cbxMeetRoom.SelectedIndex;
            res.userIdRR = userIdMR;
            res.ShowDialog();
            this.Close();
        }
       


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("Update datRoom set Projection=@p1,IBoard=@p2,Internet=@p3,IpTV=@p4,VOIP=@p5,AirConditioning=@p6,RoomCapacity=@p7 where RoomID=@roomId",connection);
            cmd3.Parameters.AddWithValue("@p1",chkProjection.Checked);
            cmd3.Parameters.AddWithValue("@p2",chkIBoard.Checked);
            cmd3.Parameters.AddWithValue("@p3",chkInternet.Checked);
            cmd3.Parameters.AddWithValue("@p4",chkIPTV.Checked);
            cmd3.Parameters.AddWithValue("@p5",chkVOIP.Checked);
            cmd3.Parameters.AddWithValue("@p6",chkAirCond.Checked);
            cmd3.Parameters.AddWithValue("@p7",nudRoomCapacity.Value);
            cmd3.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
            cmd3.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show($"{cbxMeetRoom.Text} Toplantı Odasının Oda Özellikleri Başarılı Bir Şekilde Güncellenmiştir.","Oda Özellikleri Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
        #region Database öncesi checkbox değişikliklerini Database'e aktarma kodları .. 
        //private void chckbProjection_CheckedChanged(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    if (chkProjection.Checked == false)
        //    {
        //        SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=1", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
        //        cmd.ExecuteNonQuery();
        //    }
        //    else if (chkProjection.Checked == true)
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        cmd.Parameters.AddWithValue("@specId", 1); // Manuel olarak specId ataması gerçekleştirdim.
        //        cmd.ExecuteNonQuery();
        //    }
        //    connection.Close();
        //}

        //private void chckbIBoard_CheckedChanged(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    if (chkIBoard.Checked == false)
        //    {
        //        SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=2", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
        //        cmd.ExecuteNonQuery();
        //    }
        //    else if (chkIBoard.Checked == true)
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        cmd.Parameters.AddWithValue("@specId", 2); // Manuel olarak specId ataması gerçekleştirdim.
        //        cmd.ExecuteNonQuery();
        //    }
        //    connection.Close();
        //}

        //private void chckbInternet_CheckedChanged(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    if (chkInternet.Checked == false)
        //    {
        //        SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=3", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
        //        cmd.ExecuteNonQuery();
        //    }
        //    else if (chkInternet.Checked == true)
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        cmd.Parameters.AddWithValue("@specId", 3); // Manuel olarak specId ataması gerçekleştirdim.
        //        cmd.ExecuteNonQuery();
        //    }
        //    connection.Close();
        //}

        //private void chckbIPTV_CheckedChanged(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    if (chkIPTV.Checked == false)
        //    {
        //        SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=4", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
        //        cmd.ExecuteNonQuery();
        //    }
        //    else if (chkIPTV.Checked == true)
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        cmd.Parameters.AddWithValue("@specId", 4); // Manuel olarak specId ataması gerçekleştirdim.
        //        cmd.ExecuteNonQuery();
        //    }
        //    connection.Close();
        //}

        //private void chckbVOIP_CheckedChanged(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    if (chkVOIP.Checked == false)
        //    {
        //        SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=5", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
        //        cmd.ExecuteNonQuery();
        //    }
        //    else if (chkVOIP.Checked == true)
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        cmd.Parameters.AddWithValue("@specId", 5); // Manuel olarak specId ataması gerçekleştirdim.
        //        cmd.ExecuteNonQuery();
        //    }
        //    connection.Close();
        //}

        //private void chckbKlima_CheckedChanged(object sender, EventArgs e)
        //{
        //    connection.Open();
        //    if (chkAirCond.Checked == false)
        //    {
        //        SqlCommand cmd = new SqlCommand("Delete from jnkRoomSpec where RoomID=@roomId and SpecID=6", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        //cmd.Parameters.AddWithValue("@roomId",cbxMeetRoom.SelectedValue);
        //        cmd.ExecuteNonQuery();
        //    }
        //    else if (chkAirCond.Checked == true)
        //    {
        //        SqlCommand cmd = new SqlCommand("Insert into jnkRoomSpec (RoomID,SpecID) values (@roomId,@specId)", connection);
        //        cmd.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);
        //        cmd.Parameters.AddWithValue("@specId", 6); // Manuel olarak specId ataması gerçekleştirdim.
        //        cmd.ExecuteNonQuery();
        //    }
        //    connection.Close();
        //}
        #endregion

        #region Database güncelleme öncesi checbox verilerini database'den listeleme kodları..
        //checkedListBox1.Items.Clear();

        //connection.Open();
        //SqlCommand cmd2 = new SqlCommand("Select j.SpecID,j.RoomID,p.SpecDesc,r.RoomCapacity from jnkRoomSpec j inner join prmSpec p on p.SpecID=j.SpecID inner join datRoom r on r.RoomID=j.RoomID where j.RoomID=@roomId", connection);
        //cmd2.Parameters.AddWithValue("@roomId", cbxMeetRoom.SelectedValue);

        //SqlDataReader dr = cmd2.ExecuteReader();

        //if (dr.Read())
        //{
        //    //"nudRoomCapacity.Value = (byte)dr.GetSqlByte(3);" kodu, SqlDataReader nesnesinden "3" numaralı sütundaki veriyi alır ve bir byte türüne dönüştürerek "nudRoomCapacity" adlı bir NumericUpDown kontrolünün "Value" özelliğine atar. Veri, "GetSqlByte" yöntemiyle alınır ve bir "byte" türüne dönüştürülür. Bu, veri tipi uyumsuzluğunu önlemek için yapılır. Örneğin, "RoomCapacity" sütunu "tinyint" türünde bir sütunsa ve NumericUpDown kontrolünün "Value" özelliği "byte" türünde olduğundan, SqlDataReader nesnesinden "byte" türünde veri alınması gerekir. Bu nedenle, "GetSqlByte" yöntemi, SqlDataReader nesnesinden "byte" türünde bir değer döndürür. Ayrıca, bu örnekte veri tipi dönüşümü, "nudRoomCapacity.Value" özelliğine atamadan önce bir "byte" türüne dönüştürülmüştür.

        //    nudRoomCapacity.Value = (byte)dr.GetSqlByte(3);


        //}
        //else
        //{
        //    nudRoomCapacity.Value = 0;
        //}
        //dr.Close();

        //SqlDataAdapter da = new SqlDataAdapter(cmd2);
        //DataTable dt = new DataTable();
        //da.Fill(dt);

        //for (int i = 0; i < dt.Rows.Count; i++)
        //{
        //    checkedListBox1.Items.Add(dt.Rows[i]["SpecID"].ToString());
        //    for (int j = 0; j < checkedListBox1.Items.Count; j++)
        //    {
        //        checkedListBox1.SetItemChecked(j, true);
        //    }

        //}
        //connection.Close();


        //if (checkedListBox1.Items != null)
        //{
        //    if (checkedListBox1.CheckedItems.Contains("1"))
        //    {
        //        chkProjection.Checked = true;
        //    }
        //    else
        //    {
        //        chkProjection.Checked = false;
        //    }

        //    if (checkedListBox1.CheckedItems.Contains("2"))
        //    {
        //        chkIBoard.Checked = true;
        //    }
        //    else
        //    {
        //        chkIBoard.Checked = false;
        //    }

        //    if (checkedListBox1.CheckedItems.Contains("3"))
        //    {
        //        chkInternet.Checked = true;
        //    }
        //    else
        //    {
        //        chkInternet.Checked = false;
        //    }

        //    if (checkedListBox1.CheckedItems.Contains("4"))
        //    {
        //        chkIPTV.Checked = true;
        //    }
        //    else
        //    {
        //        chkIPTV.Checked = false;
        //    }

        //    if (checkedListBox1.CheckedItems.Contains("5"))
        //    {
        //        chkVOIP.Checked = true;
        //    }
        //    else
        //    {
        //        chkVOIP.Checked = false;
        //    }

        //    if (checkedListBox1.CheckedItems.Contains("6"))
        //    {
        //        chkAirCond.Checked = true;
        //    }
        //    else
        //    {
        //        chkAirCond.Checked = false;
        //    }
        //}
        #endregion
    }
}

