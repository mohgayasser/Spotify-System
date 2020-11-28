namespace WindowsFormsApp2
{
    partial class Admin
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
            FontAwesome.Sharp.IconButton iconButton3;
            FontAwesome.Sharp.IconButton iconButton1;
            FontAwesome.Sharp.IconButton userartists;
            FontAwesome.Sharp.IconButton Library;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            FontAwesome.Sharp.IconButton usersongs;
            FontAwesome.Sharp.IconButton settings;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.Titalforchildform = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CurrentchildFormIcon = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            userartists = new FontAwesome.Sharp.IconButton();
            Library = new FontAwesome.Sharp.IconButton();
            usersongs = new FontAwesome.Sharp.IconButton();
            settings = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(iconButton3);
            this.panel1.Controls.Add(iconButton1);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(userartists);
            this.panel1.Controls.Add(Library);
            this.panel1.Controls.Add(usersongs);
            this.panel1.Controls.Add(settings);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(142, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 407);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(142, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 43);
            this.panel2.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.Titalforchildform);
            this.header.Controls.Add(this.CurrentchildFormIcon);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(658, 43);
            this.header.TabIndex = 4;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown_1);
            // 
            // Titalforchildform
            // 
            this.Titalforchildform.AutoSize = true;
            this.Titalforchildform.ForeColor = System.Drawing.Color.Silver;
            this.Titalforchildform.Location = new System.Drawing.Point(59, 19);
            this.Titalforchildform.Name = "Titalforchildform";
            this.Titalforchildform.Size = new System.Drawing.Size(35, 13);
            this.Titalforchildform.TabIndex = 2;
            this.Titalforchildform.Text = "Home";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(658, 407);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // CurrentchildFormIcon
            // 
            this.CurrentchildFormIcon.FlatAppearance.BorderSize = 0;
            this.CurrentchildFormIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentchildFormIcon.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CurrentchildFormIcon.ForeColor = System.Drawing.Color.Coral;
            this.CurrentchildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.CurrentchildFormIcon.IconColor = System.Drawing.Color.Silver;
            this.CurrentchildFormIcon.IconSize = 26;
            this.CurrentchildFormIcon.Location = new System.Drawing.Point(0, 11);
            this.CurrentchildFormIcon.Name = "CurrentchildFormIcon";
            this.CurrentchildFormIcon.Rotation = 0D;
            this.CurrentchildFormIcon.Size = new System.Drawing.Size(53, 29);
            this.CurrentchildFormIcon.TabIndex = 0;
            this.CurrentchildFormIcon.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconButton3.ForeColor = System.Drawing.Color.Silver;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Film;
            iconButton3.IconColor = System.Drawing.Color.White;
            iconButton3.IconSize = 18;
            iconButton3.Location = new System.Drawing.Point(0, 299);
            iconButton3.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            iconButton3.Rotation = 0D;
            iconButton3.Size = new System.Drawing.Size(142, 41);
            iconButton3.TabIndex = 21;
            iconButton3.Text = "Reports";
            iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconButton1.ForeColor = System.Drawing.Color.Silver;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Th;
            iconButton1.IconColor = System.Drawing.Color.White;
            iconButton1.IconSize = 18;
            iconButton1.Location = new System.Drawing.Point(0, 258);
            iconButton1.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            iconButton1.Rotation = 0D;
            iconButton1.Size = new System.Drawing.Size(142, 41);
            iconButton1.TabIndex = 20;
            iconButton1.Text = "PlayLists";
            iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.ForeColor = System.Drawing.Color.Silver;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.iconButton2.IconColor = System.Drawing.Color.Silver;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(0, 416);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(142, 34);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "Exit";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // userartists
            // 
            userartists.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            userartists.Dock = System.Windows.Forms.DockStyle.Top;
            userartists.FlatAppearance.BorderSize = 0;
            userartists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            userartists.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            userartists.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userartists.ForeColor = System.Drawing.Color.Silver;
            userartists.IconChar = FontAwesome.Sharp.IconChar.User;
            userartists.IconColor = System.Drawing.Color.White;
            userartists.IconSize = 18;
            userartists.Location = new System.Drawing.Point(0, 217);
            userartists.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            userartists.Name = "userartists";
            userartists.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            userartists.Rotation = 0D;
            userartists.Size = new System.Drawing.Size(142, 41);
            userartists.TabIndex = 14;
            userartists.Text = " Artists";
            userartists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            userartists.UseVisualStyleBackColor = true;
            userartists.Click += new System.EventHandler(this.userartists_Click);
            // 
            // Library
            // 
            Library.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Library.BackgroundImage")));
            Library.Dock = System.Windows.Forms.DockStyle.Top;
            Library.FlatAppearance.BorderSize = 0;
            Library.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Library.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            Library.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Library.ForeColor = System.Drawing.Color.Silver;
            Library.IconChar = FontAwesome.Sharp.IconChar.List;
            Library.IconColor = System.Drawing.Color.White;
            Library.IconSize = 18;
            Library.Location = new System.Drawing.Point(0, 176);
            Library.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            Library.Name = "Library";
            Library.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            Library.Rotation = 0D;
            Library.Size = new System.Drawing.Size(142, 41);
            Library.TabIndex = 17;
            Library.Text = "Albums";
            Library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Library.UseVisualStyleBackColor = true;
            Library.Click += new System.EventHandler(this.Library_Click);
            // 
            // usersongs
            // 
            usersongs.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            usersongs.Dock = System.Windows.Forms.DockStyle.Top;
            usersongs.FlatAppearance.BorderSize = 0;
            usersongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            usersongs.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            usersongs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usersongs.ForeColor = System.Drawing.Color.Silver;
            usersongs.IconChar = FontAwesome.Sharp.IconChar.Music;
            usersongs.IconColor = System.Drawing.Color.White;
            usersongs.IconSize = 18;
            usersongs.Location = new System.Drawing.Point(0, 135);
            usersongs.Name = "usersongs";
            usersongs.Rotation = 0D;
            usersongs.Size = new System.Drawing.Size(142, 41);
            usersongs.TabIndex = 12;
            usersongs.Text = "Tracks";
            usersongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            usersongs.UseVisualStyleBackColor = true;
            usersongs.Click += new System.EventHandler(this.usersongs_Click);
            // 
            // settings
            // 
            settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings.BackgroundImage")));
            settings.Dock = System.Windows.Forms.DockStyle.Top;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            settings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            settings.ForeColor = System.Drawing.Color.Silver;
            settings.IconChar = FontAwesome.Sharp.IconChar.User;
            settings.IconColor = System.Drawing.Color.White;
            settings.IconSize = 18;
            settings.Location = new System.Drawing.Point(0, 94);
            settings.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            settings.Name = "settings";
            settings.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            settings.Rotation = 0D;
            settings.Size = new System.Drawing.Size(142, 41);
            settings.TabIndex = 19;
            settings.Text = "Users";
            settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            settings.UseVisualStyleBackColor = true;
            settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(142, 94);
            this.panelLogo.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Admin_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.FlowLayoutPanel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel Titalforchildform;
        private FontAwesome.Sharp.IconButton CurrentchildFormIcon;
    }
}