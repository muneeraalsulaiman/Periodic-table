using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCIproject
{
    public partial class Game : Form
    {
        private String[] eleNames = { "Silver","Boron","Sodium","Lithium","Carbon",
        "Argon","Iron","Copper","Oxygen","Hydrogen","Silicon","Nickel","Beryllium","Helium",
        "Fluorine","Xenon","Zinc","Calcium","Yttrium","Osmium","Titanium" };
        Random RandomClass= new Random();
        Size size = new Size(64,63);
        Size enter = new Size(68,68);
        
        public Game()
        {
            InitializeComponent();
            pictureBox2.Click += new EventHandler(pictureClick);
            pictureBox3.Click += new EventHandler(pictureClick);
            pictureBox4.Click += new EventHandler(pictureClick);
            pictureBox5.Click += new EventHandler(pictureClick);
            pictureBox6.Click += new EventHandler(pictureClick);
            pictureBox7.Click += new EventHandler(pictureClick);
            pictureBox8.Click += new EventHandler(pictureClick);
            pictureBox9.Click += new EventHandler(pictureClick);
            pictureBox10.Click += new EventHandler(pictureClick);
            pictureBox11.Click += new EventHandler(pictureClick);
            pictureBox12.Click += new EventHandler(pictureClick);
            pictureBox13.Click += new EventHandler(pictureClick);
            pictureBox14.Click += new EventHandler(pictureClick);
            pictureBox15.Click += new EventHandler(pictureClick);
            pictureBox16.Click += new EventHandler(pictureClick);
            pictureBox17.Click += new EventHandler(pictureClick);
            pictureBox18.Click += new EventHandler(pictureClick);
            pictureBox19.Click += new EventHandler(pictureClick);
            pictureBox20.Click += new EventHandler(pictureClick);
            pictureBox21.Click += new EventHandler(pictureClick);
            pictureBox22.Click += new EventHandler(pictureClick);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }


        private void Game_Load(object sender, EventArgs e)
        {
            label1.Text="Welcome scientist "+Class1.username+", hope you learn and enjoy";
            int rand1 = RandomClass.Next(0, 7);
            int rand2 = RandomClass.Next(7, 14);
            int rand3 = RandomClass.Next(14, 21);
            label4.Text= eleNames[rand1];
            label6.Text= eleNames[rand2];
            label7.Text= eleNames[rand3];
            pictureBox1.Visible = true;
            pictureBox23.Visible = false; pictureBox24.Visible = false; pictureBox25.Visible = false;
            Class1.correctedTry = 0;
            Class1.falseTry = 0;
            Class1.game = false;
            Class1.test = false;
        }
        private void pictureClick(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox) sender;
            if (p.Name.Equals("pictureBox2")) {
                if (label4.Text.Equals("Silver") || label6.Text.Equals("Silver") || label7.Text.Equals("Silver"))
                {
                    pictureBox2.Size=size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox2.Location.X-120,pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox2.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox2.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox2.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox2.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true; 
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();

                    }// to here
                        if (label4.Text.Equals("Silver"))
                        {
                            label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                        }
                        else if (label6.Text.Equals("Silver"))
                        {
                            label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                        }
                        else if (label7.Text.Equals("Silver"))
                        {
                            label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                        }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                        pictureBox2.Enabled = false;
                        pictureBox26.Visible = true;
                        pictureBox26.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");//
                }
            }
            else if (p.Name.Equals("pictureBox3")) {
                if (label4.Text.Equals("Boron") || label6.Text.Equals("Boron") || label7.Text.Equals("Boron"))
                {
                    pictureBox3.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox3.Location.X-120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox3.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox3.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox3.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox3.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Boron"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Boron"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Boron"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                        pictureBox3.Enabled = false;
                        pictureBox27.Visible = true;
                        pictureBox27.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");//
                }
            }
            else if (p.Name.Equals("pictureBox4"))
            {
                if (label4.Text.Equals("Sodium") || label6.Text.Equals("Sodium") || label7.Text.Equals("Sodium"))
                {
                    pictureBox4.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox4.Location.X-120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox4.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox4.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox4.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox4.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Sodium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Sodium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Sodium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox4.Enabled = false;
                pictureBox29.Visible = true;
                pictureBox29.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox5"))
            {
                if (label4.Text.Equals("Lithium") || label6.Text.Equals("Lithium") || label7.Text.Equals("Lithium"))
                {
                    pictureBox5.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox5.Location.X-120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox5.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox5.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox5.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox5.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Lithium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Lithium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Lithium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox5.Enabled = false;
                pictureBox30.Visible = true;
                pictureBox30.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox6"))
            {
                if (label4.Text.Equals("Carbon") || label6.Text.Equals("Carbon") || label7.Text.Equals("Carbon"))
                {
                    pictureBox6.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox6.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox6.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox6.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox6.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox6.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Carbon"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Carbon"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Carbon"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox6.Enabled = false;
                pictureBox31.Visible = true;
                pictureBox31.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox7"))
            {
                if (label4.Text.Equals("Iron") || label6.Text.Equals("Iron") || label7.Text.Equals("Iron"))
                {
                    pictureBox7.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox7.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox7.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox7.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox7.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox7.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Iron"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Iron"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Iron"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox7.Enabled = false;
                pictureBox32.Visible = true;
                pictureBox32.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox8"))
            {
                if (label4.Text.Equals("Argon") || label6.Text.Equals("Argon") || label7.Text.Equals("Argon"))
                {
                    pictureBox8.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox8.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox8.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox8.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox8.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox8.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Argon"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Argon"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Argon"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                      pictureBox8.Enabled = false;
                      pictureBox33.Visible = true;
                      pictureBox33.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox9"))
            {
                if (label4.Text.Equals("Copper") || label6.Text.Equals("Copper") || label7.Text.Equals("Copper"))
                {
                    pictureBox9.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox9.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox9.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox9.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox9.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox9.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Copper"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Copper"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Copper"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                        pictureBox9.Enabled = false;
                        pictureBox34.Visible = true;
                        pictureBox34.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox10"))
            {
                if (label4.Text.Equals("Oxygen") || label6.Text.Equals("Oxygen") || label7.Text.Equals("Oxygen"))
                {
                    pictureBox10.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox10.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox10.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox10.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox10.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox10.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Oxygen"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Oxygen"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Oxygen"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                      pictureBox10.Enabled = false;
                      pictureBox36.Visible = true;
                      pictureBox36.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox11"))
            {
                if (label4.Text.Equals("Hydrogen") || label6.Text.Equals("Hydrogen") || label7.Text.Equals("Hydrogen"))
                {
                    pictureBox11.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox11.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox11.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox11.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox11.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox11.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Hydrogen"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Hydrogen"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Hydrogen"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                       pictureBox11.Enabled = false;
                       pictureBox35.Visible = true;
                       pictureBox35.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox12"))
            {
                if (label4.Text.Equals("Silicon") || label6.Text.Equals("Silicon") || label7.Text.Equals("Silicon"))
                {
                    pictureBox12.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox12.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox12.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox12.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox12.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox12.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Silicon"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Silicon"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Silicon"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox12.Enabled = false;
                pictureBox39.Visible = true;
                pictureBox39.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox13"))
            {
                if (label4.Text.Equals("Nickel") || label6.Text.Equals("Nickel") || label7.Text.Equals("Nickel"))
                {
                    pictureBox13.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox13.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox13.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox13.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox13.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox13.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Nickel"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Nickel"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Nickel"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox13.Enabled = false;
                pictureBox42.Visible = true;
                pictureBox42.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox14"))
            {
                if (label4.Text.Equals("Beryllium") || label6.Text.Equals("Beryllium") || label7.Text.Equals("Beryllium"))
                {
                    pictureBox14.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox14.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox14.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox14.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox14.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox14.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Beryllium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Beryllium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Beryllium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox14.Enabled = false;
                pictureBox40.Visible = true;
                pictureBox40.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox15"))
            {
                if (label4.Text.Equals("Helium") || label6.Text.Equals("Helium") || label7.Text.Equals("Helium"))
                {
                    pictureBox15.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox15.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox15.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox15.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox15.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox15.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Helium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Helium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Helium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox15.Enabled = false;
                pictureBox41.Visible = true;
                pictureBox41.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox16"))
            {
                if (label4.Text.Equals("Fluorine") || label6.Text.Equals("Fluorine") || label7.Text.Equals("Fluorine"))
                {
                    pictureBox16.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox16.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox16.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox16.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox16.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox16.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Fluorine"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Fluorine"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Fluorine"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox16.Enabled = false;
                pictureBox43.Visible = true;
                pictureBox43.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox17"))
            {
                if (label4.Text.Equals("Xenon") || label6.Text.Equals("Xenon") || label7.Text.Equals("Xenon"))
                {
                    pictureBox17.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox17.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox17.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox17.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox17.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox17.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Xenon"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Xenon"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Xenon"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox17.Enabled = false;
                pictureBox47.Visible = true;
                pictureBox47.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox18"))
            {
                if (label4.Text.Equals("Zinc") || label6.Text.Equals("Zinc") || label7.Text.Equals("Zinc"))
                {
                    pictureBox18.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox18.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox18.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox18.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox18.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox18.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Zinc"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Zinc"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Zinc"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox18.Enabled = false;
                pictureBox37.Visible = true;
                pictureBox37.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox19"))
            {
                if (label4.Text.Equals("Calcium") || label6.Text.Equals("Calcium") || label7.Text.Equals("Calcium"))
                {
                    pictureBox19.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox19.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox19.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox19.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox19.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox19.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Calcium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Calcium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Calcium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox19.Enabled = false;
                pictureBox38.Visible = true;
                pictureBox38.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox20"))
            {
                if (label4.Text.Equals("Yttrium") || label6.Text.Equals("Yttrium") || label7.Text.Equals("Yttrium"))
                {
                    pictureBox20.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox20.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox20.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox20.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox20.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox20.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Yttrium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Yttrium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Yttrium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox20.Enabled = false;
                pictureBox45.Visible = true;
                pictureBox45.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox21"))
            {
                if (label4.Text.Equals("Osmium") || label6.Text.Equals("Osmium") || label7.Text.Equals("Osmium"))
                {
                    pictureBox21.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox21.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox21.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox21.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox21.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox21.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Osmium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Osmium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Osmium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox21.Enabled = false;
                pictureBox46.Visible = true;
                pictureBox46.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
            else if (p.Name.Equals("pictureBox22"))
            {
                if (label4.Text.Equals("Titanium") || label6.Text.Equals("Titanium") || label7.Text.Equals("Titanium"))
                {
                    pictureBox22.Size = size;
                    axWindowsMediaPlayer1.URL = "So.wav";
                    pictureBox1.Location = new Point(pictureBox22.Location.X - 120, pictureBox1.Location.Y);
                    pictureBox23.Location = new Point(pictureBox22.Location.X - 120, pictureBox23.Location.Y);
                    pictureBox24.Location = new Point(pictureBox22.Location.X - 120, pictureBox24.Location.Y);
                    pictureBox25.Location = new Point(pictureBox22.Location.X - 120, pictureBox25.Location.Y);
                    pictureBox22.Visible = false;// from here
                    Class1.correctedTry++;
                    if (Class1.correctedTry == 1)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = true;
                        pictureBox24.Visible = false; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 2)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = true; pictureBox25.Visible = false;
                    }
                    else if (Class1.correctedTry == 3)
                    {
                        pictureBox1.Visible = false; pictureBox23.Visible = false;
                        pictureBox24.Visible = false; pictureBox25.Visible = true;
                        Class1.game = true; // go 2 result form
                        axWindowsMediaPlayer1.URL = "done.wav";
                        Result frm = new Result();
                        frm.Show();
                        this.Hide();
                    }// to here
                    if (label4.Text.Equals("Titanium"))
                    {
                        label4.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label6.Text.Equals("Titanium"))
                    {
                        label6.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                    else if (label7.Text.Equals("Titanium"))
                    {
                        label7.Font = new Font(label4.Font.FontFamily, 12, FontStyle.Strikeout);
                    }
                }
                else { Class1.falseTry++; axWindowsMediaPlayer2.URL = "idontthinkso.wav";
                pictureBox22.Enabled = false;
                pictureBox44.Visible = true;
                pictureBox44.BackgroundImage = Image.FromFile(Application.StartupPath + @"\x.png");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (Class1.ExitConf())
            {
                Application.Exit();
            }
        }

   
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void mouseenter(object sender, EventArgs e)
        {
            pictureBox2.Size = enter;
        }

        private void mouseleave(object sender, EventArgs e)
        {
             pictureBox2.Size = size;
        }

        private void enterpic3(object sender, EventArgs e)
        {
            pictureBox3.Size = enter;
        }

        private void leavepic3(object sender, EventArgs e)
        {
            pictureBox3.Size = size;

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Size = enter;

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = size;

        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Size = enter;

        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Size = size;

        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Size = enter;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = size;

        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Size = enter;

        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = size;

        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Size = enter;

        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = size;

        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Size = enter;

        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = size;

        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Size = enter;

        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Size = size;

        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Size = enter;

        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Size = size;

        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            pictureBox12.Size = enter;

        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Size = size;

        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Size = enter;

        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Size = size;

        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            pictureBox14.Size = enter;

        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Size = size;

        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {
            pictureBox15.Size = enter;

        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Size = size;

        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            pictureBox16.Size = enter;

        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Size = size;

        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            pictureBox17.Size = enter;

        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Size = size;

        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            pictureBox18.Size = enter;

        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Size = size;

        }

        private void pictureBox19_MouseEnter(object sender, EventArgs e)
        {
            pictureBox19.Size = enter;

        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Size = size;

        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {
            pictureBox20.Size = enter;

        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Size = size;

        }

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            pictureBox21.Size = enter;

        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.Size = size;

        }


        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            pictureBox22.Size = enter;

        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Size = size;

        }




    }
}
