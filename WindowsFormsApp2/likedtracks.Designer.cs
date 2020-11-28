namespace WindowsFormsApp2
{
    partial class likedtracks
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackssearch = new FontAwesome.Sharp.IconButton();
            this.search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(619, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trackssearch
            // 
            this.trackssearch.FlatAppearance.BorderSize = 0;
            this.trackssearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trackssearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.trackssearch.ForeColor = System.Drawing.Color.Cornsilk;
            this.trackssearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.trackssearch.IconColor = System.Drawing.Color.Black;
            this.trackssearch.IconSize = 20;
            this.trackssearch.Location = new System.Drawing.Point(12, 4);
            this.trackssearch.Name = "trackssearch";
            this.trackssearch.Rotation = 0D;
            this.trackssearch.Size = new System.Drawing.Size(58, 30);
            this.trackssearch.TabIndex = 6;
            this.trackssearch.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.search.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.HintForeColor = System.Drawing.Color.Empty;
            this.search.HintText = "";
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.isPassword = false;
            this.search.LineFocusedColor = System.Drawing.Color.Blue;
            this.search.LineIdleColor = System.Drawing.Color.Gray;
            this.search.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.search.LineThickness = 3;
            this.search.Location = new System.Drawing.Point(65, 4);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.MaxLength = 32767;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(379, 30);
            this.search.TabIndex = 7;
            this.search.Text = "Track";
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.trackssearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 45);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 279);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // likedtracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(619, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "likedtracks";
            this.Text = "likedtracks";
            this.Load += new System.EventHandler(this.likedtracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton trackssearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}