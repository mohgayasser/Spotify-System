using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using FontAwesome.Sharp;

namespace WindowsFormsApp2
{
    public partial class userAlbums : Form
    {
        public userAlbums()
        {
            InitializeComponent();
        }
        private void userAlbums_Load_1(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                addsonginlist(i);
            }
        }

        private static int count = 4;
       
        string[] albumname = { "ALbum1", " ", " ", "Album2" };

        Button[] b = new Button[count];
        IconButton[] likeddynamicbtn = new IconButton[count];
        Panel[] dynamicPanel = new Panel[count];

        private void addsonginlist(int i)
        {


            // Set Button properties

            dynamicPanel[i] = new Panel();
            dynamicPanel[i].Dock = DockStyle.Top;
            dynamicPanel[i].Location = new System.Drawing.Point(0, 45);
            dynamicPanel[i].Name = "Panel" + i;
            dynamicPanel[i].Size = new System.Drawing.Size(619, 52);
            dynamicPanel[i].TabIndex = 0;

            dynamicPanel[i].BackColor = Color.LavenderBlush;




            b[i] = new Button();
            b[i].Height = 52;

            b[i].Width = 554;
            b[i].FlatStyle = FlatStyle.Flat;

            b[i].FlatAppearance.BorderSize = 0;
            b[i].Location = new Point(0, 0);
            b[i].Dock = DockStyle.Left;

            ///Album name 
            b[i].Text = albumname[i];

            b[i].Name = Convert.ToString(i);

            b[i].Font = new Font("Century Gothic", 11);



            // Add a Button Click Event handler

            b[i].Click += btn_Click;

            ////////Icon Button
            likeddynamicbtn[i] = new IconButton
            {
                Height = 52,
                Width = 58,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Flip = FontAwesome.Sharp.FlipOrientation.Normal,
                ForeColor = System.Drawing.Color.Cornsilk,
                Rotation = 0D,
                UseVisualStyleBackColor = true,
                Dock = DockStyle.Fill,
                IconSize = 40,
                IconColor = Color.Black,
                Name = Convert.ToString(i),


            };
            likeddynamicbtn[i].FlatAppearance.BorderSize = 0;
            likeddynamicbtn[i].IconChar = IconChar.Heart;


            // Add a Button Click Event handler

            likeddynamicbtn[i].Click += iconbtn_cliked;

            Controls.Add(dynamicPanel[i]);

            dynamicPanel[i].Controls.Add(likeddynamicbtn[i]);
            dynamicPanel[i].Controls.Add(b[i]);
            panel3.Controls.Add(dynamicPanel[i]);


        }
        private void btn_Click(Object sender, EventArgs e)
        {
            Button btn = sender as Button;
           // openchildForm(new ALbumSongs(btn.Text));
        }
        private void iconbtn_cliked(Object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            changelike(likeddynamicbtn[Convert.ToInt16(btn.Name)]);
        }
        private void changelike(IconButton currentbtn)
        {
          

           
            if (currentbtn.IconChar == IconChar.Heart)
            {
                currentbtn.IconChar = IconChar.HeartBroken;
                
            }
            else
            {
                currentbtn.IconChar = IconChar.Heart;

            }
        }

        private Form activeform = null;
        private void openchildForm(Form childForm)
        {

            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void trackssearch_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void search_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void trackssearch_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }

}
