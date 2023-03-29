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
            this.dgwMeetRoom = new System.Windows.Forms.DataGridView();
            this.btnRequest = new System.Windows.Forms.Button();
            this.chckbVOIP = new System.Windows.Forms.CheckBox();
            this.chckbIPTV = new System.Windows.Forms.CheckBox();
            this.chckbInternet = new System.Windows.Forms.CheckBox();
            this.chckbIBoard = new System.Windows.Forms.CheckBox();
            this.chckbProjection = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRoomCapacity = new System.Windows.Forms.NumericUpDown();
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.cbxMeetRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.odaListeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonİstekleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isteklerimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniİstekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toplantıOdalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeetRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomCapacity)).BeginInit();
            this.grpProperty.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMeetRoom
            // 
            this.dgwMeetRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMeetRoom.Location = new System.Drawing.Point(12, 302);
            this.dgwMeetRoom.Name = "dgwMeetRoom";
            this.dgwMeetRoom.Size = new System.Drawing.Size(289, 148);
            this.dgwMeetRoom.TabIndex = 14;
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRequest.Location = new System.Drawing.Point(344, 342);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(101, 54);
            this.btnRequest.TabIndex = 12;
            this.btnRequest.Text = "Rezervasyon İsteği";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click_1);
            // 
            // chckbVOIP
            // 
            this.chckbVOIP.AutoSize = true;
            this.chckbVOIP.Location = new System.Drawing.Point(39, 177);
            this.chckbVOIP.Name = "chckbVOIP";
            this.chckbVOIP.Size = new System.Drawing.Size(61, 23);
            this.chckbVOIP.TabIndex = 2;
            this.chckbVOIP.Text = "VOIP";
            this.chckbVOIP.UseVisualStyleBackColor = true;
            // 
            // chckbIPTV
            // 
            this.chckbIPTV.AutoSize = true;
            this.chckbIPTV.Location = new System.Drawing.Point(39, 148);
            this.chckbIPTV.Name = "chckbIPTV";
            this.chckbIPTV.Size = new System.Drawing.Size(68, 23);
            this.chckbIPTV.TabIndex = 2;
            this.chckbIPTV.Text = "IP-TV";
            this.chckbIPTV.UseVisualStyleBackColor = true;
            // 
            // chckbInternet
            // 
            this.chckbInternet.AutoSize = true;
            this.chckbInternet.Location = new System.Drawing.Point(39, 119);
            this.chckbInternet.Name = "chckbInternet";
            this.chckbInternet.Size = new System.Drawing.Size(81, 23);
            this.chckbInternet.TabIndex = 2;
            this.chckbInternet.Text = "Internet";
            this.chckbInternet.UseVisualStyleBackColor = true;
            // 
            // chckbIBoard
            // 
            this.chckbIBoard.AutoSize = true;
            this.chckbIBoard.Location = new System.Drawing.Point(39, 90);
            this.chckbIBoard.Name = "chckbIBoard";
            this.chckbIBoard.Size = new System.Drawing.Size(79, 23);
            this.chckbIBoard.TabIndex = 2;
            this.chckbIBoard.Text = "I-Board";
            this.chckbIBoard.UseVisualStyleBackColor = true;
            // 
            // chckbProjection
            // 
            this.chckbProjection.AutoSize = true;
            this.chckbProjection.Location = new System.Drawing.Point(39, 61);
            this.chckbProjection.Name = "chckbProjection";
            this.chckbProjection.Size = new System.Drawing.Size(98, 23);
            this.chckbProjection.TabIndex = 2;
            this.chckbProjection.Text = "Projeksiyon";
            this.chckbProjection.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kapasite :";
            // 
            // nudRoomCapacity
            // 
            this.nudRoomCapacity.Location = new System.Drawing.Point(103, 29);
            this.nudRoomCapacity.Name = "nudRoomCapacity";
            this.nudRoomCapacity.Size = new System.Drawing.Size(49, 26);
            this.nudRoomCapacity.TabIndex = 0;
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.chckbVOIP);
            this.grpProperty.Controls.Add(this.chckbIPTV);
            this.grpProperty.Controls.Add(this.chckbInternet);
            this.grpProperty.Controls.Add(this.chckbIBoard);
            this.grpProperty.Controls.Add(this.chckbProjection);
            this.grpProperty.Controls.Add(this.label3);
            this.grpProperty.Controls.Add(this.nudRoomCapacity);
            this.grpProperty.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpProperty.Location = new System.Drawing.Point(308, 125);
            this.grpProperty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpProperty.Size = new System.Drawing.Size(157, 211);
            this.grpProperty.TabIndex = 11;
            this.grpProperty.TabStop = false;
            this.grpProperty.Text = "Özellikler";
            // 
            // cbxMeetRoom
            // 
            this.cbxMeetRoom.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxMeetRoom.FormattingEnabled = true;
            this.cbxMeetRoom.Location = new System.Drawing.Point(161, 125);
            this.cbxMeetRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxMeetRoom.Name = "cbxMeetRoom";
            this.cbxMeetRoom.Size = new System.Drawing.Size(118, 27);
            this.cbxMeetRoom.TabIndex = 8;
            this.cbxMeetRoom.SelectedIndexChanged += new System.EventHandler(this.cbxMeetRoom_SelectedIndexChanged);
            this.cbxMeetRoom.SelectedValueChanged += new System.EventHandler(this.cbxMeetRoom_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Toplantı Odası :";
            // 
            // logKayıtlarıToolStripMenuItem
            // 
            this.logKayıtlarıToolStripMenuItem.Name = "logKayıtlarıToolStripMenuItem";
            this.logKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.logKayıtlarıToolStripMenuItem.Text = "Log Kayıtları";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(509, 417);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
            // 
            // odaListeToolStripMenuItem
            // 
            this.odaListeToolStripMenuItem.Name = "odaListeToolStripMenuItem";
            this.odaListeToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.odaListeToolStripMenuItem.Text = "Oda Listesi";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaListeToolStripMenuItem,
            this.toolStripSeparator3,
            this.rezervasyonİstekleriToolStripMenuItem,
            this.toolStripSeparator4,
            this.logKayıtlarıToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // rezervasyonİstekleriToolStripMenuItem
            // 
            this.rezervasyonİstekleriToolStripMenuItem.Name = "rezervasyonİstekleriToolStripMenuItem";
            this.rezervasyonİstekleriToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.rezervasyonİstekleriToolStripMenuItem.Text = "Rezervasyon İstekleri";
            // 
            // isteklerimToolStripMenuItem
            // 
            this.isteklerimToolStripMenuItem.Name = "isteklerimToolStripMenuItem";
            this.isteklerimToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.isteklerimToolStripMenuItem.Text = "İsteklerim";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // yeniİstekToolStripMenuItem
            // 
            this.yeniİstekToolStripMenuItem.Name = "yeniİstekToolStripMenuItem";
            this.yeniİstekToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.yeniİstekToolStripMenuItem.Text = "Yeni İstek";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toplantıOdalarıToolStripMenuItem
            // 
            this.toplantıOdalarıToolStripMenuItem.Name = "toplantıOdalarıToolStripMenuItem";
            this.toplantıOdalarıToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.toplantıOdalarıToolStripMenuItem.Text = "Toplantı Odaları";
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplantıOdalarıToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniİstekToolStripMenuItem,
            this.toolStripSeparator2,
            this.isteklerimToolStripMenuItem});
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.rezervasyonToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(634, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "TOPLANTI ODALARI";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(472, 186);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 154);
            this.checkedListBox1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(509, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(187, 158);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(75, 33);
            this.btnGetir.TabIndex = 16;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // MeetRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dgwMeetRoom);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.grpProperty);
            this.Controls.Add(this.cbxMeetRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeetRoomForm";
            this.Load += new System.EventHandler(this.MeetRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMeetRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomCapacity)).EndInit();
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMeetRoom;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.CheckBox chckbVOIP;
        private System.Windows.Forms.CheckBox chckbIPTV;
        private System.Windows.Forms.CheckBox chckbInternet;
        private System.Windows.Forms.CheckBox chckbIBoard;
        private System.Windows.Forms.CheckBox chckbProjection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRoomCapacity;
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.ComboBox cbxMeetRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem logKayıtlarıToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem odaListeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonİstekleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isteklerimToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem yeniİstekToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toplantıOdalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetir;
    }
}