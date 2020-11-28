namespace WindowsFormsApp2
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Birthday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Firstname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signup);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.Birthday);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.Firstname);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 318);
            this.panel1.TabIndex = 0;
            // 
            // signup
            // 
            this.signup.ActiveBorderThickness = 1;
            this.signup.ActiveCornerRadius = 1;
            this.signup.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.signup.ActiveForecolor = System.Drawing.Color.White;
            this.signup.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.signup.BackColor = System.Drawing.SystemColors.Control;
            this.signup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup.BackgroundImage")));
            this.signup.ButtonText = "Save";
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.SeaGreen;
            this.signup.IdleBorderThickness = 1;
            this.signup.IdleCornerRadius = 1;
            this.signup.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.signup.IdleForecolor = System.Drawing.Color.White;
            this.signup.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signup.Location = new System.Drawing.Point(174, 279);
            this.signup.Margin = new System.Windows.Forms.Padding(5);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(79, 34);
            this.signup.TabIndex = 64;
            this.signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // Birthday
            // 
            this.Birthday.BackColor = System.Drawing.Color.SeaGreen;
            this.Birthday.BorderRadius = 0;
            this.Birthday.ForeColor = System.Drawing.Color.White;
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Birthday.FormatCustom = null;
            this.Birthday.Location = new System.Drawing.Point(28, 103);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(275, 36);
            this.Birthday.TabIndex = 60;
            this.Birthday.UseWaitCursor = true;
            this.Birthday.Value = new System.DateTime(2020, 4, 13, 15, 18, 44, 204);
            // 
            // Password
            // 
            this.Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Password.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.Password.BorderThickness = 1;
            this.Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.Black;
            this.Password.isPassword = false;
            this.Password.Location = new System.Drawing.Point(28, 225);
            this.Password.Margin = new System.Windows.Forms.Padding(0);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(331, 34);
            this.Password.TabIndex = 58;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Email
            // 
            this.Email.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Email.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.Email.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.Email.BorderThickness = 1;
            this.Email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.isPassword = false;
            this.Email.Location = new System.Drawing.Point(28, 171);
            this.Email.Margin = new System.Windows.Forms.Padding(0);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(331, 34);
            this.Email.TabIndex = 54;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Firstname
            // 
            this.Firstname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Firstname.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.Firstname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.Firstname.BorderThickness = 1;
            this.Firstname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Firstname.ForeColor = System.Drawing.Color.Black;
            this.Firstname.isPassword = false;
            this.Firstname.Location = new System.Drawing.Point(28, 27);
            this.Firstname.Margin = new System.Windows.Forms.Padding(0);
            this.Firstname.MaxLength = 32767;
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(266, 34);
            this.Firstname.TabIndex = 52;
            this.Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 118);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(468, 75);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 25);
            this.UpdateButton.TabIndex = 30;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.panel3.Controls.Add(this.female);
            this.panel3.Controls.Add(this.male);
            this.panel3.Location = new System.Drawing.Point(313, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 33);
            this.panel3.TabIndex = 63;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.female.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.female.Location = new System.Drawing.Point(97, 11);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(59, 17);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.male.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.male.Location = new System.Drawing.Point(14, 13);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(48, 17);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel7.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(310, 83);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel7.TabIndex = 62;
            this.bunifuCustomLabel7.Text = "Gender";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel6.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(25, 83);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(59, 17);
            this.bunifuCustomLabel6.TabIndex = 61;
            this.bunifuCustomLabel6.Text = "Birthday";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel5.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(25, 208);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel5.TabIndex = 59;
            this.bunifuCustomLabel5.Text = "Password";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel3.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(25, 154);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(43, 17);
            this.bunifuCustomLabel3.TabIndex = 55;
            this.bunifuCustomLabel3.Text = "Email";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel2.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(34, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel2.TabIndex = 53;
            this.bunifuCustomLabel2.Text = " Name ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(619, 318);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 318);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox Email;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Firstname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 signup;
        public Bunifu.Framework.UI.BunifuDatepicker Birthday;
    }
}