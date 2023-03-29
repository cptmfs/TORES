namespace TORES.Wf
{
    partial class LogDataForm
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
            this.dgwLog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLog
            // 
            this.dgwLog.AllowUserToAddRows = false;
            this.dgwLog.AllowUserToDeleteRows = false;
            this.dgwLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLog.Location = new System.Drawing.Point(12, 35);
            this.dgwLog.Name = "dgwLog";
            this.dgwLog.ReadOnly = true;
            this.dgwLog.RowHeadersVisible = false;
            this.dgwLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwLog.Size = new System.Drawing.Size(760, 274);
            this.dgwLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI GİRİŞ/ÇIKIŞ KAYITLARI";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(32, 315);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(222, 41);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Kayıtları Göster";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(279, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(214, 41);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Kayıt Sil";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(512, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 41);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Tümünü Temizle";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(767, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LogDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(880, 392);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_Data_Form";
            this.Load += new System.EventHandler(this.LogDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}