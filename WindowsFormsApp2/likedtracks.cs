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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

using FontAwesome.Sharp;

namespace WindowsFormsApp2
{

    public partial class likedtracks : Form
    {
        private IconButton currentsong;
        public  System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        int count = 0;
      
        Button[] b = new Button[100];
        IconButton[] likeddynamicbtn = new IconButton[100];
        Panel[] dynamicPanel = new Panel[100];
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        string user_name;
        public likedtracks(string user_name)
        {
            this.user_name = user_name;
            InitializeComponent();
            

        }
        private void likedtracks_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand songs_namecomm = new OracleCommand();
            songs_namecomm.Connection = conn;
            songs_namecomm.CommandText = "getusersongs";
            songs_namecomm.CommandType = CommandType.StoredProcedure;
            songs_namecomm.Parameters.Add("user_name", user_name);
            songs_namecomm.Parameters.Add("songsname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = songs_namecomm.ExecuteReader();
            while (dr.Read())
            {

                OracleCommand songscomm = new OracleCommand();
                songscomm.Connection = conn;
                songscomm.CommandText = "getsongsofplaylist";
                songscomm.CommandType = CommandType.StoredProcedure;
                songscomm.Parameters.Add("songname", dr[0].ToString());
                // MessageBox.Show(dr[0].ToString());
                songscomm.Parameters.Add("SONG_Link", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader drsonglink = songscomm.ExecuteReader();
                while (drsonglink.Read()) { 
                    addsonginlist(count++, dr[0].ToString(), drsonglink[0].ToString());

            }
                drsonglink.Close();
            }
            dr.Close();
            conn.Dispose();

        }
        private void addsonginlist(int i, string button_name, string button_link)
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

                ///song name    album Name
                b[i].Text = Convert.ToString(i) + "-" + button_name;

            b[i].Name = button_link;

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
                    Name = Convert.ToString( i),


            };
                likeddynamicbtn[i].FlatAppearance.BorderSize = 0;
                likeddynamicbtn[i].IconChar = IconChar.Heart;


                // Add a Button Click Event handler

                likeddynamicbtn[i].Click += iconbtn_cliked;

                Controls.Add(dynamicPanel[i]);
              
                dynamicPanel[i].Controls.Add(likeddynamicbtn[i]);
                dynamicPanel[i].Controls.Add(b[i]);
                panel2.Controls.Add(dynamicPanel[i]);

            
        }
        private void btn_Click(Object sender, EventArgs e)
        {
            Button btns = sender as Button;
            playsong(btns.Name);
        }
        private void iconbtn_cliked(Object sender, EventArgs e)
        {
            IconButton btn = sender as IconButton;
            try
            {
                int index = Convert.ToInt16(Convert.ToString(Convert.ToString(btn.Name[0]) + Convert.ToString(btn.Name[1])));
               
                changelike(likeddynamicbtn[index], index, 1);
            }
            catch
            {
                int index = Convert.ToInt16((Convert.ToString(btn.Name[0])));
       
                changelike(likeddynamicbtn[Convert.ToInt16(Convert.ToString(btn.Name[0]))], index, 0);

            }
        }
     private void changelike(IconButton currentbtn, int index, int know)
        {

            if (currentbtn.IconChar == IconChar.Heart)
            {
                conn = new OracleConnection(ordb);
                conn.Open();

                currentbtn.IconChar = IconChar.HeartBroken;
                OracleCommand unlikedsongComm = new OracleCommand();
                unlikedsongComm.Connection = conn;
                unlikedsongComm.CommandText = "UNlike_Song ";
                unlikedsongComm.CommandType = CommandType.StoredProcedure;
                unlikedsongComm.Parameters.Add("USerName", user_name);
                if (know == 0)
                    unlikedsongComm.Parameters.Add("SONG_name", b[index].Text.Substring(2));
                else
                    unlikedsongComm.Parameters.Add("SONG_name", b[index].Text.Substring(3));

                int result = unlikedsongComm.ExecuteNonQuery();
                if (result != -1)
                {
                    MessageBox.Show("Done");

                }
                conn.Dispose();
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                currentbtn.IconChar = IconChar.Heart;

                OracleCommand likedsongComm = new OracleCommand();
                likedsongComm.Connection = conn;
                likedsongComm.CommandText = "insertlikedsonge ";
                likedsongComm.CommandType = CommandType.StoredProcedure;
                likedsongComm.Parameters.Add("USerName", user_name);
                if (know == 0)
                    likedsongComm.Parameters.Add("SONG_name", b[index].Text.Substring(2));
                else
                    likedsongComm.Parameters.Add("SONG_name", b[index].Text.Substring(3));

                int result = likedsongComm.ExecuteNonQuery();
                if (result != -1)
                {
                    MessageBox.Show("Done");

                }
                conn.Dispose();
            }
        }
        private void LikedTraks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        public  void pusedbutton()
        {
            player.Stop();
          
        }
        public void playsong(string songlink)
        {

            player.SoundLocation = songlink;
            player.Play();
        }
 
        int likedbtn = 1;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //public void userFormdislike()
        //{
        //    likeddynamicbtn.IconChar = IconChar.HeartBroken;
        //}
        //public void userFormlikeheart()
        //{
        //    lovesonge.IconChar = IconChar.Heart;
        //}


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
