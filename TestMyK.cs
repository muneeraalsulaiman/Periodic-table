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
    public partial class TestMyK : Form
    {
        public TestMyK()
        {
            InitializeComponent();
            label1.Text = "Welcome scientist " + Class1.username + ", hope you learn and enjoy";
            comboBox1.Items.Add("Symbol criteria");
            comboBox1.Items.Add("by period (row)");
            comboBox1.Items.Add("by group (column)");
            comboBox1.Items.Add("by calssification (color)");
       
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

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

        private void button5_Click(object sender, EventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (vlaidateChosenElement()) {
                if(radioButton1.Checked){
                    Class1.expert = false;
                }
                else if(radioButton2.Checked){
                    Class1.expert = true;
                }

                if(comboBox1.SelectedIndex==0){
                    Class1.exerciseType = 0;
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();

                }
                else if(comboBox1.SelectedIndex==1){
                    Class1.exerciseType = 1;
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else if(comboBox1.SelectedIndex==2){
                    Class1.exerciseType = 2;
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }  
                else if (comboBox1.SelectedIndex == 3)
                {
                    Class1.exerciseType = 3;
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void comp_validating(object sender, CancelEventArgs e)
        {
            vlaidateChosenElement();
        }


        private bool vlaidateChosenElement(){
            bool flag = true;
            if(comboBox1.SelectedIndex==-1){
                errorProvider1.SetError(comboBox1,"you didnt choose the exercise type!");
                flag = false;
            }
            else{
                errorProvider1.SetError(comboBox1, "");
            }
            return flag;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


     
    }
}
