namespace WindowsFormsApp2
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.invalidPass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.invalidmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signinPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signinemail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Existemail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Birthday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Firstname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuThinButton21.ButtonText = "Sign Up";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.Location = new System.Drawing.Point(103, 37);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(117, 34);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 1;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuThinButton22.ButtonText = "Sign In";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 1;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.Location = new System.Drawing.Point(230, 37);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(118, 34);
            this.bunifuThinButton22.TabIndex = 0;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(103, 69);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(119, 10);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // iconButton1
            // 
            this.iconButton1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuTransition1.SetDecoration(this.iconButton1, BunifuAnimatorNS.DecorationType.None);
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.Beige;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(415, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(38, 33);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.invalidPass);
            this.panel1.Controls.Add(this.invalidmail);
            this.panel1.Controls.Add(this.signin);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.signinPass);
            this.panel1.Controls.Add(this.bunifuCustomLabel12);
            this.panel1.Controls.Add(this.signinemail);
            this.panel1.Controls.Add(this.bunifuCustomLabel14);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(460, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 465);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 465);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // invalidPass
            // 
            this.invalidPass.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.invalidPass, BunifuAnimatorNS.DecorationType.None);
            this.invalidPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidPass.ForeColor = System.Drawing.Color.Red;
            this.invalidPass.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.invalidPass.Location = new System.Drawing.Point(21, 265);
            this.invalidPass.Name = "invalidPass";
            this.invalidPass.Size = new System.Drawing.Size(116, 17);
            this.invalidPass.TabIndex = 62;
            this.invalidPass.Text = "Invalid Password";
            this.invalidPass.Visible = false;
            // 
            // invalidmail
            // 
            this.invalidmail.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.invalidmail, BunifuAnimatorNS.DecorationType.None);
            this.invalidmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidmail.ForeColor = System.Drawing.Color.Red;
            this.invalidmail.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.invalidmail.Location = new System.Drawing.Point(21, 194);
            this.invalidmail.Name = "invalidmail";
            this.invalidmail.Size = new System.Drawing.Size(90, 17);
            this.invalidmail.TabIndex = 61;
            this.invalidmail.Text = "Invalid Email";
            this.invalidmail.Visible = false;
            // 
            // signin
            // 
            this.signin.ActiveBorderThickness = 1;
            this.signin.ActiveCornerRadius = 1;
            this.signin.ActiveFillColor = System.Drawing.SystemColors.ActiveBorder;
            this.signin.ActiveForecolor = System.Drawing.Color.White;
            this.signin.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.signin.BackColor = System.Drawing.Color.Black;
            this.signin.ButtonText = "Sign In";
            this.signin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.signin, BunifuAnimatorNS.DecorationType.None);
            this.signin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.SeaGreen;
            this.signin.IdleBorderThickness = 1;
            this.signin.IdleCornerRadius = 1;
            this.signin.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.signin.IdleForecolor = System.Drawing.Color.White;
            this.signin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signin.Location = new System.Drawing.Point(71, 420);
            this.signin.Margin = new System.Windows.Forms.Padding(5);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(245, 45);
            this.signin.TabIndex = 60;
            this.signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel10.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(21, 212);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel10.TabIndex = 59;
            this.bunifuCustomLabel10.Text = "Password";
            // 
            // signinPass
            // 
            this.signinPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.signinPass.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.signinPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.signinPass.BorderThickness = 1;
            this.signinPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.signinPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.signinPass, BunifuAnimatorNS.DecorationType.None);
            this.signinPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.signinPass.ForeColor = System.Drawing.Color.DarkGray;
            this.signinPass.isPassword = true;
            this.signinPass.Location = new System.Drawing.Point(24, 229);
            this.signinPass.Margin = new System.Windows.Forms.Padding(0);
            this.signinPass.MaxLength = 32767;
            this.signinPass.Name = "signinPass";
            this.signinPass.Size = new System.Drawing.Size(331, 34);
            this.signinPass.TabIndex = 58;
            this.signinPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel12.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(21, 143);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(43, 17);
            this.bunifuCustomLabel12.TabIndex = 57;
            this.bunifuCustomLabel12.Text = "Email";
            // 
            // signinemail
            // 
            this.signinemail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.signinemail.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.signinemail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.signinemail.BorderThickness = 1;
            this.signinemail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.signinemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.signinemail, BunifuAnimatorNS.DecorationType.None);
            this.signinemail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.signinemail.ForeColor = System.Drawing.Color.DarkGray;
            this.signinemail.isPassword = false;
            this.signinemail.Location = new System.Drawing.Point(24, 160);
            this.signinemail.Margin = new System.Windows.Forms.Padding(0);
            this.signinemail.MaxLength = 32767;
            this.signinemail.Name = "signinemail";
            this.signinemail.Size = new System.Drawing.Size(331, 34);
            this.signinemail.TabIndex = 56;
            this.signinemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel14, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel14.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(142, 15);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(90, 30);
            this.bunifuCustomLabel14.TabIndex = 55;
            this.bunifuCustomLabel14.Text = "Sign In";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Existemail);
            this.panel2.Controls.Add(this.signup);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.Birthday);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.LastName);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.Firstname);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(38, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 465);
            this.panel2.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(386, 465);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Existemail
            // 
            this.Existemail.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.Existemail, BunifuAnimatorNS.DecorationType.None);
            this.Existemail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existemail.ForeColor = System.Drawing.Color.Red;
            this.Existemail.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.Existemail.Location = new System.Drawing.Point(26, 321);
            this.Existemail.Name = "Existemail";
            this.Existemail.Size = new System.Drawing.Size(162, 17);
            this.Existemail.TabIndex = 52;
            this.Existemail.Text = "this Email is Already Exist";
            this.Existemail.Visible = false;
            // 
            // signup
            // 
            this.signup.ActiveBorderThickness = 1;
            this.signup.ActiveCornerRadius = 1;
            this.signup.ActiveFillColor = System.Drawing.SystemColors.AppWorkspace;
            this.signup.ActiveForecolor = System.Drawing.Color.White;
            this.signup.ActiveLineColor = System.Drawing.SystemColors.AppWorkspace;
            this.signup.BackColor = System.Drawing.Color.Black;
            this.signup.ButtonText = "Sign Up";
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.signup, BunifuAnimatorNS.DecorationType.None);
            this.signup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.SeaGreen;
            this.signup.IdleBorderThickness = 1;
            this.signup.IdleCornerRadius = 1;
            this.signup.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.signup.IdleForecolor = System.Drawing.Color.White;
            this.signup.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.signup.Location = new System.Drawing.Point(65, 420);
            this.signup.Margin = new System.Windows.Forms.Padding(5);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(245, 45);
            this.signup.TabIndex = 51;
            this.signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signup.Click += new System.EventHandler(this.signup_Click_2);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.panel3.Controls.Add(this.female);
            this.panel3.Controls.Add(this.male);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(29, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 33);
            this.panel3.TabIndex = 50;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuTransition1.SetDecoration(this.female, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuTransition1.SetDecoration(this.male, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel7.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(26, 208);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(56, 17);
            this.bunifuCustomLabel7.TabIndex = 49;
            this.bunifuCustomLabel7.Text = "Gender";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel6.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(26, 131);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(59, 17);
            this.bunifuCustomLabel6.TabIndex = 48;
            this.bunifuCustomLabel6.Text = "Birthday";
            // 
            // Birthday
            // 
            this.Birthday.BackColor = System.Drawing.Color.SeaGreen;
            this.Birthday.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.Birthday, BunifuAnimatorNS.DecorationType.None);
            this.Birthday.ForeColor = System.Drawing.Color.White;
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Birthday.FormatCustom = null;
            this.Birthday.Location = new System.Drawing.Point(29, 151);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(331, 36);
            this.Birthday.TabIndex = 47;
            this.Birthday.Value = new System.DateTime(2020, 4, 13, 15, 18, 44, 204);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel5.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(26, 338);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel5.TabIndex = 46;
            this.bunifuCustomLabel5.Text = "Password";
            // 
            // Password
            // 
            this.Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Password.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.Password.BorderThickness = 1;
            this.Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Password, BunifuAnimatorNS.DecorationType.None);
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.DarkGray;
            this.Password.isPassword = true;
            this.Password.Location = new System.Drawing.Point(29, 355);
            this.Password.Margin = new System.Windows.Forms.Padding(0);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(331, 34);
            this.Password.TabIndex = 45;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel4.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(192, 58);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 17);
            this.bunifuCustomLabel4.TabIndex = 44;
            this.bunifuCustomLabel4.Text = "Last Name ";
            // 
            // LastName
            // 
            this.LastName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.LastName.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.LastName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.LastName.BorderThickness = 1;
            this.LastName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.LastName, BunifuAnimatorNS.DecorationType.None);
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LastName.ForeColor = System.Drawing.Color.DarkGray;
            this.LastName.isPassword = false;
            this.LastName.Location = new System.Drawing.Point(195, 75);
            this.LastName.Margin = new System.Windows.Forms.Padding(0);
            this.LastName.MaxLength = 32767;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(165, 34);
            this.LastName.TabIndex = 43;
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel3.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 269);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(43, 17);
            this.bunifuCustomLabel3.TabIndex = 42;
            this.bunifuCustomLabel3.Text = "Email";
            // 
            // Email
            // 
            this.Email.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Email.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.Email.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.Email.BorderThickness = 1;
            this.Email.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Email, BunifuAnimatorNS.DecorationType.None);
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Email.ForeColor = System.Drawing.Color.DarkGray;
            this.Email.isPassword = false;
            this.Email.Location = new System.Drawing.Point(29, 286);
            this.Email.Margin = new System.Windows.Forms.Padding(0);
            this.Email.MaxLength = 32767;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(331, 34);
            this.Email.TabIndex = 41;
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel2.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(26, 58);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(79, 17);
            this.bunifuCustomLabel2.TabIndex = 40;
            this.bunifuCustomLabel2.Text = "First Name ";
            // 
            // Firstname
            // 
            this.Firstname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.Firstname.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.Firstname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(116)))));
            this.Firstname.BorderThickness = 1;
            this.Firstname.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.Firstname, BunifuAnimatorNS.DecorationType.None);
            this.Firstname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Firstname.ForeColor = System.Drawing.Color.DarkGray;
            this.Firstname.isPassword = false;
            this.Firstname.Location = new System.Drawing.Point(29, 75);
            this.Firstname.Margin = new System.Windows.Forms.Padding(0);
            this.Firstname.MaxLength = 32767;
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(154, 34);
            this.Firstname.TabIndex = 39;
            this.Firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel1.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(91, 15);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(201, 30);
            this.bunifuCustomLabel1.TabIndex = 38;
            this.bunifuCustomLabel1.Text = "Sign Up For Free";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 579);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuThinButton22);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel invalidPass;
        private Bunifu.Framework.UI.BunifuCustomLabel invalidmail;
        private Bunifu.Framework.UI.BunifuThinButton2 signin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMetroTextbox signinPass;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMetroTextbox signinemail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel Existemail;
        private Bunifu.Framework.UI.BunifuThinButton2 signup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDatepicker Birthday;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox LastName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox Email;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Firstname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

