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
    public partial class Form2 : Form
    {
        string currentDrag = "";
        string[] elementsNames = { "","Hydrogen","Helium","Lithium","Beryllium","Boron","Carbon","Nitrogen",
                 "Oxygen","Fluorine","Neon","Sodium","Magnesium","Aluminum","Silicon","Phosphor","Sulfur",
                 "Chlorine","Argon","Potassium","Calcium","Scandium","Titanium","Vanadium","Chromium",
                 "Manganese","Iron","Cobalt","Nickel","Copper","Zinc","Gallium","Germanium","Arsenic",
                 "Selenium","Bromine","Krypton","Rubidium","Strontium","Yttrium","Zirconium","Niobium",
                 "Molybdenum","Technetium","Ruthenium","Rhodium","Palladium","Silver","Cadmium","Indium",
                 "Tin","Antimon","Tellurium","Iodine","Xenon","Cesium","Barium","Hafnium","Tantalum",
                 "Tungsten","Rhenium","Osmium","Iridium","Platinum","Gold","Mercury","Thallium","lead",
                 "Bismuth","Polonium","Aststine","Radon","Francium","Radium","Rutherfordium","Dubnium",
                 "Seaborgium","Bohrium","Hassium","Meitnerium","Damstadtium","Roentgenium","Copemicium",
                 "Nihonium","Flerovium","Umunpentium","Livermorium","Unwmseptum","Oganesson"};

        Random RandomClass = new Random();
        int time = 60;
        int time2 = 20;
        int time3 = 40;
        bool secondTimer = false;
        Control ctn1;
        Control ctn2;
        Control ctn3;
        Control ctn4;
        Control ctn5;
        int rand1 ;
        int rand2 ;
        int rand3 ;
        int rand4 ;
        int rand5;

        public Form2()
        {
            InitializeComponent();
            label2.Text ="Welcome scientist "+Class1.username+", hope you learn and enjoy";           
        }

     

        private void Form2_Load(object sender, EventArgs e)
        {
            Class1.draggedCorrectly = 0;
            timer1.Enabled = true;
            timer1.Interval= 1000;
            label3.Text = ""+time;

          
            //!-- showing 5 elements --!
             rand1 = RandomClass.Next(1, 18);
             rand2 = RandomClass.Next(18, 35);
             rand3 = RandomClass.Next(35, 52);
             rand4 = RandomClass.Next(52, 70);
             rand5 = RandomClass.Next(70, 89);
            string ele1 = "P" + rand1;
            string ele2 = "P" + rand2;
            string ele3 = "P" + rand3;
            string ele4 = "P" + rand4;
            string ele5 = "P" + rand5;
             ctn1 = this.Controls[ele1];
             ctn2 = this.Controls[ele2];
             ctn3 = this.Controls[ele3];
             ctn4 = this.Controls[ele4];
             ctn5 = this.Controls[ele5];
            ctn1.Visible = false; 
            ctn2.Visible = false;
            ctn3.Visible = false;
            ctn4.Visible = false;
            ctn5.Visible = false;
            label9.Text  = elementsNames[rand1];
            label10.Text = elementsNames[rand2];
            label11.Text = elementsNames[rand3];
            label12.Text = elementsNames[rand4];
            label13.Text = elementsNames[rand5];


            if (Class1.exerciseType == 0) {
                Class1.desc();
               
                    P1.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P2.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P3.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P4.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P5.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P6.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P7.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P8.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P9.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                    P10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P69.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P80.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P84.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    P88.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else if (Class1.exerciseType == 1) {
                Class1.desc1();
                P1.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P2.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P3.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P4.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P5.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P6.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P7.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P8.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P9.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P10.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P11.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P12.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P13.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P14.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P15.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P16.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P17.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P18.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P19.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P20.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P21.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P22.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P23.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P24.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P25.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P26.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P27.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P28.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P29.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P30.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P31.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P32.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P33.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P34.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P35.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P36.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P37.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P38.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P39.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P40.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P41.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P42.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P43.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P44.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P45.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P46.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P47.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P48.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P49.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P50.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P51.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P52.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P53.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P54.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P55.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P56.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P57.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P58.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P59.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P60.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P61.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P62.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P63.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P64.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P65.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P66.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P67.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P68.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P69.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P70.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P71.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P72.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P73.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P74.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P75.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P76.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P77.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P78.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P79.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P80.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P81.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P82.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P83.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P84.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P85.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P86.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P87.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P88.BorderStyle = System.Windows.Forms.BorderStyle.None;

                P1.BackColor  = Color.WhiteSmoke;
                P2.BackColor  = Color.WhiteSmoke;
                P11.BackColor = Color.WhiteSmoke;
                P12.BackColor = Color.WhiteSmoke;
                P13.BackColor = Color.WhiteSmoke;
                P14.BackColor = Color.WhiteSmoke;
                P15.BackColor = Color.WhiteSmoke;
                P16.BackColor = Color.WhiteSmoke;
                P17.BackColor = Color.WhiteSmoke;
                P18.BackColor = Color.WhiteSmoke;
                P37.BackColor = Color.WhiteSmoke;
                P38.BackColor = Color.WhiteSmoke;
                P39.BackColor = Color.WhiteSmoke;
                P40.BackColor = Color.WhiteSmoke;
                P41.BackColor = Color.WhiteSmoke;
                P42.BackColor = Color.WhiteSmoke;
                P43.BackColor = Color.WhiteSmoke;
                P44.BackColor = Color.WhiteSmoke;
                P45.BackColor = Color.WhiteSmoke;
                P46.BackColor = Color.WhiteSmoke;
                P47.BackColor = Color.WhiteSmoke;
                P48.BackColor = Color.WhiteSmoke;
                P49.BackColor = Color.WhiteSmoke;
                P50.BackColor = Color.WhiteSmoke;
                P51.BackColor = Color.WhiteSmoke;
                P52.BackColor = Color.WhiteSmoke;
                P53.BackColor = Color.WhiteSmoke;
                P54.BackColor = Color.WhiteSmoke;
                P72.BackColor = Color.WhiteSmoke;
                P73.BackColor = Color.WhiteSmoke;
                P74.BackColor = Color.WhiteSmoke;
                P75.BackColor = Color.WhiteSmoke;
                P76.BackColor = Color.WhiteSmoke;
                P77.BackColor = Color.WhiteSmoke;
                P78.BackColor = Color.WhiteSmoke;
                P79.BackColor = Color.WhiteSmoke;
                P80.BackColor = Color.WhiteSmoke;
                P81.BackColor = Color.WhiteSmoke;
                P82.BackColor = Color.WhiteSmoke;
                P83.BackColor = Color.WhiteSmoke;
                P84.BackColor = Color.WhiteSmoke;
                P85.BackColor = Color.WhiteSmoke;
                P86.BackColor = Color.WhiteSmoke;
                P87.BackColor = Color.WhiteSmoke;
                P88.BackColor = Color.WhiteSmoke;

            }
            else if (Class1.exerciseType == 2) {
                Class1.desc2();
                P1.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P2.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P3.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P4.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P5.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P6.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P7.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P8.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P9.BorderStyle  = System.Windows.Forms.BorderStyle.None;
                P10.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P11.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P12.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P13.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P14.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P15.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P16.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P17.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P18.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P19.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P20.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P21.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P22.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P23.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P24.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P25.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P26.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P27.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P28.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P29.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P30.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P31.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P32.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P33.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P34.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P35.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P36.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P37.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P38.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P39.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P40.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P41.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P42.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P43.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P44.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P45.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P46.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P47.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P48.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P49.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P50.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P51.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P52.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P53.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P54.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P55.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P56.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P57.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P58.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P59.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P60.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P61.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P62.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P63.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P64.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P65.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P66.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P67.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P68.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P69.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P70.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P71.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P72.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P73.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P74.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P75.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P76.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P77.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P78.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P79.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P80.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P81.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P82.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P83.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P84.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P85.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P86.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P87.BorderStyle = System.Windows.Forms.BorderStyle.None;
                P88.BorderStyle = System.Windows.Forms.BorderStyle.None;

                P1.BackColor  = Color.WhiteSmoke;
                P3.BackColor  = Color.WhiteSmoke;
                P11.BackColor = Color.WhiteSmoke;
                P19.BackColor = Color.WhiteSmoke;
                P37.BackColor = Color.WhiteSmoke;
                P55.BackColor = Color.WhiteSmoke;
                P72.BackColor = Color.WhiteSmoke;
                P21.BackColor = Color.WhiteSmoke;
                P39.BackColor = Color.WhiteSmoke;
                P23.BackColor = Color.WhiteSmoke;
                P41.BackColor = Color.WhiteSmoke;
                P58.BackColor = Color.WhiteSmoke;
                P75.BackColor = Color.WhiteSmoke;
                P25.BackColor = Color.WhiteSmoke;
                P43.BackColor = Color.WhiteSmoke;
                P60.BackColor = Color.WhiteSmoke;
                P77.BackColor = Color.WhiteSmoke;
                P27.BackColor = Color.WhiteSmoke;
                P45.BackColor = Color.WhiteSmoke;
                P62.BackColor = Color.WhiteSmoke;
                P79.BackColor = Color.WhiteSmoke;
                P29.BackColor = Color.WhiteSmoke;
                P47.BackColor = Color.WhiteSmoke;
                P64.BackColor = Color.WhiteSmoke;
                P81.BackColor = Color.WhiteSmoke;
                P5.BackColor  = Color.WhiteSmoke;
                P13.BackColor = Color.WhiteSmoke;
                P31.BackColor = Color.WhiteSmoke;
                P49.BackColor = Color.WhiteSmoke;
                P66.BackColor = Color.WhiteSmoke;
                P83.BackColor = Color.WhiteSmoke;
                P7.BackColor  = Color.WhiteSmoke;
                P15.BackColor = Color.WhiteSmoke;
                P33.BackColor = Color.WhiteSmoke;
                P51.BackColor = Color.WhiteSmoke;
                P68.BackColor = Color.WhiteSmoke;
                P85.BackColor = Color.WhiteSmoke;
                P9.BackColor  = Color.WhiteSmoke;
                P17.BackColor = Color.WhiteSmoke;
                P35.BackColor = Color.WhiteSmoke;
                P53.BackColor = Color.WhiteSmoke;
                P70.BackColor = Color.WhiteSmoke;
                P87.BackColor = Color.WhiteSmoke;


            }
            else if (Class1.exerciseType == 3) {
                Class1.desc3();
                P1.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P2.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P3.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P4.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P5.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P6.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P7.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P8.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P9.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
                P10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P38.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P39.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P43.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P46.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P51.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P61.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P63.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P65.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P69.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P80.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P84.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P85.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P86.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                P88.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                // CornflowerBlue colour
                P1.BackColor  = Color.CornflowerBlue;
                P6.BackColor  = Color.CornflowerBlue;
                P7.BackColor  = Color.CornflowerBlue;
                P8.BackColor  = Color.CornflowerBlue;
                P15.BackColor = Color.CornflowerBlue;
                P16.BackColor = Color.CornflowerBlue;
                P34.BackColor = Color.CornflowerBlue;

                // Yellow colour
                P3.BackColor  = Color.Yellow;
                P11.BackColor = Color.Yellow;
                P19.BackColor = Color.Yellow;
                P37.BackColor = Color.Yellow;
                P55.BackColor = Color.Yellow;
                P72.BackColor = Color.Yellow;

                // Tan colour
                P4.BackColor  = Color.Tan;
                P12.BackColor = Color.Tan;
                P20.BackColor = Color.Tan;
                P38.BackColor = Color.Tan;
                P56.BackColor = Color.Tan;
                P73.BackColor = Color.Tan;

                // Gold colour
                P2.BackColor  = Color.Gold;
                P10.BackColor = Color.Gold;
                P18.BackColor = Color.Gold;
                P36.BackColor = Color.Gold;
                P54.BackColor = Color.Gold;
                P71.BackColor = Color.Gold;

                // PowderBlue colour
                P9.BackColor  = Color.PowderBlue;
                P17.BackColor = Color.PowderBlue;
                P35.BackColor = Color.PowderBlue;
                P53.BackColor = Color.PowderBlue;
                P70.BackColor = Color.PowderBlue;

                // Thistle colour
                P5.BackColor  = Color.Thistle;
                P14.BackColor = Color.Thistle;
                P32.BackColor = Color.Thistle;
                P33.BackColor = Color.Thistle;
                P51.BackColor = Color.Thistle;
                P52.BackColor = Color.Thistle;

                // Silver colour
                P13.BackColor = Color.Silver;
                P31.BackColor = Color.Silver;
                P49.BackColor = Color.Silver;
                P50.BackColor = Color.Silver;
                P66.BackColor = Color.Silver;
                P67.BackColor = Color.Silver;
                P68.BackColor = Color.Silver;
                P69.BackColor = Color.Silver;

                // Gainsboro colour
                P79.BackColor = Color.Gainsboro;
                P80.BackColor = Color.Gainsboro;
                P81.BackColor = Color.Gainsboro;
                P83.BackColor = Color.Gainsboro;
                P84.BackColor = Color.Gainsboro;
                P85.BackColor = Color.Gainsboro;
                P86.BackColor = Color.Gainsboro;
                P87.BackColor = Color.Gainsboro;
                P88.BackColor = Color.Gainsboro;

                // GreenYellow colour
                P21.BackColor = Color.GreenYellow;
                P22.BackColor = Color.GreenYellow;
                P23.BackColor = Color.GreenYellow;
                P24.BackColor = Color.GreenYellow;
                P25.BackColor = Color.GreenYellow;
                P26.BackColor = Color.GreenYellow;
                P27.BackColor = Color.GreenYellow;
                P28.BackColor = Color.GreenYellow;
                P29.BackColor = Color.GreenYellow;
                P30.BackColor = Color.GreenYellow;
                P39.BackColor = Color.GreenYellow;
                P40.BackColor = Color.GreenYellow;
                P41.BackColor = Color.GreenYellow;
                P42.BackColor = Color.GreenYellow;
                P43.BackColor = Color.GreenYellow;
                P44.BackColor = Color.GreenYellow;
                P45.BackColor = Color.GreenYellow;
                P46.BackColor = Color.GreenYellow;
                P47.BackColor = Color.GreenYellow;
                P48.BackColor = Color.GreenYellow;
                P57.BackColor = Color.GreenYellow;
                P58.BackColor = Color.GreenYellow;
                P59.BackColor = Color.GreenYellow;
                P60.BackColor = Color.GreenYellow;
                P61.BackColor = Color.GreenYellow;
                P62.BackColor = Color.GreenYellow;
                P63.BackColor = Color.GreenYellow;
                P64.BackColor = Color.GreenYellow;
                P65.BackColor = Color.GreenYellow;
                P74.BackColor = Color.GreenYellow;
                P75.BackColor = Color.GreenYellow;
                P76.BackColor = Color.GreenYellow;
                P77.BackColor = Color.GreenYellow;
                P78.BackColor = Color.GreenYellow;
                P82.BackColor = Color.GreenYellow;

              
              

            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

    

        private void button6_Click(object sender, EventArgs e)
        {
            if (Class1.ExitConf())
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Enabled = false;
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Enabled = false;
            TestMyK frm = new TestMyK();
            frm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0) {
            label3.Text = "" + time;
            time--;
             }
            else if (time == 0)
            {
                label3.Text = "" + time;
                label8.Text = "                                  Start playing                                  ";
                ctn1.Visible = true; label9.Visible = true;
                ctn2.Visible = true; label10.Visible = true;
                ctn3.Visible = true; label11.Visible = true;
                ctn4.Visible = true; label12.Visible = true;
                ctn5.Visible = true; label13.Visible = true;

                axWindowsMediaPlayer1.URL = "1minEnds.wav";
                    secondTimer = true;
                    time--;                
            }
            if (secondTimer)
            {
                if (Class1.expert)
                {
                    if (time2 == 0)
                    {
                        label3.Text = "" + time2;
                        timer1.Enabled = false;
                       DialogResult ok = MessageBox.Show("Sorry, time's up :(");
                       if(ok == DialogResult.OK){
                            Class1.game = false;
                            Class1.test = true;
                            Result frm = new Result();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    if(Class1.draggedCorrectly==5){
                        timer1.Enabled = false;
                        DialogResult ok = MessageBox.Show("Bravo, you assinged all the elements correctly :)");
                        if (ok == DialogResult.OK)
                        {
                            Class1.game = false;
                            Class1.test = true;
                            Result frm = new Result();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    label3.Text = "" + time2;
                    time2--;

                }
                else
                {
                    if (time3 == 0)
                    {
                        label3.Text = "" + time3;
                        timer1.Enabled = false;
                        DialogResult ok = MessageBox.Show("Sorry, time's up :(");
                        if (ok == DialogResult.OK)
                        {
                            Class1.game = false;
                            Class1.test = true;
                            Result frm = new Result();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    if (Class1.draggedCorrectly == 5)
                    {
                        timer1.Enabled = false;
                        DialogResult ok = MessageBox.Show("Bravo, you assinged all the elements correctly :)");
                        if (ok == DialogResult.OK)
                        {
                            Class1.game = false;
                            Class1.test = true;
                            Result frm = new Result();
                            frm.Show();
                            this.Hide();
                        }
                    }
                    label3.Text = "" + time3;
                    time3--;
                }
            }
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            currentDrag = label9.Text;
            label9.DoDragDrop(label9.Text,DragDropEffects.Copy );
           
        }

        private void P1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P1_DragDrop(object sender, DragEventArgs e)
        {
            if(Class1.exerciseType==0){
                if (currentDrag.Equals(elementsNames[1]))
                {
                    P1.Visible = false;
                    if (label9.Text.Equals(currentDrag)){label9.Visible = false;}
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false;}
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false;}
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false;}
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false;}
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if(Class1.exerciseType==1){
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[2]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if(Class1.exerciseType==2){
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if(Class1.exerciseType==3){
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            currentDrag = label10.Text;
            label10.DoDragDrop(label10.Text, DragDropEffects.Copy);
        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            currentDrag = label11.Text;
            label11.DoDragDrop(label11.Text, DragDropEffects.Copy);
        }

        private void label12_MouseDown(object sender, MouseEventArgs e)
        {
            currentDrag = label12.Text;
            label12.DoDragDrop(label12.Text, DragDropEffects.Copy);
        }

        private void label13_MouseDown(object sender, MouseEventArgs e)
        {
            currentDrag = label13.Text;
            label13.DoDragDrop(label13.Text, DragDropEffects.Copy);
        }

        private void P2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P11_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P12_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P13_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P14_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P15_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P16_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P17_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P18_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P19_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P20_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P21_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P22_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P23_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P24_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P25_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P26_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P27_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P28_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P29_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P30_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P31_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P32_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P33_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P34_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P35_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P36_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P37_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P38_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P39_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P40_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P41_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P42_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P43_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P44_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P45_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P46_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P47_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P48_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P49_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P50_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P51_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P52_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P53_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P54_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P55_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P56_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P57_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P58_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P59_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P60_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P61_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P62_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P63_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P64_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P65_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P66_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P67_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P68_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P69_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P70_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P71_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P72_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P73_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P74_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P75_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P76_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P77_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P78_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P79_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P80_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P81_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P82_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P83_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P84_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P85_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P86_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P87_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P88_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void P2_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[2]))
                {
                    P2.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[2]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 2)
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 3)
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
        }

        private void P3_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[3]))
                {
                    P3.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[55]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
        }

        private void P4_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[4]))
                {
                    P4.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[56]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[56]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P5_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[5]))
                {
                    P5.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL ="incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[83]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]))//Thistle
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P6_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[6]))
                {
                    P6.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[84]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P7_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[7]))
                {
                    P7.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[85]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }


        private void P8_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[8]))
                {
                    P8.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[86]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P9_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[9]))
                {
                    P9.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[87]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P10_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[10]))
                {
                    P10.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[10]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P11_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[11]))
                {
                    P11.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";

                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
        }

        private void P12_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[12]))
                {
                    P12.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P13_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[13]))
                {
                    P13.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[83]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P14_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[14]))
                {
                    P14.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[84]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]))//Thistle
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P15_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[15]))
                {
                    P15.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[85]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P16_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[16]))
                {
                    P16.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[86]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P17_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[17]))
                {
                    P17.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[87]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P18_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[18]))
                {
                    P18.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[18]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P19_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[19]))
                {
                    P19.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P20_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[20]))
                {
                    P20.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P21_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[21]))
                {
                    P21.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[39]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }

        }

        private void P22_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[22]))
                {
                    P22.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[40])| currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[74]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P23_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[23]))
                {
                    P23.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[75]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P24_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[24]))
                {
                    P24.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[76]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P25_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[25]))
                {
                    P25.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[77]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P26_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[26]))
                {
                    P26.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P27_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[27]))
                {
                    P27.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[79]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P28_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[28]))
                {
                    P28.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[80]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P29_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[29]))
                {
                    P29.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[81]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P30_DragDrop(object sender, DragEventArgs e)
        {

            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[30]))
                {
                    P30.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P31_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[31]))
                {
                    P31.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[83]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P32_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[32]))
                {
                    P32.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[84]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P33_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[33]))
                {
                    P33.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[85]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P34_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[34]))
                {
                    P34.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";

                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[86]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P35_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[35]))
                {
                    P35.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[87]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P36_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[36]))
                {
                    P36.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[36]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P37_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[37]))
                {
                    P37.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P38_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[38]))
                {
                    P38.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P39_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[39]))
                {
                    P39.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[39]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P40_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[40]))
                {
                    P40.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[74]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P41_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[41]))
                {
                    P41.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                  axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[75]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                  axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                  axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P42_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[42]))
                {
                    P42.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[76]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P43_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[43]))
                {
                    P43.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[77]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P44_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[44]))
                {
                    P44.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P45_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[45]))
                {
                    P45.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[79]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P46_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[46]))
                {
                    P46.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[80]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P47_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[47]))
                {
                    P47.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[81]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P48_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[48]))
                {
                    P48.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P49_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[49]))
                {
                    P49.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[5])|currentDrag.Equals(elementsNames[13])| currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[83]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P50_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[50]))
                {
                    P50.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[6]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P51_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[51]))
                {
                    P51.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[7]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P52_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[52]))
                {
                    P52.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[8]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P53_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[53]))
                {
                    P53.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[9]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[9]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }

        }

        private void P54_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[54]))
                {
                    P54.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[54]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[88]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[2]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[2]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P55_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[55]))
                {
                    P55.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P56_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[56]))
                {
                    P56.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P57_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[57]))
                {
                    P57.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[74]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P58_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[58]))
                {
                    P58.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[75]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P59_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[59]))
                {
                    P59.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[76]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P60_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[60]))
                {
                    P60.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[77]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P61_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[61]))
                {
                    P61.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P62_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[62]))
                {
                    P62.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[79]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P63_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[63]))
                {
                    P63.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[80]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P64_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[64]))
                {
                    P64.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[81]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P65_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[65]))
                {
                    P65.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P66_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[66]))
                {
                    P66.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[83]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P67_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[67]))
                {
                    P67.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[84]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P68_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[68]))
                {
                    P68.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[85]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P69_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[69]))
                {
                    P69.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[86]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P70_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[70]))
                {
                    P70.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[87]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P71_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[71]))
                {
                    P71.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P72_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[72]))
                {
                    P72.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[1]) | currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[3]) | currentDrag.Equals(elementsNames[11]) | currentDrag.Equals(elementsNames[19]) | currentDrag.Equals(elementsNames[37]) | currentDrag.Equals(elementsNames[55]) | currentDrag.Equals(elementsNames[72]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P73_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[73]))
                {
                    P73.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[4]) | currentDrag.Equals(elementsNames[12]) | currentDrag.Equals(elementsNames[20]) | currentDrag.Equals(elementsNames[38]) | currentDrag.Equals(elementsNames[56]) | currentDrag.Equals(elementsNames[73]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P74_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[74]))
                {
                    P74.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[74]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P75_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[75]))
                {
                    P75.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[75]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P76_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[76]))
                {
                    P76.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[76]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P77_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[77]))
                {
                    P77.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[77]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P78_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[78]))
                {
                    P78.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P79_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[79]))
                {
                    P79.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[79]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P80_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[80]))
                {
                    P80.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[80]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P81_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[81]))
                {
                    P81.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[81]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P82_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[82]))
                {
                    P82.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[21]) | currentDrag.Equals(elementsNames[27]) | currentDrag.Equals(elementsNames[28]) | currentDrag.Equals(elementsNames[29]) | currentDrag.Equals(elementsNames[30]) | currentDrag.Equals(elementsNames[39]) | currentDrag.Equals(elementsNames[22]) | currentDrag.Equals(elementsNames[23]) | currentDrag.Equals(elementsNames[24]) | currentDrag.Equals(elementsNames[25]) | currentDrag.Equals(elementsNames[26]) | currentDrag.Equals(elementsNames[40]) | currentDrag.Equals(elementsNames[41]) | currentDrag.Equals(elementsNames[42]) | currentDrag.Equals(elementsNames[43]) | currentDrag.Equals(elementsNames[44]) | currentDrag.Equals(elementsNames[45]) | currentDrag.Equals(elementsNames[46]) | currentDrag.Equals(elementsNames[47]) | currentDrag.Equals(elementsNames[48]) | currentDrag.Equals(elementsNames[57]) | currentDrag.Equals(elementsNames[58]) | currentDrag.Equals(elementsNames[59]) | currentDrag.Equals(elementsNames[60]) | currentDrag.Equals(elementsNames[61]) | currentDrag.Equals(elementsNames[62]) | currentDrag.Equals(elementsNames[63]) | currentDrag.Equals(elementsNames[64]) | currentDrag.Equals(elementsNames[65]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P83_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[83]))
                {
                    P83.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[5]) | currentDrag.Equals(elementsNames[13]) | currentDrag.Equals(elementsNames[31]) | currentDrag.Equals(elementsNames[49]) | currentDrag.Equals(elementsNames[66]) | currentDrag.Equals(elementsNames[83]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P84_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[84]))
                {
                    P84.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[6]) | currentDrag.Equals(elementsNames[14]) | currentDrag.Equals(elementsNames[32]) | currentDrag.Equals(elementsNames[50]) | currentDrag.Equals(elementsNames[67]) | currentDrag.Equals(elementsNames[84]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P85_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[85]))
                {
                    P85.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[7]) | currentDrag.Equals(elementsNames[15]) | currentDrag.Equals(elementsNames[33]) | currentDrag.Equals(elementsNames[51]) | currentDrag.Equals(elementsNames[68]) | currentDrag.Equals(elementsNames[85]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P86_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[86]))
                {
                    P86.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[8]) | currentDrag.Equals(elementsNames[16]) | currentDrag.Equals(elementsNames[34]) | currentDrag.Equals(elementsNames[52]) | currentDrag.Equals(elementsNames[69]) | currentDrag.Equals(elementsNames[86]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P87_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[87]))
                {
                    P87.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[9]) | currentDrag.Equals(elementsNames[17]) | currentDrag.Equals(elementsNames[35]) | currentDrag.Equals(elementsNames[53]) | currentDrag.Equals(elementsNames[70]) | currentDrag.Equals(elementsNames[87]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void P88_DragDrop(object sender, DragEventArgs e)
        {
            if (Class1.exerciseType == 0)
            {
                if (currentDrag.Equals(elementsNames[88]))
                {
                    P88.Visible = false;
                    if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                    else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                    else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                    else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                    else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 1)// row
            {
                if (currentDrag.Equals(elementsNames[72]) | currentDrag.Equals(elementsNames[73]) | currentDrag.Equals(elementsNames[74]) | currentDrag.Equals(elementsNames[75]) | currentDrag.Equals(elementsNames[76]) | currentDrag.Equals(elementsNames[77]) | currentDrag.Equals(elementsNames[78]) | currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[82]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 2)//column
            {
                if (currentDrag.Equals(elementsNames[2]) | currentDrag.Equals(elementsNames[10]) | currentDrag.Equals(elementsNames[18]) | currentDrag.Equals(elementsNames[36]) | currentDrag.Equals(elementsNames[54]) | currentDrag.Equals(elementsNames[71]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
            else if (Class1.exerciseType == 3)//color
            {
                if (currentDrag.Equals(elementsNames[79]) | currentDrag.Equals(elementsNames[80]) | currentDrag.Equals(elementsNames[81]) | currentDrag.Equals(elementsNames[83]) | currentDrag.Equals(elementsNames[84]) | currentDrag.Equals(elementsNames[85]) | currentDrag.Equals(elementsNames[86]) | currentDrag.Equals(elementsNames[87]) | currentDrag.Equals(elementsNames[88]))
                {
                    for (int i = 1; i < elementsNames.Length; i++)
                    {
                        if (elementsNames[i].Equals(currentDrag))
                        {
                            if (rand1 == i) { ctn1.Visible = false; }
                            else if (rand2 == i) { ctn2.Visible = false; }
                            else if (rand3 == i) { ctn3.Visible = false; }
                            else if (rand4 == i) { ctn4.Visible = false; }
                            else if (rand5 == i) { ctn5.Visible = false; }
                            if (label9.Text.Equals(currentDrag)) { label9.Visible = false; }
                            else if (label10.Text.Equals(currentDrag)) { label10.Visible = false; }
                            else if (label11.Text.Equals(currentDrag)) { label11.Visible = false; }
                            else if (label12.Text.Equals(currentDrag)) { label12.Visible = false; }
                            else if (label13.Text.Equals(currentDrag)) { label13.Visible = false; }
                        }
                    }
                    Class1.draggedCorrectly++;
                    // voice effect of correct answer
                    axWindowsMediaPlayer1.URL = "correct.MP3";
                }
                else
                {
                    // voice effect of incorrect answer
                    axWindowsMediaPlayer1.URL = "incorrect.MP3";
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Class1.exerciseType == 0) {
                Class1.desc();
            }
            else if (Class1.exerciseType == 1) {
                Class1.desc1();
            }
            else if (Class1.exerciseType == 2) {
                Class1.desc2();
            }
            else if (Class1.exerciseType == 3) {
               Class1.desc3();
            }

        }

    

 


    }
}
