namespace TORES.Wf
{
    partial class MeetRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetRoomForm));
            this.btnRequest = new System.Windows.Forms.Button();
            this.chkVOIP = new System.Windows.Forms.CheckBox();
            this.chkIPTV = new System.Windows.Forms.CheckBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.chkIBoard = new System.Windows.Forms.CheckBox();
            this.chkProjection = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRoomCapacity = new System.Windows.Forms.NumericUpDown();
            this.chkAirCond = new System.Windows.Forms.CheckBox();
            this.cbxMeetRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.gbxRoomSpec = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomCapacity)).BeginInit();
            this.gbxRoomSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRequest.Location = new System.Drawing.Point(384, 174);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(107, 49);
            this.btnRequest.TabIndex = 12;
            this.btnRequest.Text = "Reservation Request";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click_1);
            // 
            // chkVOIP
            // 
            this.chkVOIP.AutoSize = true;
            this.chkVOIP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkVOIP.ForeColor = System.Drawing.Color.Black;
            this.chkVOIP.Location = new System.Drawing.Point(141, 19);
            this.chkVOIP.Name = "chkVOIP";
            this.chkVOIP.Size = new System.Drawing.Size(71, 27);
            this.chkVOIP.TabIndex = 2;
            this.chkVOIP.Text = "VOIP";
            this.chkVOIP.UseVisualStyleBackColor = true;
            // 
            // chkIPTV
            // 
            this.chkIPTV.AutoSize = true;
            this.chkIPTV.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkIPTV.ForeColor = System.Drawing.Color.Black;
            this.chkIPTV.Location = new System.Drawing.Point(141, 96);
            this.chkIPTV.Name = "chkIPTV";
            this.chkIPTV.Size = new System.Drawing.Size(76, 27);
            this.chkIPTV.TabIndex = 2;
            this.chkIPTV.Text = "IP TV";
            this.chkIPTV.UseVisualStyleBackColor = true;
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.chkInternet.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkInternet.ForeColor = System.Drawing.Color.Black;
            this.chkInternet.Location = new System.Drawing.Point(19, 96);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(96, 27);
            this.chkInternet.TabIndex = 2;
            this.chkInternet.Text = "Internet";
            this.chkInternet.UseVisualStyleBackColor = false;
            // 
            // chkIBoard
            // 
            this.chkIBoard.AutoSize = true;
            this.chkIBoard.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkIBoard.ForeColor = System.Drawing.Color.Black;
            this.chkIBoard.Location = new System.Drawing.Point(19, 58);
            this.chkIBoard.Name = "chkIBoard";
            this.chkIBoard.Size = new System.Drawing.Size(89, 27);
            this.chkIBoard.TabIndex = 2;
            this.chkIBoard.Text = "I Board";
            this.chkIBoard.UseVisualStyleBackColor = true;
            // 
            // chkProjection
            // 
            this.chkProjection.AutoSize = true;
            this.chkProjection.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkProjection.ForeColor = System.Drawing.Color.Black;
            this.chkProjection.Location = new System.Drawing.Point(19, 19);
            this.chkProjection.Name = "chkProjection";
            this.chkProjection.Size = new System.Drawing.Size(105, 27);
            this.chkProjection.TabIndex = 2;
            this.chkProjection.Text = "Projection";
            this.chkProjection.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Capacity :";
            // 
            // nudRoomCapacity
            // 
            this.nudRoomCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.nudRoomCapacity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudRoomCapacity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nudRoomCapacity.Location = new System.Drawing.Point(196, 155);
            this.nudRoomCapacity.Name = "nudRoomCapacity";
            this.nudRoomCapacity.Size = new System.Drawing.Size(74, 26);
            this.nudRoomCapacity.TabIndex = 0;
            // 
            // chkAirCond
            // 
            this.chkAirCond.AutoSize = true;
            this.chkAirCond.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAirCond.ForeColor = System.Drawing.Color.Black;
            this.chkAirCond.Location = new System.Drawing.Point(141, 57);
            this.chkAirCond.Name = "chkAirCond";
            this.chkAirCond.Size = new System.Drawing.Size(148, 27);
            this.chkAirCond.TabIndex = 2;
            this.chkAirCond.Text = "Air Conditioning";
            this.chkAirCond.UseVisualStyleBackColor = true;
            // 
            // cbxMeetRoom
            // 
            this.cbxMeetRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.cbxMeetRoom.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMeetRoom.FormattingEnabled = true;
            this.cbxMeetRoom.Location = new System.Drawing.Point(153, 66);
            this.cbxMeetRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxMeetRoom.Name = "cbxMeetRoom";
            this.cbxMeetRoom.Size = new System.Drawing.Size(191, 27);
            this.cbxMeetRoom.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Meet Rooms :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(384, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 49);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(203, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "MEET ROOMS";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(173)))), ((int)(((byte)(169)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(476, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(21, 15);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(384, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 49);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(384, 119);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(107, 49);
            this.btnList.TabIndex = 16;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // gbxRoomSpec
            // 
            this.gbxRoomSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.gbxRoomSpec.Controls.Add(this.chkAirCond);
            this.gbxRoomSpec.Controls.Add(this.chkProjection);
            this.gbxRoomSpec.Controls.Add(this.chkIBoard);
            this.gbxRoomSpec.Controls.Add(this.chkVOIP);
            this.gbxRoomSpec.Controls.Add(this.chkInternet);
            this.gbxRoomSpec.Controls.Add(this.chkIPTV);
            this.gbxRoomSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbxRoomSpec.Location = new System.Drawing.Point(12, 193);
            this.gbxRoomSpec.Name = "gbxRoomSpec";
            this.gbxRoomSpec.Size = new System.Drawing.Size(332, 143);
            this.gbxRoomSpec.TabIndex = 17;
            this.gbxRoomSpec.TabStop = false;
            this.gbxRoomSpec.Text = "Room Specs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(108, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Room Features";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(-9, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(522, 10);
            this.label5.TabIndex = 19;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MeetRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(503, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbxRoomSpec);
            this.Controls.Add(this.nudRoomCapacity);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.cbxMeetRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeetRoomForm";
            this.Load += new System.EventHandler(this.MeetRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomCapacity)).EndInit();
            this.gbxRoomSpec.ResumeLayout(false);
            this.gbxRoomSpec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.CheckBox chkVOIP;
        private System.Windows.Forms.CheckBox chkIPTV;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.CheckBox chkIBoard;
        private System.Windows.Forms.CheckBox chkProjection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRoomCapacity;
        private System.Windows.Forms.ComboBox cbxMeetRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.CheckBox chkAirCond;
        private System.Windows.Forms.GroupBox gbxRoomSpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}