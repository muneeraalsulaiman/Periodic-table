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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Close();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            label6.Text = "Welcome scientist " + Class1.username + ", hope you learn and enjoy";

            if (Class1.game) {
                button2.Text = "Play again";
                label1.Visible = false;
                label3.Visible = false;
                pictureBox3.Visible = false;
                label10.Visible = false;
                pictureBox4.Visible = false;

                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label8.Text = label8.Text + Class1.falseTry;
                linkLabel2.Text = "Game";
                linkLabel3.Visible = false;
                label4.Visible = false;
                label5.Location = new Point(label5.Location.X-135,label5.Location.Y);
            }
            else if (Class1.test) {
                button2.Text = "Test again";
                label9.Visible = false;
                label8.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                label1.Visible = true;
                if (Class1.draggedCorrectly >= 3) {
                    axWindowsMediaPlayer1.URL = "done.wav";
                    label3.Text = ""+Class1.draggedCorrectly+"/5"; label3.Visible = true;
                    label3.ForeColor = Color.Green;
                    label10.Text = "Good Jop Our Scientist"; label10.Visible = true;
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                }

                else if (Class1.draggedCorrectly < 3)
                {
                    axWindowsMediaPlayer1.URL = "lose.MP3";
                    label3.Text = "" + Class1.draggedCorrectly+"/5"; label3.Visible = true;
                    label3.ForeColor = Color.Red;
                    label10.Text = "Don't give up, try again"; label10.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = false;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Class1.game) {
                Game form = new Game();
                form.Show();
                this.Close();
            }
            else if (Class1.test)
            {
                TestMyK form = new TestMyK();
                form.Show();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Class1.ExitConf())
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Class1.game) {
                Game form = new Game();
                form.Show();
                this.Close();
            }
            else if (Class1.test)
            {
                TestMyK frm = new TestMyK();
                frm.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
