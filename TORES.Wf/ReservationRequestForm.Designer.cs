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
            this.btnSaat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendRequest.Location = new System.Drawing.Point(464, 468);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(99, 69);
            this.btnSendRequest.TabIndex = 33;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // lblDetailsOptional
            // 
            this.lblDetailsOptional.AutoSize = true;
            this.lblDetailsOptional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetailsOptional.Location = new System.Drawing.Point(52, 332);
            this.lblDetailsOptional.Name = "lblDetailsOptional";
            this.lblDetailsOptional.Size = new System.Drawing.Size(78, 20);
            this.lblDetailsOptional.TabIndex = 32;
            this.lblDetailsOptional.Text = "(Optional)";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDetails.Location = new System.Drawing.Point(167, 301);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(396, 140);
            this.txtDetails.TabIndex = 31;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetails.Location = new System.Drawing.Point(52, 307);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(62, 20);
            this.lblDetails.TabIndex = 30;
            this.lblDetails.Text = "Details ";
            // 
            // cbxMeetingEnd
            // 
            this.cbxMeetingEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeetingEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMeetingEnd.FormattingEnabled = true;
            this.cbxMeetingEnd.Location = new System.Drawing.Point(390, 234);
            this.cbxMeetingEnd.Name = "cbxMeetingEnd";
            this.cbxMeetingEnd.Size = new System.Drawing.Size(173, 28);
            this.cbxMeetingEnd.TabIndex = 29;
            // 
            // cbxMeetingStart
            // 
            this.cbxMeetingStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMeetingStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMeetingStart.FormattingEnabled = true;
            this.cbxMeetingStart.Location = new System.Drawing.Point(167, 234);
            this.cbxMeetingStart.Name = "cbxMeetingStart";
            this.cbxMeetingStart.Size = new System.Drawing.Size(175, 28);
            this.cbxMeetingStart.TabIndex = 28;
            // 
            // lblStartEnd
            // 
            this.lblStartEnd.AutoSize = true;
            this.lblStartEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartEnd.Location = new System.Drawing.Point(47, 234);
            this.lblStartEnd.Name = "lblStartEnd";
            this.lblStartEnd.Size = new System.Drawing.Size(85, 20);
            this.lblStartEnd.TabIndex = 27;
            this.lblStartEnd.Text = "Start / End";
            // 
            // dtpMeetingDate
            // 
            this.dtpMeetingDate.CustomFormat = "yyyy-MM-dd";
            this.dtpMeetingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpMeetingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMeetingDate.Location = new System.Drawing.Point(167, 172);
            this.dtpMeetingDate.Name = "dtpMeetingDate";
            this.dtpMeetingDate.Size = new System.Drawing.Size(396, 26);
            this.dtpMeetingDate.TabIndex = 26;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(47, 172);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // lblHedingBottom
            // 
            this.lblHedingBottom.AutoSize = true;
            this.lblHedingBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHedingBottom.Location = new System.Drawing.Point(17, 646);
            this.lblHedingBottom.Name = "lblHedingBottom";
            this.lblHedingBottom.Size = new System.Drawing.Size(540, 20);
            this.lblHedingBottom.TabIndex = 24;
            this.lblHedingBottom.Text = "NOVAS WORKS - TOPLANTI ODALARI REZERVASYON SİSTEMİ";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserInfo.Location = new System.Drawing.Point(203, 15);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(263, 20);
            this.lblUserInfo.TabIndex = 23;
            this.lblUserInfo.Text = "<Name Surname - Department>";
            // 
            // lblHeadingTop
            // 
            this.lblHeadingTop.AutoSize = true;
            this.lblHeadingTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeadingTop.Location = new System.Drawing.Point(17, 15);
            this.lblHeadingTop.Name = "lblHeadingTop";
            this.lblHeadingTop.Size = new System.Drawing.Size(160, 20);
            this.lblHeadingTop.TabIndex = 22;
            this.lblHeadingTop.Text = "TORES v1.0 User :";
            // 
            // btnRoomFeatures
            // 
            this.btnRoomFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomFeatures.Location = new System.Drawing.Point(454, 83);
            this.btnRoomFeatures.Name = "btnRoomFeatures";
            this.btnRoomFeatures.Size = new System.Drawing.Size(109, 62);
            this.btnRoomFeatures.TabIndex = 21;
            this.btnRoomFeatures.Text = "Room Features";
            this.btnRoomFeatures.UseVisualStyleBackColor = true;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRooms.Location = new System.Drawing.Point(47, 102);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(60, 20);
            this.lblRooms.TabIndex = 20;
            this.lblRooms.Text = "Rooms";
            // 
            // cbxRooms
            // 
            this.cbxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxRooms.FormattingEnabled = true;
            this.cbxRooms.Location = new System.Drawing.Point(167, 99);
            this.cbxRooms.Name = "cbxRooms";
            this.cbxRooms.Size = new System.Drawing.Size(231, 28);
            this.cbxRooms.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(520, 589);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 45);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(108, 542);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "label1";
            // 
            // btnSaat
            // 
            this.btnSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaat.Location = new System.Drawing.Point(381, 204);
            this.btnSaat.Name = "btnSaat";
            this.btnSaat.Size = new System.Drawing.Size(182, 25);
            this.btnSaat.TabIndex = 35;
            this.btnSaat.Text = "Saatleri Göster";
            this.btnSaat.UseVisualStyleBackColor = true;
            this.btnSaat.Click += new System.EventHandler(this.btnSaat_Click);
            // 
            // ReservationRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 674);
            this.Controls.Add(this.btnSaat);
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
        private System.Windows.Forms.Button btnSaat;
    }
}