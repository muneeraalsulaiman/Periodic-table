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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Class1.col = 6;
            Class1.block = 6;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label17.Text = "Welcome scientist " + Class1.username + ", hope you learn and enjoy";
            
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Class1.col = 13;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }


        private void button79_Click_1(object sender, EventArgs e)
        {
            Class1.col = 56;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Class1.col = 69;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            Class1.col = 57;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Class1.col = 71;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button86_Click_1(object sender, EventArgs e)
        {

            Class1.col = 28;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button14_Click_2(object sender, EventArgs e)
        {

            Class1.col = 23;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (Class1.ExitConf())
            {
                Application.Exit();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Class1.col = 0;
            Class1.block = 0;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Class1.col = 1;
            Class1.block = 1;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Class1.col = 2;
            Class1.block = 2;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button51_Click(object sender, EventArgs e)
        {
            Class1.col = 3;
            Class1.block = 3;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Class1.col = 4;
            Class1.block = 4;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Class1.col = 5;
            Class1.block = 5;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button41_Click(object sender, EventArgs e)
        {

            Class1.col = 7;
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button42_Click(object sender, EventArgs e)
        {

            Class1.col = 8;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button43_Click(object sender, EventArgs e)
        {
            Class1.col = 9;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button46_Click(object sender, EventArgs e)
        {
            Class1.col = 10;

            Lesson lesson = new Lesson();
            lesson.Show();

            this.Hide();
        }

        private void button47_Click(object sender, EventArgs e)
        {

            Class1.col = 11;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            Class1.col = 12;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button45_Click(object sender, EventArgs e)
        {

            Class1.col = 14;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button73_Click_1(object sender, EventArgs e)
        {
            Class1.col = 15;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button74_Click_1(object sender, EventArgs e)
        {
            Class1.col = 16;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            Class1.col = 17;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            Class1.col = 18;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
            Class1.col = 19;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button16_Click_2(object sender, EventArgs e)
        {

            Class1.col = 20;
          
            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            Class1.col = 21;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            Class1.col = 22;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            Class1.col = 24;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            Class1.col = 25;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            Class1.col = 26;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button85_Click_1(object sender, EventArgs e)
        {
            Class1.col = 27;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            Class1.col = 29;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button87_Click_1(object sender, EventArgs e)
        {
            Class1.col = 30;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button84_Click_1(object sender, EventArgs e)
        {
            Class1.col = 31;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button81_Click_1(object sender, EventArgs e)
        {

            Class1.col = 32;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button82_Click_1(object sender, EventArgs e)
        {

            Class1.col = 33;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button83_Click_1(object sender, EventArgs e)
        {
            Class1.col = 34;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();

        }

        private void button80_Click_1(object sender, EventArgs e)
        {

            Class1.col = 35;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button77_Click_1(object sender, EventArgs e)
        {
            Class1.col = 36;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button75_Click_1(object sender, EventArgs e)
        {

            Class1.col = 37;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button76_Click_1(object sender, EventArgs e)
        {
            Class1.col = 38;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button59_Click_1(object sender, EventArgs e)
        {

            Class1.col = 39;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button56_Click_1(object sender, EventArgs e)
        {
            Class1.col = 40;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button57_Click_1(object sender, EventArgs e)
        {
            Class1.col = 41;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button58_Click_1(object sender, EventArgs e)
        {
            Class1.col = 42;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Class1.col = 43;

            Lesson lesson = new Lesson();
            lesson.Show();
            this.Hide();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Class1.col = 47;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button54_Click_1(object sender, EventArgs e)
        {
            Class1.col = 44;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button55_Click_1(object sender, EventArgs e)
        {
            Class1.col = 45;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            Class1.col = 46;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            Class1.col = 48;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }



        private void button97_Click(object sender, EventArgs e)
        {
            Class1.col = 68;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            Class1.col = 49;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Class1.col = 50;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Class1.col = 51;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            Class1.col = 52;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button88_Click_1(object sender, EventArgs e)
        {
            Class1.col = 53;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            Class1.col = 54;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button78_Click_1(object sender, EventArgs e)
        {
            Class1.col = 55;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button60_Click_1(object sender, EventArgs e)
        {
            Class1.col = 58;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            Class1.col = 59;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            Class1.col = 60;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            Class1.col = 61;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            Class1.col = 62;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Class1.col = 63;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Class1.col = 64;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            Class1.col = 65;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button95_Click(object sender, EventArgs e)
        {
            Class1.col = 66;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button96_Click(object sender, EventArgs e)
        {
            Class1.col = 67;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            Class1.col = 70;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Class1.col = 72;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Class1.col = 73;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Class1.col = 74;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Class1.col = 75;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Class1.col = 76;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Class1.col = 77;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Class1.col = 78;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Class1.col = 79;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.col = 80;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class1.col = 81;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Class1.col = 82;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Class1.col = 83;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Class1.col = 84;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Class1.col = 85;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Class1.col = 86;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Class1.col = 87;
            Lesson less = new Lesson();
            less.Show();
            this.Hide();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            TestMyK test = new TestMyK();
            test.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TestMyK test = new TestMyK();
            test.Show();
            this.Hide();
        }



    }
}
