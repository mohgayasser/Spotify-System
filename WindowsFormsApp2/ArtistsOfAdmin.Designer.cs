namespace WindowsFormsApp2
{
    partial class ArtistsOfAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.trackssearch = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Users
            // 
            this.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_Users.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Users.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Users.Location = new System.Drawing.Point(0, 45);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.Size = new System.Drawing.Size(642, 279);
            this.dgv_Users.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.trackssearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 45);
            this.panel1.TabIndex = 10;
            // 
            // search
            // 
            this.search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.search.BackColor = System.Drawing.SystemColors.ControlText;
            this.search.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.HintForeColor = System.Drawing.Color.Transparent;
            this.search.HintText = "";
            this.search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search.isPassword = false;
            this.search.LineFocusedColor = System.Drawing.Color.LavenderBlush;
            this.search.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.search.LineMouseHoverColor = System.Drawing.Color.LavenderBlush;
            this.search.LineThickness = 3;
            this.search.Location = new System.Drawing.Point(65, 4);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.MaxLength = 32767;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(494, 30);
            this.search.TabIndex = 7;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // trackssearch
            // 
            this.trackssearch.FlatAppearance.BorderSize = 0;
            this.trackssearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trackssearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.trackssearch.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.trackssearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.trackssearch.IconColor = System.Drawing.Color.SeaGreen;
            this.trackssearch.IconSize = 30;
            this.trackssearch.Location = new System.Drawing.Point(12, 4);
            this.trackssearch.Name = "trackssearch";
            this.trackssearch.Rotation = 0D;
            this.trackssearch.Size = new System.Drawing.Size(58, 30);
            this.trackssearch.TabIndex = 6;
            this.trackssearch.UseVisualStyleBackColor = true;
            this.trackssearch.Click += new System.EventHandler(this.trackssearch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuThinButton22);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 44);
            this.panel2.TabIndex = 12;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 1;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton22.ButtonText = "Save";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 1;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.Location = new System.Drawing.Point(512, 0);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(130, 44);
            this.bunifuThinButton22.TabIndex = 2;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.ca46e126dfd4fcb68d8d3dfb349ab711;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ArtistsOfAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 368);
            this.Controls.Add(this.dgv_Users);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ArtistsOfAdmin";
            this.Text = "ArtistsOfAdmin";
            this.Load += new System.EventHandler(this.ArtistsOfAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search;
        private FontAwesome.Sharp.IconButton trackssearch;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}