namespace WindowsFormsApp2
{
    partial class Rrp1
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
            FontAwesome.Sharp.IconButton iconButton1;
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.songDuration = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Song_type = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(iconButton1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.songDuration);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Song_type);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 82);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(289, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Song Duration";
            // 
            // songDuration
            // 
            this.songDuration.FormattingEnabled = true;
            this.songDuration.Location = new System.Drawing.Point(370, 12);
            this.songDuration.Name = "songDuration";
            this.songDuration.Size = new System.Drawing.Size(171, 21);
            this.songDuration.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Song Type";
            // 
            // Song_type
            // 
            this.Song_type.FormattingEnabled = true;
            this.Song_type.Location = new System.Drawing.Point(100, 17);
            this.Song_type.Name = "Song_type";
            this.Song_type.Size = new System.Drawing.Size(171, 21);
            this.Song_type.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 243);
            this.panel1.TabIndex = 3;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(626, 243);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iconButton1.ForeColor = System.Drawing.Color.Silver;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = System.Drawing.Color.White;
            iconButton1.IconSize = 18;
            iconButton1.Location = new System.Drawing.Point(230, 48);
            iconButton1.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            iconButton1.Rotation = 0D;
            iconButton1.Size = new System.Drawing.Size(158, 28);
            iconButton1.TabIndex = 24;
            iconButton1.Text = "Generate Report";
            iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Rrp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Rrp1";
            this.Text = "Rrp1";
            this.Load += new System.EventHandler(this.Rrp1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox songDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Song_type;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}