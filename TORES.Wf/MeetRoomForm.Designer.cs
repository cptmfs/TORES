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
            this.chckbVOIP = new System.Windows.Forms.CheckBox();
            this.chckbIPTV = new System.Windows.Forms.CheckBox();
            this.chckbInternet = new System.Windows.Forms.CheckBox();
            this.chckbIBoard = new System.Windows.Forms.CheckBox();
            this.chckbProjection = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRoomCapacity = new System.Windows.Forms.NumericUpDown();
            this.chckbKlima = new System.Windows.Forms.CheckBox();
            this.cbxMeetRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.gbxRoomSpec = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudRoomCapacity)).BeginInit();
            this.gbxRoomSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeetRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRequest.Location = new System.Drawing.Point(100, 317);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(107, 49);
            this.btnRequest.TabIndex = 12;
            this.btnRequest.Text = "Rezervasyon İsteği";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click_1);
            // 
            // chckbVOIP
            // 
            this.chckbVOIP.AutoSize = true;
            this.chckbVOIP.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbVOIP.ForeColor = System.Drawing.Color.Black;
            this.chckbVOIP.Location = new System.Drawing.Point(21, 113);
            this.chckbVOIP.Name = "chckbVOIP";
            this.chckbVOIP.Size = new System.Drawing.Size(61, 23);
            this.chckbVOIP.TabIndex = 2;
            this.chckbVOIP.Text = "VOIP";
            this.chckbVOIP.UseVisualStyleBackColor = true;
            this.chckbVOIP.CheckedChanged += new System.EventHandler(this.chckbVOIP_CheckedChanged);
            // 
            // chckbIPTV
            // 
            this.chckbIPTV.AutoSize = true;
            this.chckbIPTV.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbIPTV.ForeColor = System.Drawing.Color.Black;
            this.chckbIPTV.Location = new System.Drawing.Point(21, 90);
            this.chckbIPTV.Name = "chckbIPTV";
            this.chckbIPTV.Size = new System.Drawing.Size(68, 23);
            this.chckbIPTV.TabIndex = 2;
            this.chckbIPTV.Text = "IP-TV";
            this.chckbIPTV.UseVisualStyleBackColor = true;
            this.chckbIPTV.CheckedChanged += new System.EventHandler(this.chckbIPTV_CheckedChanged);
            // 
            // chckbInternet
            // 
            this.chckbInternet.AutoSize = true;
            this.chckbInternet.BackColor = System.Drawing.Color.Lavender;
            this.chckbInternet.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbInternet.ForeColor = System.Drawing.Color.Black;
            this.chckbInternet.Location = new System.Drawing.Point(21, 64);
            this.chckbInternet.Name = "chckbInternet";
            this.chckbInternet.Size = new System.Drawing.Size(81, 23);
            this.chckbInternet.TabIndex = 2;
            this.chckbInternet.Text = "Internet";
            this.chckbInternet.UseVisualStyleBackColor = false;
            this.chckbInternet.CheckedChanged += new System.EventHandler(this.chckbInternet_CheckedChanged);
            // 
            // chckbIBoard
            // 
            this.chckbIBoard.AutoSize = true;
            this.chckbIBoard.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbIBoard.ForeColor = System.Drawing.Color.Black;
            this.chckbIBoard.Location = new System.Drawing.Point(21, 37);
            this.chckbIBoard.Name = "chckbIBoard";
            this.chckbIBoard.Size = new System.Drawing.Size(79, 23);
            this.chckbIBoard.TabIndex = 2;
            this.chckbIBoard.Text = "I-Board";
            this.chckbIBoard.UseVisualStyleBackColor = true;
            this.chckbIBoard.CheckedChanged += new System.EventHandler(this.chckbIBoard_CheckedChanged);
            // 
            // chckbProjection
            // 
            this.chckbProjection.AutoSize = true;
            this.chckbProjection.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbProjection.ForeColor = System.Drawing.Color.Black;
            this.chckbProjection.Location = new System.Drawing.Point(21, 13);
            this.chckbProjection.Name = "chckbProjection";
            this.chckbProjection.Size = new System.Drawing.Size(98, 23);
            this.chckbProjection.TabIndex = 2;
            this.chckbProjection.Text = "Projeksiyon";
            this.chckbProjection.UseVisualStyleBackColor = true;
            this.chckbProjection.CheckedChanged += new System.EventHandler(this.chckbProjection_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(318, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kapasite :";
            // 
            // nudRoomCapacity
            // 
            this.nudRoomCapacity.BackColor = System.Drawing.Color.AliceBlue;
            this.nudRoomCapacity.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudRoomCapacity.Location = new System.Drawing.Point(396, 108);
            this.nudRoomCapacity.Name = "nudRoomCapacity";
            this.nudRoomCapacity.Size = new System.Drawing.Size(63, 26);

            this.nudRoomCapacity.TabIndex = 0;
            // 
            // chckbKlima
            // 
            this.chckbKlima.AutoSize = true;
            this.chckbKlima.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckbKlima.ForeColor = System.Drawing.Color.Black;
            this.chckbKlima.Location = new System.Drawing.Point(21, 139);
            this.chckbKlima.Name = "chckbKlima";
            this.chckbKlima.Size = new System.Drawing.Size(61, 23);
            this.chckbKlima.TabIndex = 2;
            this.chckbKlima.Text = "Klima";
            this.chckbKlima.UseVisualStyleBackColor = true;
            this.chckbKlima.CheckedChanged += new System.EventHandler(this.chckbKlima_CheckedChanged);
            // 
            // cbxMeetRoom
            // 
            this.cbxMeetRoom.BackColor = System.Drawing.Color.AliceBlue;
            this.cbxMeetRoom.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMeetRoom.FormattingEnabled = true;
            this.cbxMeetRoom.Location = new System.Drawing.Point(139, 107);
            this.cbxMeetRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxMeetRoom.Name = "cbxMeetRoom";
            this.cbxMeetRoom.Size = new System.Drawing.Size(161, 27);
            this.cbxMeetRoom.TabIndex = 8;
            this.cbxMeetRoom.SelectedIndexChanged += new System.EventHandler(this.cbxMeetRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Toplantı Odası :";
            // 

            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(314, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 49);

            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 

            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(160, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOPLANTI ODALARI";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Lavender;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(476, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(21, 15);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(205, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 49);

            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(164, 143);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(97, 33);
            this.btnGetir.TabIndex = 16;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // gbxRoomSpec
            // 
            this.gbxRoomSpec.BackColor = System.Drawing.Color.Lavender;
            this.gbxRoomSpec.Controls.Add(this.chckbKlima);
            this.gbxRoomSpec.Controls.Add(this.chckbProjection);
            this.gbxRoomSpec.Controls.Add(this.chckbIBoard);
            this.gbxRoomSpec.Controls.Add(this.chckbVOIP);
            this.gbxRoomSpec.Controls.Add(this.chckbInternet);
            this.gbxRoomSpec.Controls.Add(this.chckbIPTV);
            this.gbxRoomSpec.Location = new System.Drawing.Point(340, 140);
            this.gbxRoomSpec.Name = "gbxRoomSpec";
            this.gbxRoomSpec.Size = new System.Drawing.Size(119, 170);
            this.gbxRoomSpec.TabIndex = 17;
            this.gbxRoomSpec.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(357, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "ÖZELLİKLER";
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
            // dgwMeetRoom
            // 
            this.dgwMeetRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMeetRoom.Location = new System.Drawing.Point(12, 302);
            this.dgwMeetRoom.Name = "dgwMeetRoom";
            this.dgwMeetRoom.RowHeadersWidth = 45;
            this.dgwMeetRoom.Size = new System.Drawing.Size(289, 148);
            this.dgwMeetRoom.TabIndex = 14;
            // 
            // MeetRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);

            this.Controls.Add(this.gbxRoomSpec);
            this.Controls.Add(this.nudRoomCapacity);
            this.Controls.Add(this.btnGetir);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeetRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.CheckBox chckbVOIP;
        private System.Windows.Forms.CheckBox chckbIPTV;
        private System.Windows.Forms.CheckBox chckbInternet;
        private System.Windows.Forms.CheckBox chckbIBoard;
        private System.Windows.Forms.CheckBox chckbProjection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRoomCapacity;
        private System.Windows.Forms.ComboBox cbxMeetRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.CheckBox chckbKlima;
        private System.Windows.Forms.GroupBox gbxRoomSpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}