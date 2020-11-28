using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

using FontAwesome.Sharp;
namespace WindowsFormsApp2
{
    public partial class Artists : Form
    {
        string ordb = "data source=orcl; user id=hr; password=hr;";
        OracleConnection conn;
        string user_name;
        public Artists( string user_name)
        {
            this.user_name = user_name;
            InitializeComponent();
        }
        string []albums = new string[100];
        string []artistname = new string[100];
        bool found = false;
        private void Artists_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand usersongs = new OracleCommand();
            usersongs.Connection = conn;
            usersongs.CommandText = "getusersongs";
            usersongs.CommandType = CommandType.StoredProcedure;
            usersongs.Parameters.Add("username", user_name);
            usersongs.Parameters.Add("songs_name", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader drusersongs = usersongs.ExecuteReader();
            while (drusersongs.Read())
            {
                OracleCommand songs_namecomm = new OracleCommand();
                songs_namecomm.Connection = conn;
                songs_namecomm.CommandText = "liked_artists_albumsofartists";
                songs_namecomm.CommandType = CommandType.StoredProcedure;
                songs_namecomm.Parameters.Add("song_name", drusersongs[0].ToString());
                songs_namecomm.Parameters.Add("albumsname", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader dr = songs_namecomm.ExecuteReader();
                while (dr.Read())
                {
                    found = false;
                    for (int i = 0; i < count; i++)
                    {

                        if (string.Compare( albums[i] , dr[0].ToString())!=0)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        albums[count] = dr[0].ToString();
                        count++;
                    }

                }
                dr.Close();
            }
                int k = 0;
                for (int i = 0; i < count; i++)
                {
                    OracleCommand songscomm = new OracleCommand();
                    songscomm.Connection = conn;
                    songscomm.CommandText = "liked_artists";
                    songscomm.CommandType = CommandType.StoredProcedure;
                    songscomm.Parameters.Add("album_name", albums[i]);
                    // MessageBox.Show(dr[0].ToString());
                    songscomm.Parameters.Add("artist_name", OracleDbType.RefCursor, ParameterDirection.Output);

                    OracleDataReader drartist = songscomm.ExecuteReader();
                  
                    while (drartist.Read())
                    {
                        found = false;
                        for (int j = 0; j < k; j++)
                        {
                            if (string.Compare( artistname[j] ,drartist[0].ToString())!=0)
                            {
                                found = true;
                                break;

                            }
                         
                        }
                        if (!found)
                        {
                        addsonginlist(i, drartist[0].ToString());

                        k++;
                        }
                        }
                drartist.Close();
                }
               // 
        
        
            conn.Close();
        }
        int count = 0;

        Button[] b = new Button[100];
        IconButton[] likeddynamicbtn = new IconButton[100];
        Panel[] dynamicPanel = new Panel[100];

        private void addsonginlist(int i, string artist_name)
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
            b[i].Text = artist_name;

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
                ForeColor = System.Drawing.Color.Black,
                Rotation = 0D,
                UseVisualStyleBackColor = true,
                Dock = DockStyle.Fill,
                IconSize = 40,
                IconColor = Color.Black,
                Name = Convert.ToString(i)


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
           // openchildForm(new artistsongs(btn.Text));
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
    }
}
