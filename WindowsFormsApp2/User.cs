using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WindowsFormsApp2
{
    public partial class User : Form
    {
        private IconButton currentbtn;
        private Panel leftBorderbtn;
        private string Uname;
        public User(string username)
        {
            Uname = username;
            InitializeComponent();
            custemizeDesign();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 41);
            panelsidemenu.Controls.Add(leftBorderbtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
  
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
            public static Color color7 = Color.FromArgb(60, 77, 251);

        }

        private void ActivateButton(object senderbtn ,Color color)
        {
            DisableButton(); 
            currentbtn = (IconButton)senderbtn;
            currentbtn.BackColor = Color.FromArgb(37, 36, 81);
            currentbtn.ForeColor = color;
            currentbtn.IconColor = color;
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentbtn.TextAlign = ContentAlignment.MiddleCenter;
            CurrentchildFormIcon.IconColor = color;
            CurrentchildFormIcon.IconChar = currentbtn.IconChar;
            Titalforchildform.Text = currentbtn.Text;
            Titalforchildform.ForeColor = color;
            
           
        }
        private void DisableButton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(31, 30, 68);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
         private void custemizeDesign()
        {
            panelplaylist.Visible = false;
        }
        private void hidsubmenu()
        {
            if (panelplaylist.Visible == true)
            {
                panelplaylist.Visible = false;
            }
        }
        private void showsubmenu(Panel p1)
        {
            if (p1.Visible == false)
            {
                hidsubmenu();
                p1.Visible = true;
            }
            else
                p1.Visible = false;
        }
        private void Play_Click(object sender, EventArgs e)
        {

        }

        private void nextsong_Click(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {


            openchildForm(new likedtracks(Uname));
        }

        private void Library_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            showsubmenu(panelplaylist);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

            openchildForm(new search(Uname));
            hidsubmenu();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);

            openchildForm(new Settings(Uname));
            hidsubmenu();
        }
        private Form activeform = null;

        private void openchildForm(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm ;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(childForm);
            panelchildform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void usersongs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

            openchildForm(new likedtracks(Uname));
        }

        private void useralbums_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

            openchildForm(new userAlbums());
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void userartists_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

            openchildForm(new Artists(Uname));

        }

        private void userplaylists_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            openchildForm(new playlists(Uname));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint  = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wparm, int lParam);

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       private int likedbtn = 1;
     

        private void nextsong_Click_1(object sender, EventArgs e)
        {

        }
        public void dislike()
        {
            Liked.IconChar = IconChar.HeartBroken;
        }
        public void likeheart()
        {
            Liked.IconChar = IconChar.Heart;
        }
        int pused = 0;
        private void Play_Click_1(object sender, EventArgs e)
        {
            likedtracks like = new likedtracks(Uname);
          
            pused++;
            if (pused > 1)
            {
                like.playsong("media.io_Sia - Unstoppable مترجمة.wav");
                Play.IconChar = IconChar.Play;
                pused = 0;
            }
            else
            {
                like.pusedbutton();
                Play.IconChar = IconChar.Stop;
            }

        }

        private void Liked_Click(object sender, EventArgs e)
        {
            //likedtracks likbtn = new likedtracks();

            //likedbtn++;
            //if (likedbtn > 1)
            //{
            //    likbtn.userformdislike();
            //    dislike();

            //    likedbtn = 0;
            //}
            //else
            //{
            //    likbtn.userformlikeheart();
            //    likeheart();


            //}
        }
    }
}
