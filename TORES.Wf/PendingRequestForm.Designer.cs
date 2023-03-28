namespace TORES.Wf
{
    partial class PendingRequestForm
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
            this.dgwOnayVerilen = new System.Windows.Forms.DataGridView();
            this.dgwOnayBekleyen = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOnayVerilen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOnayBekleyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOnayVerilen
            // 
            this.dgwOnayVerilen.AllowUserToAddRows = false;
            this.dgwOnayVerilen.AllowUserToDeleteRows = false;
            this.dgwOnayVerilen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOnayVerilen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOnayVerilen.Location = new System.Drawing.Point(16, 227);
            this.dgwOnayVerilen.Name = "dgwOnayVerilen";
            this.dgwOnayVerilen.ReadOnly = true;
            this.dgwOnayVerilen.RowHeadersVisible = false;
            this.dgwOnayVerilen.RowHeadersWidth = 45;
            this.dgwOnayVerilen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwOnayVerilen.Size = new System.Drawing.Size(629, 150);
            this.dgwOnayVerilen.TabIndex = 0;
            // 
            // dgwOnayBekleyen
            // 
            this.dgwOnayBekleyen.AllowUserToAddRows = false;
            this.dgwOnayBekleyen.AllowUserToDeleteRows = false;
            this.dgwOnayBekleyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOnayBekleyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOnayBekleyen.Location = new System.Drawing.Point(16, 40);
            this.dgwOnayBekleyen.Name = "dgwOnayBekleyen";
            this.dgwOnayBekleyen.ReadOnly = true;
            this.dgwOnayBekleyen.RowHeadersVisible = false;
            this.dgwOnayBekleyen.RowHeadersWidth = 45;
            this.dgwOnayBekleyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwOnayBekleyen.Size = new System.Drawing.Size(629, 150);
            this.dgwOnayBekleyen.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(12, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOnayla.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(106, 404);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(88, 40);
            this.btnOnayla.TabIndex = 3;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Onay Bekleyenler  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Onay Verilenler ";
            // 
            // PendingRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 456);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgwOnayBekleyen);
            this.Controls.Add(this.dgwOnayVerilen);
            this.Name = "PendingRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PendingRequestForm";
            this.Load += new System.EventHandler(this.PendingRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOnayVerilen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOnayBekleyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOnayVerilen;
        private System.Windows.Forms.DataGridView dgwOnayBekleyen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}