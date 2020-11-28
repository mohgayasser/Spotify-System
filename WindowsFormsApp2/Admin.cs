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
    public partial class Admin : Form
    {
        private IconButton currentbtn;
        private Panel leftBorderbtn;
        public Admin()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 41);
            panel1.Controls.Add(leftBorderbtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
        public static Color color7 = Color.FromArgb(60, 77, 251);

    }

    private void ActivateButton(object senderbtn, Color color)
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

    
    private void Admin_Load(object sender, EventArgs e)
        {

            openchildForm(new usersofAdmin());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openchildForm(new usersofAdmin());
        }

        private void usersongs_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            openchildForm(new TracksOfAdmin());

        }

        private void Library_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            openchildForm(new albumsOfAdmin());
        }

        private void userartists_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            openchildForm(new ArtistsOfAdmin());
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
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wparm, int lParam);
        
        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void header_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

            openchildForm(new PlayListsOfAdmin());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

            openchildForm(new Form2());
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
