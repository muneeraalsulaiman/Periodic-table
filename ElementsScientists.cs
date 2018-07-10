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
    public partial class ElementsScientists : Form
    {
        public ElementsScientists()
        {
            InitializeComponent();
            button1.Click += new EventHandler(ButtonClicked);
            button3.Click += new EventHandler(ButtonClicked);
            button4.Click += new EventHandler(ButtonClicked);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void ElementsScientists_Load(object sender, EventArgs e)
        {
            textBox1.Text = Class1.username;
            if (!Class1.username.Equals(""))
            {
                label17.Text = "Welcome scientist " + Class1.username + ", hope you learn and enjoy";
            }
            else { label17.Visible = false; }
        }

        private void button6_Click(object sender, EventArgs e) //exit button
        {
            if (Class1.ExitConf())
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClicked(object sender, EventArgs e) {
            Class1.username = textBox1.Text;
           
                Button button=(Button)sender;
                if (button.Name.Equals("button1"))
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }
                else if (button.Name.Equals("button3"))
                {
                    TestMyK frm = new TestMyK();
                    frm.Show();
                    this.Hide();
                }
                else if (button.Name.Equals("button4"))
                {
                    Game frm = new Game();
                    frm.Show();
                    this.Hide();
                }
            
        }




    }
}
