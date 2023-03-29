namespace TORES.Wf
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtTORES = new System.Windows.Forms.TextBox();
            this.btnExıt = new System.Windows.Forms.Button();
            this.btnSıgnIn = new System.Windows.Forms.Button();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTORES
            // 
            this.txtTORES.BackColor = System.Drawing.Color.LightGray;
            this.txtTORES.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTORES.Location = new System.Drawing.Point(0, -1);
            this.txtTORES.Name = "txtTORES";
            this.txtTORES.Size = new System.Drawing.Size(516, 24);
            this.txtTORES.TabIndex = 24;
            this.txtTORES.Text = "TORES v1.0";
            // 
            // btnExıt
            // 
            this.btnExıt.BackColor = System.Drawing.Color.Turquoise;
            this.btnExıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExıt.Location = new System.Drawing.Point(293, 310);
            this.btnExıt.Name = "btnExıt";
            this.btnExıt.Size = new System.Drawing.Size(86, 30);
            this.btnExıt.TabIndex = 4;
            this.btnExıt.Text = "Exıt";
            this.btnExıt.UseVisualStyleBackColor = false;
            this.btnExıt.Click += new System.EventHandler(this.btnExıt_Click_1);
            // 
            // btnSıgnIn
            // 
            this.btnSıgnIn.BackColor = System.Drawing.Color.Turquoise;
            this.btnSıgnIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSıgnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıgnIn.Location = new System.Drawing.Point(150, 310);
            this.btnSıgnIn.Name = "btnSıgnIn";
            this.btnSıgnIn.Size = new System.Drawing.Size(86, 30);
            this.btnSıgnIn.TabIndex = 3;
            this.btnSıgnIn.Text = "Sign In";
            this.btnSıgnIn.UseVisualStyleBackColor = false;
            this.btnSıgnIn.Click += new System.EventHandler(this.btnSıgnIn_Click_1);
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.Color.White;
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserPass.Location = new System.Drawing.Point(218, 249);
            this.txtUserPass.MaxLength = 10;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(144, 26);
            this.txtUserPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(218, 217);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(104, 252);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 20);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(92, 217);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(108, 20);
            this.lblUserID.TabIndex = 16;
            this.lblUserID.Text = "User Name :";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 377);
            this.Controls.Add(this.txtTORES);
            this.Controls.Add(this.btnExıt);
            this.Controls.Add(this.btnSıgnIn);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "li,n";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTORES;
        private System.Windows.Forms.Button btnExıt;
        private System.Windows.Forms.Button btnSıgnIn;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
    }
}