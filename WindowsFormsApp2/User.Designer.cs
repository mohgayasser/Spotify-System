namespace WindowsFormsApp2
{
    partial class User
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
            FontAwesome.Sharp.IconButton settings;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            FontAwesome.Sharp.IconButton Search;
            FontAwesome.Sharp.IconButton userplaylists;
            FontAwesome.Sharp.IconButton userartists;
            FontAwesome.Sharp.IconButton usersongs;
            FontAwesome.Sharp.IconButton Library;
            this.panelsidemenu = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelplaylist = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Repeat = new FontAwesome.Sharp.IconButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Liked = new FontAwesome.Sharp.IconButton();
            this.shuffle = new FontAwesome.Sharp.IconButton();
            this.nextsong = new FontAwesome.Sharp.IconButton();
            this.lastsong = new FontAwesome.Sharp.IconButton();
            this.Play = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelchildform = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.Titalforchildform = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CurrentchildFormIcon = new FontAwesome.Sharp.IconButton();
            settings = new FontAwesome.Sharp.IconButton();
            Search = new FontAwesome.Sharp.IconButton();
            userplaylists = new FontAwesome.Sharp.IconButton();
            userartists = new FontAwesome.Sharp.IconButton();
            usersongs = new FontAwesome.Sharp.IconButton();
            Library = new FontAwesome.Sharp.IconButton();
            this.panelsidemenu.SuspendLayout();
            this.panelplaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelchildform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
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
            settings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            settings.IconColor = System.Drawing.Color.White;
            settings.IconSize = 18;
            settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            settings.Location = new System.Drawing.Point(0, 310);
            settings.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            settings.Name = "settings";
            settings.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            settings.Rotation = 0D;
            settings.Size = new System.Drawing.Size(165, 41);
            settings.TabIndex = 9;
            settings.Text = "Settings";
            settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            settings.UseVisualStyleBackColor = true;
            settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // Search
            // 
            Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
            Search.Dock = System.Windows.Forms.DockStyle.Top;
            Search.FlatAppearance.BorderSize = 0;
            Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            Search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Search.ForeColor = System.Drawing.Color.Silver;
            Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            Search.IconColor = System.Drawing.Color.White;
            Search.IconSize = 18;
            Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Search.Location = new System.Drawing.Point(0, 269);
            Search.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            Search.Name = "Search";
            Search.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            Search.Rotation = 0D;
            Search.Size = new System.Drawing.Size(165, 41);
            Search.TabIndex = 8;
            Search.Text = "search";
            Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Search.UseVisualStyleBackColor = true;
            Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // userplaylists
            // 
            userplaylists.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            userplaylists.Dock = System.Windows.Forms.DockStyle.Top;
            userplaylists.FlatAppearance.BorderSize = 0;
            userplaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            userplaylists.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            userplaylists.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userplaylists.ForeColor = System.Drawing.Color.Silver;
            userplaylists.IconChar = FontAwesome.Sharp.IconChar.PenFancy;
            userplaylists.IconColor = System.Drawing.Color.White;
            userplaylists.IconSize = 18;
            userplaylists.Location = new System.Drawing.Point(0, 82);
            userplaylists.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            userplaylists.Name = "userplaylists";
            userplaylists.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            userplaylists.Rotation = 0D;
            userplaylists.Size = new System.Drawing.Size(165, 41);
            userplaylists.TabIndex = 5;
            userplaylists.Text = " My Playlists";
            userplaylists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            userplaylists.UseVisualStyleBackColor = true;
            userplaylists.Click += new System.EventHandler(this.userplaylists_Click);
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
            userartists.Location = new System.Drawing.Point(0, 41);
            userartists.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            userartists.Name = "userartists";
            userartists.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            userartists.Rotation = 0D;
            userartists.Size = new System.Drawing.Size(165, 41);
            userartists.TabIndex = 4;
            userartists.Text = "Liked Artists";
            userartists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            userartists.UseVisualStyleBackColor = true;
            userartists.Click += new System.EventHandler(this.userartists_Click);
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
            usersongs.Location = new System.Drawing.Point(0, 0);
            usersongs.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            usersongs.Name = "usersongs";
            usersongs.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            usersongs.Rotation = 0D;
            usersongs.Size = new System.Drawing.Size(165, 41);
            usersongs.TabIndex = 2;
            usersongs.Text = "Liked Tracks";
            usersongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            usersongs.UseVisualStyleBackColor = true;
            usersongs.Click += new System.EventHandler(this.usersongs_Click);
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
            Library.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Library.Location = new System.Drawing.Point(0, 94);
            Library.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            Library.Name = "Library";
            Library.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            Library.Rotation = 0D;
            Library.Size = new System.Drawing.Size(165, 41);
            Library.TabIndex = 6;
            Library.Text = "Library";
            Library.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            Library.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Library.UseVisualStyleBackColor = true;
            Library.Click += new System.EventHandler(this.Library_Click);
            // 
            // panelsidemenu
            // 
            this.panelsidemenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelsidemenu.Controls.Add(settings);
            this.panelsidemenu.Controls.Add(this.iconButton2);
            this.panelsidemenu.Controls.Add(Search);
            this.panelsidemenu.Controls.Add(this.panelplaylist);
            this.panelsidemenu.Controls.Add(Library);
            this.panelsidemenu.Controls.Add(this.panelLogo);
            this.panelsidemenu.Controls.Add(this.pictureBox1);
            this.panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelsidemenu.Name = "panelsidemenu";
            this.panelsidemenu.Size = new System.Drawing.Size(165, 510);
            this.panelsidemenu.TabIndex = 0;
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
            this.iconButton2.Location = new System.Drawing.Point(0, 476);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(165, 34);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Exit";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panelplaylist
            // 
            this.panelplaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelplaylist.BackgroundImage")));
            this.panelplaylist.Controls.Add(userplaylists);
            this.panelplaylist.Controls.Add(userartists);
            this.panelplaylist.Controls.Add(usersongs);
            this.panelplaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelplaylist.Location = new System.Drawing.Point(0, 135);
            this.panelplaylist.Name = "panelplaylist";
            this.panelplaylist.Size = new System.Drawing.Size(165, 134);
            this.panelplaylist.TabIndex = 7;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(165, 94);
            this.panelLogo.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Repeat);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.Liked);
            this.panel1.Controls.Add(this.shuffle);
            this.panel1.Controls.Add(this.nextsong);
            this.panel1.Controls.Add(this.lastsong);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(165, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 100);
            this.panel1.TabIndex = 1;
            // 
            // Repeat
            // 
            this.Repeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Repeat.BackgroundImage")));
            this.Repeat.FlatAppearance.BorderSize = 0;
            this.Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repeat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Repeat.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.Repeat.IconColor = System.Drawing.Color.White;
            this.Repeat.IconSize = 30;
            this.Repeat.Location = new System.Drawing.Point(110, 48);
            this.Repeat.Name = "Repeat";
            this.Repeat.Rotation = 0D;
            this.Repeat.Size = new System.Drawing.Size(75, 35);
            this.Repeat.TabIndex = 13;
            this.Repeat.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(264, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 13);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            // 
            // Liked
            // 
            this.Liked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Liked.BackgroundImage")));
            this.Liked.FlatAppearance.BorderSize = 0;
            this.Liked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Liked.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Liked.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.Liked.IconColor = System.Drawing.Color.White;
            this.Liked.IconSize = 30;
            this.Liked.Location = new System.Drawing.Point(499, 48);
            this.Liked.Name = "Liked";
            this.Liked.Rotation = 0D;
            this.Liked.Size = new System.Drawing.Size(75, 35);
            this.Liked.TabIndex = 11;
            this.Liked.UseVisualStyleBackColor = true;
            this.Liked.Click += new System.EventHandler(this.Liked_Click);
            // 
            // shuffle
            // 
            this.shuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shuffle.BackgroundImage")));
            this.shuffle.FlatAppearance.BorderSize = 0;
            this.shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.shuffle.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.shuffle.IconColor = System.Drawing.Color.White;
            this.shuffle.IconSize = 30;
            this.shuffle.Location = new System.Drawing.Point(41, 48);
            this.shuffle.Name = "shuffle";
            this.shuffle.Rotation = 0D;
            this.shuffle.Size = new System.Drawing.Size(75, 35);
            this.shuffle.TabIndex = 10;
            this.shuffle.UseVisualStyleBackColor = true;
            // 
            // nextsong
            // 
            this.nextsong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextsong.BackgroundImage")));
            this.nextsong.FlatAppearance.BorderSize = 0;
            this.nextsong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextsong.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.nextsong.IconChar = FontAwesome.Sharp.IconChar.StepForward;
            this.nextsong.IconColor = System.Drawing.Color.White;
            this.nextsong.IconSize = 30;
            this.nextsong.Location = new System.Drawing.Point(373, 48);
            this.nextsong.Name = "nextsong";
            this.nextsong.Rotation = 0D;
            this.nextsong.Size = new System.Drawing.Size(75, 35);
            this.nextsong.TabIndex = 9;
            this.nextsong.UseVisualStyleBackColor = true;
            this.nextsong.Click += new System.EventHandler(this.nextsong_Click_1);
            // 
            // lastsong
            // 
            this.lastsong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lastsong.BackgroundImage")));
            this.lastsong.FlatAppearance.BorderSize = 0;
            this.lastsong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastsong.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.lastsong.IconChar = FontAwesome.Sharp.IconChar.StepBackward;
            this.lastsong.IconColor = System.Drawing.Color.White;
            this.lastsong.IconSize = 30;
            this.lastsong.Location = new System.Drawing.Point(202, 48);
            this.lastsong.Name = "lastsong";
            this.lastsong.Rotation = 0D;
            this.lastsong.Size = new System.Drawing.Size(75, 35);
            this.lastsong.TabIndex = 8;
            this.lastsong.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Play.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.Play.IconColor = System.Drawing.Color.White;
            this.Play.IconSize = 30;
            this.Play.Location = new System.Drawing.Point(292, 48);
            this.Play.Name = "Play";
            this.Play.Rotation = 0D;
            this.Play.Size = new System.Drawing.Size(75, 35);
            this.Play.TabIndex = 7;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(635, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelchildform
            // 
            this.panelchildform.Controls.Add(this.pictureBox3);
            this.panelchildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchildform.Location = new System.Drawing.Point(165, 53);
            this.panelchildform.Name = "panelchildform";
            this.panelchildform.Size = new System.Drawing.Size(635, 357);
            this.panelchildform.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(635, 357);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.Titalforchildform);
            this.header.Controls.Add(this.CurrentchildFormIcon);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(165, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(635, 53);
            this.header.TabIndex = 2;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
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
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panelchildform);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelsidemenu);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.panelsidemenu.ResumeLayout(false);
            this.panelplaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelchildform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsidemenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelplaylist;
        private System.Windows.Forms.FlowLayoutPanel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Repeat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private FontAwesome.Sharp.IconButton Liked;
        private FontAwesome.Sharp.IconButton shuffle;
        private FontAwesome.Sharp.IconButton nextsong;
        private FontAwesome.Sharp.IconButton lastsong;
        private FontAwesome.Sharp.IconButton Play;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel header;
        private FontAwesome.Sharp.IconButton CurrentchildFormIcon;
        private Bunifu.Framework.UI.BunifuCustomLabel Titalforchildform;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panelchildform;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}