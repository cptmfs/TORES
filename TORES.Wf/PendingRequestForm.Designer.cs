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
            this.dgwApproved = new System.Windows.Forms.DataGridView();
            this.dgwRejected = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwApproved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRejected)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwApproved
            // 
            this.dgwApproved.AllowUserToAddRows = false;
            this.dgwApproved.AllowUserToDeleteRows = false;
            this.dgwApproved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwApproved.Location = new System.Drawing.Point(12, 12);
            this.dgwApproved.Name = "dgwApproved";
            this.dgwApproved.ReadOnly = true;
            this.dgwApproved.RowHeadersVisible = false;
            this.dgwApproved.RowHeadersWidth = 45;
            this.dgwApproved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwApproved.Size = new System.Drawing.Size(629, 150);
            this.dgwApproved.TabIndex = 0;
            // 
            // dgwRejected
            // 
            this.dgwRejected.AllowUserToAddRows = false;
            this.dgwRejected.AllowUserToDeleteRows = false;
            this.dgwRejected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRejected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRejected.Location = new System.Drawing.Point(12, 198);
            this.dgwRejected.Name = "dgwRejected";
            this.dgwRejected.ReadOnly = true;
            this.dgwRejected.RowHeadersVisible = false;
            this.dgwRejected.RowHeadersWidth = 45;
            this.dgwRejected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwRejected.Size = new System.Drawing.Size(629, 150);
            this.dgwRejected.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(30, 411);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(174, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // PendingRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 453);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgwRejected);
            this.Controls.Add(this.dgwApproved);
            this.Name = "PendingRequestForm";
            this.Text = "PendingRequestForm";
            this.Load += new System.EventHandler(this.PendingRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwApproved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRejected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwApproved;
        private System.Windows.Forms.DataGridView dgwRejected;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
    }
}