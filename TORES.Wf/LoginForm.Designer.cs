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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTORES = new System.Windows.Forms.TextBox();
            this.btnExıt = new System.Windows.Forms.Button();
            this.btnSıgnIn = new System.Windows.Forms.Button();
            this.lblBenıHatırla = new System.Windows.Forms.Label();
            this.chckHatırla = new System.Windows.Forms.CheckBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblRezervasyon = new System.Windows.Forms.Label();
            this.lblToplantı = new System.Windows.Forms.Label();
            this.lblNovas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(-2, 362);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(516, 24);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "NOVAS WORKS - TOPLANTI ODALARI REZERVASYON SİSTEMİ";
            // 
            // txtTORES
            // 
            this.txtTORES.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTORES.Location = new System.Drawing.Point(-2, -1);
            this.txtTORES.Name = "txtTORES";
            this.txtTORES.Size = new System.Drawing.Size(516, 26);
            this.txtTORES.TabIndex = 24;
            this.txtTORES.Text = "TORES v1.0";
            // 
            // btnExıt
            // 
            this.btnExıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExıt.Location = new System.Drawing.Point(308, 310);
            this.btnExıt.Name = "btnExıt";
            this.btnExıt.Size = new System.Drawing.Size(86, 30);
            this.btnExıt.TabIndex = 4;
            this.btnExıt.Text = "Exıt";
            this.btnExıt.UseVisualStyleBackColor = true;
            this.btnExıt.Click += new System.EventHandler(this.btnExıt_Click_1);
            // 
            // btnSıgnIn
            // 
            this.btnSıgnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıgnIn.Location = new System.Drawing.Point(150, 310);
            this.btnSıgnIn.Name = "btnSıgnIn";
            this.btnSıgnIn.Size = new System.Drawing.Size(86, 30);
            this.btnSıgnIn.TabIndex = 3;
            this.btnSıgnIn.Text = "Sign In";
            this.btnSıgnIn.UseVisualStyleBackColor = true;
            this.btnSıgnIn.Click += new System.EventHandler(this.btnSıgnIn_Click_1);
            // 
            // lblBenıHatırla
            // 
            this.lblBenıHatırla.AutoSize = true;
            this.lblBenıHatırla.BackColor = System.Drawing.Color.Transparent;
            this.lblBenıHatırla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBenıHatırla.Location = new System.Drawing.Point(329, 257);
            this.lblBenıHatırla.Name = "lblBenıHatırla";
            this.lblBenıHatırla.Size = new System.Drawing.Size(103, 22);
            this.lblBenıHatırla.TabIndex = 21;
            this.lblBenıHatırla.Text = "Beni Hatırla";
            // 
            // chckHatırla
            // 
            this.chckHatırla.AutoSize = true;
            this.chckHatırla.Location = new System.Drawing.Point(308, 262);
            this.chckHatırla.Name = "chckHatırla";
            this.chckHatırla.Size = new System.Drawing.Size(15, 14);
            this.chckHatırla.TabIndex = 20;
            this.chckHatırla.UseVisualStyleBackColor = true;
            // 
            // txtUserPass
            // 
            this.txtUserPass.BackColor = System.Drawing.Color.White;
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserPass.Location = new System.Drawing.Point(223, 207);
            this.txtUserPass.MaxLength = 10;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(144, 27);
            this.txtUserPass.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(223, 163);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(109, 210);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 22);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Password :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserID.Location = new System.Drawing.Point(107, 163);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(110, 22);
            this.lblUserID.TabIndex = 16;
            this.lblUserID.Text = "User Name :";
            // 
            // lblRezervasyon
            // 
            this.lblRezervasyon.AutoSize = true;
            this.lblRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.lblRezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRezervasyon.Location = new System.Drawing.Point(146, 95);
            this.lblRezervasyon.Name = "lblRezervasyon";
            this.lblRezervasyon.Size = new System.Drawing.Size(221, 22);
            this.lblRezervasyon.TabIndex = 15;
            this.lblRezervasyon.Text = "REZERVASYON SİSTEMİ";
            // 
            // lblToplantı
            // 
            this.lblToplantı.AutoSize = true;
            this.lblToplantı.BackColor = System.Drawing.Color.Transparent;
            this.lblToplantı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplantı.Location = new System.Drawing.Point(166, 61);
            this.lblToplantı.Name = "lblToplantı";
            this.lblToplantı.Size = new System.Drawing.Size(182, 22);
            this.lblToplantı.TabIndex = 14;
            this.lblToplantı.Text = "TOPLANTI ODALARI";
            // 
            // lblNovas
            // 
            this.lblNovas.AutoSize = true;
            this.lblNovas.BackColor = System.Drawing.Color.Transparent;
            this.lblNovas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNovas.Location = new System.Drawing.Point(175, 28);
            this.lblNovas.Name = "lblNovas";
            this.lblNovas.Size = new System.Drawing.Size(146, 22);
            this.lblNovas.TabIndex = 13;
            this.lblNovas.Text = "NOVAS WORKS";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 386);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTORES);
            this.Controls.Add(this.btnExıt);
            this.Controls.Add(this.btnSıgnIn);
            this.Controls.Add(this.lblBenıHatırla);
            this.Controls.Add(this.chckHatırla);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblRezervasyon);
            this.Controls.Add(this.lblToplantı);
            this.Controls.Add(this.lblNovas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtTORES;
        private System.Windows.Forms.Button btnExıt;
        private System.Windows.Forms.Button btnSıgnIn;
        private System.Windows.Forms.Label lblBenıHatırla;
        private System.Windows.Forms.CheckBox chckHatırla;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblRezervasyon;
        private System.Windows.Forms.Label lblToplantı;
        private System.Windows.Forms.Label lblNovas;
    }
}