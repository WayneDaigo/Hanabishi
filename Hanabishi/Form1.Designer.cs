namespace Hanabishi
{
    partial class frmHanabishi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHanabishi));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.picHanabishiLoginLogo = new System.Windows.Forms.PictureBox();
            this.btnShowpassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picBg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDevelop = new System.Windows.Forms.Label();
            this.lblDeveloped = new System.Windows.Forms.Label();
            this.lblUsing = new System.Windows.Forms.Label();
            this.lblUsingProgram = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblMethodsOfpayment = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblHanabishi = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHanabishiLoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUsername.Location = new System.Drawing.Point(43, 209);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(140, 22);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Enter Username";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPassword.Location = new System.Drawing.Point(43, 287);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(137, 22);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Enter Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(47, 243);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(451, 32);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(47, 321);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(451, 32);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // grpLogin
            // 
            this.grpLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLogin.BackColor = System.Drawing.SystemColors.Window;
            this.grpLogin.Controls.Add(this.picHanabishiLoginLogo);
            this.grpLogin.Controls.Add(this.btnShowpassword);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.label1);
            this.grpLogin.Controls.Add(this.lblWelcome);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpLogin.Location = new System.Drawing.Point(404, 132);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(568, 473);
            this.grpLogin.TabIndex = 4;
            this.grpLogin.TabStop = false;
            this.grpLogin.Enter += new System.EventHandler(this.grpLogin_Enter);
            // 
            // picHanabishiLoginLogo
            // 
            this.picHanabishiLoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("picHanabishiLoginLogo.Image")));
            this.picHanabishiLoginLogo.Location = new System.Drawing.Point(197, 21);
            this.picHanabishiLoginLogo.Name = "picHanabishiLoginLogo";
            this.picHanabishiLoginLogo.Size = new System.Drawing.Size(170, 50);
            this.picHanabishiLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHanabishiLoginLogo.TabIndex = 10;
            this.picHanabishiLoginLogo.TabStop = false;
            // 
            // btnShowpassword
            // 
            this.btnShowpassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowpassword.Image")));
            this.btnShowpassword.Location = new System.Drawing.Point(462, 321);
            this.btnShowpassword.Name = "btnShowpassword";
            this.btnShowpassword.Size = new System.Drawing.Size(36, 32);
            this.btnShowpassword.TabIndex = 9;
            this.btnShowpassword.UseVisualStyleBackColor = true;
            this.btnShowpassword.Click += new System.EventHandler(this.btnShowpassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(47, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(451, 39);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Hanabishi\'s POS System  where seamless transactions \r\nmeet quality app" +
    "liances for a better shopping experience!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(205, 74);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(149, 38);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBg
            // 
            this.picBg.Image = ((System.Drawing.Image)(resources.GetObject("picBg.Image")));
            this.picBg.Location = new System.Drawing.Point(-9, 63);
            this.picBg.Name = "picBg";
            this.picBg.Size = new System.Drawing.Size(1339, 616);
            this.picBg.TabIndex = 5;
            this.picBg.TabStop = false;
            this.picBg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblDevelop
            // 
            this.lblDevelop.AutoSize = true;
            this.lblDevelop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelop.Location = new System.Drawing.Point(112, 696);
            this.lblDevelop.Name = "lblDevelop";
            this.lblDevelop.Size = new System.Drawing.Size(134, 18);
            this.lblDevelop.TabIndex = 7;
            this.lblDevelop.Text = "DEVELOPED BY";
            this.lblDevelop.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDeveloped
            // 
            this.lblDeveloped.AutoSize = true;
            this.lblDeveloped.Location = new System.Drawing.Point(99, 727);
            this.lblDeveloped.Name = "lblDeveloped";
            this.lblDeveloped.Size = new System.Drawing.Size(161, 48);
            this.lblDeveloped.TabIndex = 8;
            this.lblDeveloped.Text = "JUSTINE CASIANO\r\nWAYNE YSRAEL ELADO\r\nANGELA MAE CABRERA";
            // 
            // lblUsing
            // 
            this.lblUsing.AutoSize = true;
            this.lblUsing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsing.Location = new System.Drawing.Point(391, 696);
            this.lblUsing.Name = "lblUsing";
            this.lblUsing.Size = new System.Drawing.Size(60, 18);
            this.lblUsing.TabIndex = 9;
            this.lblUsing.Text = "USING";
            // 
            // lblUsingProgram
            // 
            this.lblUsingProgram.AutoSize = true;
            this.lblUsingProgram.Location = new System.Drawing.Point(367, 727);
            this.lblUsingProgram.Name = "lblUsingProgram";
            this.lblUsingProgram.Size = new System.Drawing.Size(108, 48);
            this.lblUsingProgram.TabIndex = 10;
            this.lblUsingProgram.Text = "VISUAL STUDIO\r\nMYSQL\r\nXAMPP";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(624, 696);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(163, 18);
            this.lblPaymentMethod.TabIndex = 11;
            this.lblPaymentMethod.Text = "PAYMENT METHOD";
            this.lblPaymentMethod.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblMethodsOfpayment
            // 
            this.lblMethodsOfpayment.AutoSize = true;
            this.lblMethodsOfpayment.Location = new System.Drawing.Point(634, 727);
            this.lblMethodsOfpayment.Name = "lblMethodsOfpayment";
            this.lblMethodsOfpayment.Size = new System.Drawing.Size(98, 48);
            this.lblMethodsOfpayment.TabIndex = 12;
            this.lblMethodsOfpayment.Text = "CASH\r\nE-WALLET\r\nCREDIT CARD";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(1030, 696);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(64, 18);
            this.lblAbout.TabIndex = 13;
            this.lblAbout.Text = "ABOUT\r\n";
            this.lblAbout.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // lblHanabishi
            // 
            this.lblHanabishi.AutoSize = true;
            this.lblHanabishi.Location = new System.Drawing.Point(906, 727);
            this.lblHanabishi.Name = "lblHanabishi";
            this.lblHanabishi.Size = new System.Drawing.Size(322, 112);
            this.lblHanabishi.TabIndex = 14;
            this.lblHanabishi.Text = resources.GetString("lblHanabishi.Text");
            this.lblHanabishi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHanabishi.Click += new System.EventHandler(this.lblHanabishi_Click);
            // 
            // frmHanabishi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 936);
            this.Controls.Add(this.lblHanabishi);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblMethodsOfpayment);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblUsingProgram);
            this.Controls.Add(this.lblUsing);
            this.Controls.Add(this.lblDeveloped);
            this.Controls.Add(this.lblDevelop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.picBg);
            this.Name = "frmHanabishi";
            this.Text = "Hanabishi POS";
            this.Load += new System.EventHandler(this.frmHanabishi_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHanabishiLoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picBg;
        private System.Windows.Forms.Button btnShowpassword;
        private System.Windows.Forms.PictureBox picHanabishiLoginLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDevelop;
        private System.Windows.Forms.Label lblDeveloped;
        private System.Windows.Forms.Label lblUsing;
        private System.Windows.Forms.Label lblUsingProgram;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblMethodsOfpayment;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblHanabishi;
    }
}

