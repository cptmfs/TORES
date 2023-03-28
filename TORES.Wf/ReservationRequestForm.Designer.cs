namespace TORES.Wf
{
    partial class ReservationRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.lblDetailsOptional = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.cbxMeetingEnd = new System.Windows.Forms.ComboBox();
            this.cbxMeetingStart = new System.Windows.Forms.ComboBox();
            this.lblStartEnd = new System.Windows.Forms.Label();
            this.dtpMeetingDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHedingBottom = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblHeadingTop = new System.Windows.Forms.Label();
            this.btnRoomFeatures = new System.Windows.Forms.Button();
            this.lblRooms = new System.Windows.Forms.Label();
            this.cbxRooms = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendRequest.Location = new System.Drawing.Point(619, 576);
            this.btnSendRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(132, 85);
            this.btnSendRequest.TabIndex = 33;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // lblDetailsOptional
            // 
            this.lblDetailsOptional.AutoSize = true;
            this.lblDetailsOptional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetailsOptional.Location = new System.Drawing.Point(69, 409);
            this.lblDetailsOptional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailsOptional.Name = "lblDetailsOptional";
            this.lblDetailsOptional.Size = new System.Drawing.Size(99, 25);
            this.lblDetailsOptional.TabIndex = 32;
            this.lblDetailsOptional.Text = "(Optional)";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDetails.Location = new System.Drawing.Point(223, 370);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(527, 171);
            this.txtDetails.TabIndex = 31;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetails.Location = new System.Drawing.Point(69, 378);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(76, 25);
            this.lblDetails.TabIndex = 30;
            this.lblDetails.Text = "Details ";
            // 
            // cbxMeetingEnd
            // 
            this.cbxMeetingEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeetingEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMeetingEnd.FormattingEnabled = true;
            this.cbxMeetingEnd.Location = new System.Drawing.Point(520, 288);
            this.cbxMeetingEnd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMeetingEnd.Name = "cbxMeetingEnd";
            this.cbxMeetingEnd.Size = new System.Drawing.Size(229, 33);
            this.cbxMeetingEnd.TabIndex = 29;
            // 
            // cbxMeetingStart
            // 
            this.cbxMeetingStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeetingStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMeetingStart.FormattingEnabled = true;
            this.cbxMeetingStart.Location = new System.Drawing.Point(223, 288);
            this.cbxMeetingStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxMeetingStart.Name = "cbxMeetingStart";
            this.cbxMeetingStart.Size = new System.Drawing.Size(232, 33);
            this.cbxMeetingStart.TabIndex = 28;
            // 
            // lblStartEnd
            // 
            this.lblStartEnd.AutoSize = true;
            this.lblStartEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartEnd.Location = new System.Drawing.Point(63, 288);
            this.lblStartEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartEnd.Name = "lblStartEnd";
            this.lblStartEnd.Size = new System.Drawing.Size(104, 25);
            this.lblStartEnd.TabIndex = 27;
            this.lblStartEnd.Text = "Start / End";
            // 
            // dtpMeetingDate
            // 
            this.dtpMeetingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpMeetingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMeetingDate.Location = new System.Drawing.Point(223, 212);
            this.dtpMeetingDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMeetingDate.Name = "dtpMeetingDate";
            this.dtpMeetingDate.Size = new System.Drawing.Size(527, 30);
            this.dtpMeetingDate.TabIndex = 26;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(63, 212);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // lblHedingBottom
            // 
            this.lblHedingBottom.AutoSize = true;
            this.lblHedingBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHedingBottom.Location = new System.Drawing.Point(23, 795);
            this.lblHedingBottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHedingBottom.Name = "lblHedingBottom";
            this.lblHedingBottom.Size = new System.Drawing.Size(664, 25);
            this.lblHedingBottom.TabIndex = 24;
            this.lblHedingBottom.Text = "NOVAS WORKS - TOPLANTI ODALARI REZERVASYON SİSTEMİ";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserInfo.Location = new System.Drawing.Point(271, 18);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(318, 25);
            this.lblUserInfo.TabIndex = 23;
            this.lblUserInfo.Text = "<Name Surname - Department>";
            // 
            // lblHeadingTop
            // 
            this.lblHeadingTop.AutoSize = true;
            this.lblHeadingTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeadingTop.Location = new System.Drawing.Point(23, 18);
            this.lblHeadingTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingTop.Name = "lblHeadingTop";
            this.lblHeadingTop.Size = new System.Drawing.Size(197, 25);
            this.lblHeadingTop.TabIndex = 22;
            this.lblHeadingTop.Text = "TORES v1.0 User :";
            // 
            // btnRoomFeatures
            // 
            this.btnRoomFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomFeatures.Location = new System.Drawing.Point(605, 102);
            this.btnRoomFeatures.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoomFeatures.Name = "btnRoomFeatures";
            this.btnRoomFeatures.Size = new System.Drawing.Size(145, 76);
            this.btnRoomFeatures.TabIndex = 21;
            this.btnRoomFeatures.Text = "Room Features";
            this.btnRoomFeatures.UseVisualStyleBackColor = true;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRooms.Location = new System.Drawing.Point(63, 126);
            this.lblRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(73, 25);
            this.lblRooms.TabIndex = 20;
            this.lblRooms.Text = "Rooms";
            // 
            // cbxRooms
            // 
            this.cbxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxRooms.FormattingEnabled = true;
            this.cbxRooms.Location = new System.Drawing.Point(223, 122);
            this.cbxRooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxRooms.Name = "cbxRooms";
            this.cbxRooms.Size = new System.Drawing.Size(307, 33);
            this.cbxRooms.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(693, 725);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 55);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(144, 667);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 16);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(416, 581);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 35;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReservationRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 830);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblDetailsOptional);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cbxMeetingEnd);
            this.Controls.Add(this.cbxMeetingStart);
            this.Controls.Add(this.lblStartEnd);
            this.Controls.Add(this.dtpMeetingDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHedingBottom);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblHeadingTop);
            this.Controls.Add(this.btnRoomFeatures);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.cbxRooms);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReservationRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservationRequestForm";
            this.Load += new System.EventHandler(this.ReservationRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Label lblDetailsOptional;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox cbxMeetingEnd;
        private System.Windows.Forms.ComboBox cbxMeetingStart;
        private System.Windows.Forms.Label lblStartEnd;
        private System.Windows.Forms.DateTimePicker dtpMeetingDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHedingBottom;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblHeadingTop;
        private System.Windows.Forms.Button btnRoomFeatures;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.ComboBox cbxRooms;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}