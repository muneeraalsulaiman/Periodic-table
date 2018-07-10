using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;


namespace HCIproject
{
    public partial class Lesson : Form
    {

        public Lesson()
        {
            InitializeComponent();
        }



        private void Lesson_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome scientist " + Class1.username + ", hope you learn and enjoy";

                Class1.element[0].name = "Hydrogen ";
                Class1.element[0].symbol = "H";
                Class1.element[0].Classification = "Other nonmetals";
                Class1.element[0].number = "1";
                Class1.element[0].mass = "1.007825";
                Class1.element[0].level = "1";
                Class1.element[0].History = "Discovered by Henry Cavendish in 1766";
                Class1.element[0].formula = "Atomic hydrogen produces hydrogen peroxide, H2O2, with oxygen";
                Class1.element[1].name = "Lithium ";
                Class1.element[1].symbol = "Li";
                Class1.element[1].Classification = "Alkalai metals";
                Class1.element[1].number = "3";
                Class1.element[1].mass = "6.941 ";
                Class1.element[1].level = "2-1";
                Class1.element[1].History = "Discovered by Johann Arfvedson in 1817";
                Class1.element[1].formula = "Li2CO3";
                Class1.element[2].name = "Sodium";
                Class1.element[2].symbol = "Na";
                Class1.element[2].Classification = "Alkalai metals";
                Class1.element[2].number = "11";
                Class1.element[2].mass = "22.98977 ";
                Class1.element[2].level = "2-8-1";
                Class1.element[2].History = "Discovered by Sir Humphrey Davy in 1807";
                Class1.element[2].formula = "Na";
                Class1.element[3].name = "Potassium ";
                Class1.element[3].symbol = "K";
                Class1.element[3].Classification = "Alkalai metals";
                Class1.element[3].number = "19";
                Class1.element[3].mass = "39.0983";
                Class1.element[3].level = "2-8-8-1";
                Class1.element[3].History = "Discovered by Sir Davy in 1808";
                Class1.element[3].formula = "KH2PO4";
                Class1.element[4].name = "Rubidium ";
                Class1.element[4].symbol = "Rb";
                Class1.element[4].Classification = "Alkalai metals";
                Class1.element[4].number = "37";
                Class1.element[4].mass = "85.4678 ";
                Class1.element[4].level = "2-8-18-8";
                Class1.element[4].History = "Discovered by Robert Wilhem Bunsen and Gustav Robert Kirchhoff in 1861 ";
                Class1.element[4].formula = "RbNO3";
                Class1.element[5].name = "Cesium ";
                Class1.element[5].symbol = "Cs";
                Class1.element[5].Classification = "Alkalai metals";
                Class1.element[5].number = "55";
                Class1.element[5].mass = "132.9054";
                Class1.element[5].level = "2-8-18-18-1";
                Class1.element[5].History = "Discovered by Fustov Kirchhoff in 1860 ";
                Class1.element[5].formula = "Cs2SO4";
                Class1.element[6].name = "Francium ";
                Class1.element[6].symbol = "Fr";
                Class1.element[6].Classification = "Alkalai metals";
                Class1.element[6].number = "87";
                Class1.element[6].mass = "233";
                Class1.element[6].level = "2-8-18-32-8-1";
                Class1.element[6].History = "Discovered by Marguerite Perey in 1939";
                Class1.element[6].formula = "Fr3P";
                Class1.element[7].name = "Beryllium ";
                Class1.element[7].symbol = "Be";
                Class1.element[7].Classification = "Alkaline earth metals";
                Class1.element[7].number = "4";
                Class1.element[7].mass = "9.01218 ";
                Class1.element[7].level = "2-2";
                Class1.element[7].History = "Discovered by Abbé René-Just Hauy in 1798";
                Class1.element[7].formula = "BeCI2";
                Class1.element[8].name = "Magnesium ";
                Class1.element[8].symbol = "Mg";
                Class1.element[8].Classification = "Alkaline earth metals";
                Class1.element[8].number = "12";
                Class1.element[8].mass = "24.305";
                Class1.element[8].level = "2-8-2";
                Class1.element[8].History = "Discovered by Sir Humphrey Davy in 1808";
                Class1.element[8].formula = "Mg";
                Class1.element[9].name = "Calcium ";
                Class1.element[9].symbol = "Ca";
                Class1.element[9].Classification = "Alkaline earth metals";
                Class1.element[9].number = "20";
                Class1.element[9].mass = "40.08 ";
                Class1.element[9].level = "2-8-8-2";
                Class1.element[9].History = "Discovered by Sir Humphrey Davy in 1808";
                Class1.element[9].formula = "Ca(CN)2"; 
                Class1.element[10].name = "Strontium ";
                Class1.element[10].symbol = "Sr";
                Class1.element[10].Classification = "Alkaline earth metals";
                Class1.element[10].number = "38";
                Class1.element[10].mass = "87.62 ";
                Class1.element[10].level = "2-8-18-8-2";
                Class1.element[10].History = "Discovered by A. Crawford in 1790";
                Class1.element[10].formula = "SrSe";
                Class1.element[11].name = "Barium ";
                Class1.element[11].symbol = "Ba";
                Class1.element[11].Classification = "Alkaline earth metals";
                Class1.element[11].number = "56";
                Class1.element[11].mass = "137.33";
                Class1.element[11].level = "2-8-18-18-8-2";
                Class1.element[11].History = "Discovered by Sir Humphrey Davy in 1808";
                Class1.element[11].formula = "Ba(NO3)2";
                Class1.element[12].name = "Radium ";
                Class1.element[12].symbol = "Ra";
                Class1.element[12].Classification = "Alkaline earth metals";
                Class1.element[12].number = "88";
                Class1.element[12].mass = "226.0254 ";
                Class1.element[12].level = "2-8-18-32-18-8-2";
                Class1.element[12].History = "Discovered by Pierre and Marie Curie 1898 ";
                Class1.element[12].formula = "Ra";
                Class1.element[13].name = "Scandium ";
                Class1.element[13].symbol = "Sc";
                Class1.element[13].Classification = "Transition metals";
                Class1.element[13].number = "21";
                Class1.element[13].mass = "44.9559 ";
                Class1.element[13].level = "2-8-9-2";
                Class1.element[13].History = "Discovered by Lars Nilson in 1879";
                Class1.element[13].formula = "ScOH";
                Class1.element[14].name = "Yttrium ";
                Class1.element[14].symbol = "Y";
                Class1.element[14].Classification = "Transition metals";
                Class1.element[14].number = "39";
                Class1.element[14].mass = "88.9059";
                Class1.element[14].level = "2-8-9-2";
                Class1.element[14].History = "Discovered by Johann Gadolin in 1794";
                Class1.element[14].formula = "YNi5";
                Class1.element[15].name = "Titanium ";
                Class1.element[15].symbol = "Ti";
                Class1.element[15].Classification = "Transition metals";
                Class1.element[15].number = "22";
                Class1.element[15].mass = "47.90 ";
                Class1.element[15].level = "2-8-10-2";
                Class1.element[15].History = "Discovered by William Gregor in 1791";
                Class1.element[15].formula = "TiO2";
                Class1.element[16].name = "Zirconium ";
                Class1.element[16].symbol = "Zr";
                Class1.element[16].Classification = "Transition metals";
                Class1.element[16].number = "40";
                Class1.element[16].mass = "91.22";
                Class1.element[16].level = "2-8-18-10-2";
                Class1.element[16].History = "Discovered by Martin Klaproth in 1789";
                Class1.element[16].formula = "ZrCl4";
                Class1.element[17].name = "Hafnium ";
                Class1.element[17].symbol = "Hf";
                Class1.element[17].Classification = "Transition metals";
                Class1.element[17].number = "72";
                Class1.element[17].mass = "178.49";
                Class1.element[17].level = "2-8--18-32-10-2";
                Class1.element[17].History = "Discovered by Dirk Coster in 1923";
                Class1.element[17].formula = "HfO2";
                Class1.element[18].name = "Rutherfordium ";
                Class1.element[18].symbol = "Rf";
                Class1.element[18].Classification = "Transition metals";
                Class1.element[18].number = "104";
                Class1.element[18].mass = "261.0";
                Class1.element[18].level = "2-8-18-32-32-10-2";
                Class1.element[18].History = "Discovered by Lord Rutherford of Nelson";
                Class1.element[18].formula = "Rf";
                Class1.element[19].name = "Vanadium ";
                Class1.element[19].symbol = "V";
                Class1.element[19].Classification = "Transition metals";
                Class1.element[19].number = "23";
                Class1.element[19].mass = "50.9415 ";
                Class1.element[19].level = "2-8-11-2";
                Class1.element[19].History = "Discovered by Nils Sefstrom in 1830";
                Class1.element[19].formula = "V2O5";
                Class1.element[20].name = "Niobium ";
                Class1.element[20].symbol = "Nb";
                Class1.element[20].Classification = "Transition metals";
                Class1.element[20].number = "41";
                Class1.element[20].mass = "92.90638";
                Class1.element[20].level = "2-8-18-12-1";
                Class1.element[20].History = "Discovered by Charles Hatchett 1801";
                Class1.element[20].formula = "Nb2O5";
                Class1.element[21].name = "Tantalum ";
                Class1.element[21].symbol = "Ta";
                Class1.element[21].Classification = "Transition metals";
                Class1.element[21].number = "73";
                Class1.element[21].mass = "180.9479";
                Class1.element[21].level = "2-8-18-32-11-2";
                Class1.element[21].History = "Discovered by Anders Ekeberg in 1802";
                Class1.element[21].formula = "TaC";
                Class1.element[22].name = "Dubnium ";
                Class1.element[22].symbol = "Db";
                Class1.element[22].Classification = "Transition metals";
                Class1.element[22].number = "105";
                Class1.element[22].mass = "262.0";
                Class1.element[22].level = "2-8-18-32-32-11-2";
                Class1.element[22].History = "Discovered Albert Ghiorso in 1970";
                Class1.element[22].formula = "Db";
                Class1.element[23].name = "Chromium";
                Class1.element[23].symbol = "Cr";
                Class1.element[23].Classification = "Transition metals";
                Class1.element[23].number = "24";
                Class1.element[23].mass = "51.9961";
                Class1.element[23].level = "2-8-13-1";
                Class1.element[23].History = "Discovered by Vaughlin in 1797";
                Class1.element[23].formula = "CrCl3";
                Class1.element[24].name = "Molybdenum ";
                Class1.element[24].symbol = "Mo";
                Class1.element[24].Classification = "Transition metals";
                Class1.element[24].number = "42";
                Class1.element[24].mass = "95.94 ";
                Class1.element[24].level = "2-8-18-13-1";
                Class1.element[24].History = "Discovered by Carl Wilhelm Scheele in 1778";
                Class1.element[24].formula = "MoS2";
                Class1.element[25].name = "Tungsten ";
                Class1.element[25].symbol = "W";
                Class1.element[25].Classification = "Transition metals";
                Class1.element[25].number = "74";
                Class1.element[25].mass = "183.84";
                Class1.element[25].level = "2-8-18-32-12-2";
                Class1.element[25].History = "Discovered by Fausto and Juan Jose de Elhuyar in 1783";
                Class1.element[25].formula = "WCWWL4";
                Class1.element[26].name = "Seaborgium ";
                Class1.element[26].symbol = "Sg";
                Class1.element[26].Classification = "Transition metals";
                Class1.element[26].number = "106";
                Class1.element[26].mass = "263.0";
                Class1.element[62].level = "2-8-18-32-32-12";
                Class1.element[26].History = "Discovered by Albert Ghiorso in 1974";
                Class1.element[26].formula = "Sg";
                Class1.element[27].name = "Manganese ";
                Class1.element[27].symbol = "Mn";
                Class1.element[27].Classification = "Transition metals";
                Class1.element[27].number = "25";
                Class1.element[27].mass = "54.93805";
                Class1.element[27].level = "2-8-13-2";
                Class1.element[27].History = "Discovered Johann Gahn in 1774";
                Class1.element[27].formula = "MnO2";
                Class1.element[28].name = "Technetium ";
                Class1.element[28].symbol = "Tc";
                Class1.element[28].Classification = "Transition metals";
                Class1.element[28].number = "43";
                Class1.element[28].mass = "98.0";
                Class1.element[28].level = "2-8-18-14-1";
                Class1.element[28].History = "Discovered by Carlo Perrier in 1937";
                Class1.element[28].formula = "Tc";
                Class1.element[29].name = "Rhenium ";
                Class1.element[29].symbol = "Re";
                Class1.element[29].Classification = "Transition metals";
                Class1.element[29].number = "75";
                Class1.element[29].mass = "186.207 ";
                Class1.element[29].level = "2-8-18-32-13-2";
                Class1.element[29].History = "Discovered by Walter Noddack in 1925";
                Class1.element[29].formula = "ReCl5";
                Class1.element[30].name = "Bohrium ";
                Class1.element[30].symbol = "Bh";
                Class1.element[30].Classification = "Transition metals";
                Class1.element[30].number = "107";
                Class1.element[30].mass = "262.0";
                Class1.element[30].level = "2-8-81-32-32-13-2";
                Class1.element[30].History = "Discovered Peter Armbruster and Gottfried Munzenber in 1976";
                Class1.element[30].formula = "Bh";
                Class1.element[31].name = "Iron ";
                Class1.element[31].symbol = "Fe";
                Class1.element[31].Classification = "Transition metals";
                Class1.element[31].number = "26";
                Class1.element[31].mass = "55.845 ";
                Class1.element[31].level = "2-8-14-2";
                Class1.element[31].History = "Discovered by The ancients";
                Class1.element[31].formula = "Fe2O3";
                Class1.element[32].name = "Ruthenium ";
                Class1.element[32].symbol = "Ru";
                Class1.element[32].Classification = "Transition metals";
                Class1.element[32].number = "44";
                Class1.element[32].mass = "101.07";
                Class1.element[32].level = "2-8-18-15-1";
                Class1.element[32].History = "Discovered by Karl Klaus in 1844 ";
                Class1.element[32].formula = "RUBr3";
                Class1.element[33].name = "Osmium ";
                Class1.element[33].symbol = "Os";
                Class1.element[33].Classification = "Transition metals";
                Class1.element[33].number = "76";
                Class1.element[33].mass = "190.23 ";
                Class1.element[33].level = "2-8-18-32-14-2";
                Class1.element[33].History = "Discovered by Smithson Tennant in 1803";
                Class1.element[33].formula = "OsCl3";
                Class1.element[34].name = "Hassium ";
                Class1.element[34].symbol = "Hs";
                Class1.element[34].Classification = "Transition metals";
                Class1.element[34].number = "108";
                Class1.element[34].mass = "265.0";
                Class1.element[34].level = "2-8-18-32-32-14-2";
                Class1.element[34].History = "Discovered Peter Armbruster and Gottfried Munzenber in 1984";
                Class1.element[34].formula = "Hs";
                Class1.element[35].name = "Cobalt ";
                Class1.element[35].symbol = "Co";
                Class1.element[35].Classification = "Transition metals";
                Class1.element[35].number = "27";
                Class1.element[35].mass = "58.9332 ";
                Class1.element[35].level = "2-8-15-2";
                Class1.element[35].History = "Discovered by George Brandt in 1737";
                Class1.element[35].formula = "CoCl2";
                Class1.element[36].name = "Rhodium ";
                Class1.element[36].symbol = "Rh";
                Class1.element[36].Classification = "Transition metals";
                Class1.element[36].number = "45";
                Class1.element[36].mass = "102.9055";
                Class1.element[36].level = "2-8-18-16-1";
                Class1.element[36].History = "Discovered by William Wollaston in 1803";
                Class1.element[36].formula = "Rh(No3)3";
                Class1.element[37].name = "Iridium ";
                Class1.element[37].symbol = "Ir";
                Class1.element[37].Classification = "Transition metals";
                Class1.element[37].number = "77";
                Class1.element[37].mass = "192.217";
                Class1.element[37].level = "2-8-18-32-15-2";
                Class1.element[37].History = "Discovered by Smithson Tennant in 1804";
                Class1.element[37].formula = "IrO2";
                Class1.element[38].name = "Meitnerium ";
                Class1.element[38].symbol = "Mt";
                Class1.element[38].Classification = "unknown proprties";
                Class1.element[38].number = "109";
                Class1.element[38].mass = "266.0";
                Class1.element[38].level = "2-8-18-32-32-15-2";
                Class1.element[38].History = "Discovered by Heavy Ion Research Laboratory in 1982";
                Class1.element[38].formula = "Mt";
                Class1.element[39].name = "Nickel ";
                Class1.element[39].symbol = "Ni";
                Class1.element[39].Classification = "Transition metals";
                Class1.element[39].number = "28";
                Class1.element[39].mass = "58.6934";
                Class1.element[39].level = "2-8-16-2";
                Class1.element[39].History = "Discovered by Alex Constedt 1751";
                Class1.element[39].formula = "NiCl2";
                Class1.element[40].name = "Palladium ";
                Class1.element[40].symbol = "Pd";
                Class1.element[40].Classification = "Transition metals";
                Class1.element[40].number = "46";
                Class1.element[40].mass = "106.42";
                Class1.element[40].level = "2-8-18-18-0";
                Class1.element[40].History = "Discovered by William Wollaston in 1803";
                Class1.element[40].formula = "PdCl2";
                Class1.element[41].name = "Platinum ";
                Class1.element[41].symbol = "Pt";
                Class1.element[41].Classification = "Transition metals";
                Class1.element[41].number = "78";
                Class1.element[41].mass = "195.078";
                Class1.element[41].level = "2-8-18-32-17-1";
                Class1.element[41].History = "Discovered by Julius Scaliger in 1735";
                Class1.element[41].formula = "Pt";
                Class1.element[42].name = "Darmstadtium ";
                Class1.element[42].symbol = "Ds";
                Class1.element[42].Classification = "unknown proprties";
                Class1.element[42].number = "110";
                Class1.element[42].mass = "269.0";
                Class1.element[42].level = "2-8-18-32-32-17-1";
                Class1.element[42].History = "Discovered Albert Ghiorso in 1970";
                Class1.element[42].formula = "Ds";
                Class1.element[43].name = "Copper ";
                Class1.element[43].symbol = "Cu";
                Class1.element[43].Classification = "Transition metals";
                Class1.element[43].number = "29";
                Class1.element[43].mass = "63.546 ";
                Class1.element[43].level = "2-8-18-1";
                Class1.element[43].History = "Discovered by The ancients";
                Class1.element[43].formula = "CuCl2";
                Class1.element[44].name = "Silver";
                Class1.element[44].symbol = "Ag";
                Class1.element[44].Classification = "Transition Metal";
                Class1.element[44].number = "47";
                Class1.element[44].mass = "107.8682 amu";
                Class1.element[44].level = "2-8-18-18-1";
                Class1.element[44].History = "Discovered by The ancients";
                Class1.element[44].formula = "AgNO3";
                Class1.element[45].name = "Gold";
                Class1.element[45].symbol = "Au";
                Class1.element[45].Classification = "Transition Metal";
                Class1.element[45].number = "79";
                Class1.element[45].mass = "196.96655 amu";
                Class1.element[45].level = "2-8-18-32-18-1";
                Class1.element[45].History = "Discovered  c.c.3000 BC";
                Class1.element[45].formula = "Au,C2H6AuClS";
                Class1.element[46].name = "Roentgenium";
                Class1.element[46].symbol = "Rg";
                Class1.element[46].Classification = "unknown proprties";
                Class1.element[46].number = "111";
                Class1.element[46].mass = "272.0 amu";
                Class1.element[46].level = "2-8-18-32-32-18-1";
                Class1.element[46].History = "Discovered by Hofmann , Sigurd 1994";
                Class1.element[46].formula = "Rg";
                Class1.element[47].name = "Zinc";
                Class1.element[47].symbol = "Zn";
                Class1.element[47].Classification = "Transition Metal";
                Class1.element[47].number = "30";
                Class1.element[47].mass = "5.39 amu";
                Class1.element[47].level = "2-8-18-2";
                Class1.element[47].History = "Discovered by  Andreas Marggraf in  1746";
                Class1.element[47].formula = "Zn,ZnCl2";
                Class1.element[48].name = "cadmium";
                Class1.element[48].symbol = "Cd";
                Class1.element[48].Classification = "Transition Metal";
                Class1.element[48].number = "48";
                Class1.element[48].mass = "112.411 amu";
                Class1.element[48].level = "2-8-18-18-2";
                Class1.element[48].History = "Discovered by Fredrich Stromeyer in 1817 ";
                Class1.element[48].formula = "Cd3N2";
                Class1.element[49].name = "Mercury";
                Class1.element[49].symbol = "Hg";
                Class1.element[49].Classification = "Transition Metal";
                Class1.element[49].number = "80";
                Class1.element[49].mass = "200.59 amu";
                Class1.element[49].level = "2-8-18-32-18-2";
                Class1.element[49].History = "Discovered by the ancients";
                Class1.element[49].formula = "HgF2 , Hg(CNO)2";
                Class1.element[50].name = "Copernicium";
                Class1.element[50].symbol = "Cn";
                Class1.element[50].Classification = "Transition Metal";
                Class1.element[50].number = "112";
                Class1.element[50].mass = "277.0 amu";
                Class1.element[50].level = "2-8-18-32-32 -18-2";
                Class1.element[50].History = "Discovered by S.Hofmann , V.Nionv and F.P.Hessbuger in 1996 ";
                Class1.element[50].formula = "Cn";
                Class1.element[51].name = "Boron";
                Class1.element[51].symbol = "B";
                Class1.element[51].Classification = "Metalloid ";
                Class1.element[51].number = "5";
                Class1.element[51].mass = "10.811 amu";
                Class1.element[51].level = "2-3";
                Class1.element[51].History = "Discovered by Sir Humphry Davy and J.L Gay-Lussac in 1808 ";
                Class1.element[51].formula = "B,B5H9,B6H12";
                Class1.element[52].name = "Aluminum ";
                Class1.element[52].symbol = "Al";
                Class1.element[52].Classification = "Other Metals";
                Class1.element[52].number = "13";
                Class1.element[52].mass = "26.98 amu ";
                Class1.element[52].level = "2-8-3";
                Class1.element[52].History = "Discovered by Hans Christian Oersted in 1825 ";
                Class1.element[52].formula = " Al2O3 , Al(OH)3 ";
                Class1.element[53].name = "Gallium";
                Class1.element[53].symbol = "Ga";
                Class1.element[53].Classification = "Other Metals";
                Class1.element[53].number = "31";
                Class1.element[53].mass = "69.723 amu ";
                Class1.element[53].level = "2-8-18-3";
                Class1.element[53].History = "Discovered by French chemist Paul E. Lecoq de Boisbaudran through \na spectroscope in 1875";
                Class1.element[53].formula = "GaSe , GaS, Ga2Te3 ";
                Class1.element[54].name = "Indium ";
                Class1.element[54].symbol = "In ";
                Class1.element[54].Classification = "Other Metals";
                Class1.element[54].number = "49 ";
                Class1.element[54].mass = "114.818 amu  ";
                Class1.element[54].level = "2-8-18-18-3";
                Class1.element[54].History = "Discovered by Ferdinand Reich 1863";
                Class1.element[54].formula = "In ";
                Class1.element[55].name = "Thallium";
                Class1.element[55].symbol = "Tl";
                Class1.element[55].Classification = "Other Metals";
                Class1.element[55].number = "81  ";
                Class1.element[55].mass = "204.3833 amu ";
                Class1.element[55].level = "2-8-18-32-18-3";
                Class1.element[55].History = "Discovered by Sir William Crookes in 1861";
                Class1.element[55].formula = "	Tl2O ";
                Class1.element[56].name = "Nihonium";
                Class1.element[56].symbol = "Nh";
                Class1.element[56].Classification = "unknown proprties";
                Class1.element[56].number = "113  ";
                Class1.element[56].mass = "unknown";
                Class1.element[56].level = "2-8-18-32-32-18-3";
                Class1.element[56].History = "Discovered by Scientists from the Joint Institute for Nuclear Research in Dubna,\nRussia, and Lawrence Livermore National Laboratory in California in 2003";
                Class1.element[56].formula = "	NhH, NhF3 ";
                Class1.element[57].name = "Carbon";
                Class1.element[57].symbol = "C";
                Class1.element[57].Classification = "Non-metal ";
                Class1.element[57].number = "6";
                Class1.element[57].mass = "12.0107 amu";
                Class1.element[57].level = "2-4";
                Class1.element[57].History = "Discovered by The ancients";
                Class1.element[57].formula = "	H2CO3 , CO , C6O6";
                Class1.element[58].name = "Silicon ";
                Class1.element[58].symbol = "Si ";
                Class1.element[58].Classification = "Metalloid";
                Class1.element[58].number = "14";
                Class1.element[58].mass = "28.0855 amu ";
                Class1.element[58].level = "2-8-4";
                Class1.element[58].History = "Discovered by Jons Berzelius in 1823";
                Class1.element[58].formula = " AlSiO,Al2O5Si";
                Class1.element[59].name = "Germanium ";
                Class1.element[59].symbol = "Ga";
                Class1.element[59].Classification = "Metalloid";
                Class1.element[59].number = "32";
                Class1.element[59].mass = "72.61 amu";
                Class1.element[59].level = "2-8-18-4";
                Class1.element[59].History = "Discovered by Clemens Winkler in 1886";
                Class1.element[59].formula = "Bi4Ge3O12,BGO";
                Class1.element[60].name = "Tin";
                Class1.element[60].symbol = "Sn";
                Class1.element[60].Classification = "Other Metals";
                Class1.element[60].number = "50";
                Class1.element[60].mass = "118.71 amu";
                Class1.element[60].level = "2-8-18-18-4";
                Class1.element[60].History = "Discovered by The ancients";
                Class1.element[60].formula = "SnO2";
                Class1.element[61].name = "Lead ";
                Class1.element[61].symbol = "Pb";
                Class1.element[61].Classification = "Other Metals";
                Class1.element[61].number = "82";
                Class1.element[61].mass = " 207.2 amu";
                Class1.element[61].level = "2-8-18-32-18-4";
                Class1.element[61].History = "Discovered by Middle Easterns (7000 BCE)";
                Class1.element[61].formula = "Pb4(OH)4";
                Class1.element[62].name = "Flerovium ";
                Class1.element[62].symbol = "Fl";
                Class1.element[62].Classification = "unknown proprities";
                Class1.element[62].number = "114";
                Class1.element[62].mass = " 289 amu";
                Class1.element[62].level = "2-8-18-32-32-18-4";
                Class1.element[62].History = "Discovered by 	Dubna (Joint Institute for Nuclear Research) in Russia, jan 1999";
                Class1.element[62].formula = "FlO2 , FlH2";
                Class1.element[63].name = "Nitrogen";
                Class1.element[63].symbol = "N";
                Class1.element[63].Classification = "Non-metal ";
                Class1.element[63].number = "7";
                Class1.element[63].mass = "14.0 amu ";
                Class1.element[63].level = "2-5";
                Class1.element[63].History = "Discovered by Rutherford in 1772";
                Class1.element[63].formula = "NO , NH3";
                Class1.element[64].name = "Phosphorus";
                Class1.element[64].symbol = "P";
                Class1.element[64].Classification = "Non-metal ";
                Class1.element[64].number = "15";
                Class1.element[64].mass = "30.97 amu";
                Class1.element[64].level = "2-8-5";
                Class1.element[64].History = "Discovered by Hennig Brandt in 1669";
                Class1.element[64].formula = "P4O10 , Ca3(PO4)2 ";
                Class1.element[65].name = "Arsenic ";
                Class1.element[65].symbol = "As";
                Class1.element[65].Classification = "Metalloid";
                Class1.element[65].number = "33";
                Class1.element[65].mass = "74.9216 amu";
                Class1.element[65].level = "2-8-18-5";
                Class1.element[65].History = "Discovered by Early Bronze Age (2500 BC)";
                Class1.element[65].formula = "As4S4 , As2Te− ";
                Class1.element[66].name = "Antimony ";
                Class1.element[66].symbol = "Sb ";
                Class1.element[66].Classification = "Metalloid";
                Class1.element[66].number = "51";
                Class1.element[66].mass = "121.76 amu";
                Class1.element[66].level = "2-8-18-18-5";
                Class1.element[66].History = "Discovered 3000 BC";
                Class1.element[66].formula = "SbH3 , Sb2(C6H5)4 ";
                Class1.element[67].name = "Bismuth";
                Class1.element[67].symbol = "Bi ";
                Class1.element[67].Classification = "Other Metals";
                Class1.element[67].number = "83";
                Class1.element[67].mass = "208.98038 amu";
                Class1.element[67].level = "2-8-18-32-18-5";
                Class1.element[67].History = "Discovered 3000 BC";
                Class1.element[67].formula = "Bi ";
                Class1.element[68].name = "Umunpentium";
                Class1.element[68].symbol = "Uup ";
                Class1.element[68].Classification = "unknown properties";
                Class1.element[68].number = "115";
                Class1.element[68].mass = "unknown";
                Class1.element[68].level = "2-8-18-32-32-18-5";
                Class1.element[68].History = "Discovered 	Scientists from the Joint Institute for Nuclear\n Research in Dubna, Russia, and Lawrence\n Livermore National Laboratory in California in 2003";
                Class1.element[68].formula = "Mc";
                Class1.element[69].name = "Oxygen";
                Class1.element[69].symbol = "O ";
                Class1.element[69].Classification = "Non-metal ";
                Class1.element[69].number = "8";
                Class1.element[69].mass = "15.99 amu ";
                Class1.element[69].level = "2-6";
                Class1.element[69].History = "Discovered by Joseph Priestly in 1774";
                Class1.element[69].formula = "H2O ,  SiO2 ";
                Class1.element[70].name = "Sulfur";
                Class1.element[70].symbol = "S";
                Class1.element[70].Classification = "Non-metal ";
                Class1.element[70].number = "16";
                Class1.element[70].mass = "32.066 amu";
                Class1.element[70].level = "2-8-6";
                Class1.element[70].History = "Discovered by Chinese (before 2000 BCE)";
                Class1.element[70].formula = "H2S , H2SO4 ";
                Class1.element[71].name = "Selenium";
                Class1.element[71].symbol = "Se";
                Class1.element[71].Classification = "Non-metal ";
                Class1.element[71].number = "34";
                Class1.element[71].mass = "78.96 amu";
                Class1.element[71].level = "2-8-18-6";
                Class1.element[71].History = "Discovered by Jons Berzelius 1817";
                Class1.element[71].formula = "H2SeO3 , Na2SeO3 ";
                Class1.element[72].name = "Tellurium";
                Class1.element[72].symbol = "Te";
                Class1.element[72].Classification = "Metalloid ";
                Class1.element[72].number = "52";
                Class1.element[72].mass = "127.6 amu";
                Class1.element[72].level = "2-8-18-18-6";
                Class1.element[72].History = "Discovered by Franz Muller von Reichenstein in 1782";
                Class1.element[72].formula = "NiTe2 , AgAuTe4 ";
                Class1.element[73].name = "Polonium";
                Class1.element[73].symbol = "Po";
                Class1.element[73].Classification = "Metalloid ";
                Class1.element[73].number = "84";
                Class1.element[73].mass = "(209.0) amu";
                Class1.element[73].level = "2-8-18-32-18-6";
                Class1.element[73].History = "Discovered by Pierre and Marie Curie in 1898";
                Class1.element[73].formula = "PbPo  , PoH2 ";
                Class1.element[74].name = "Livermorium ";
                Class1.element[74].symbol = "Lv";
                Class1.element[74].Classification = "unknown proprties";
                Class1.element[74].number = "116";
                Class1.element[74].mass = "unknown ";
                Class1.element[74].level = "2-8-18-32-32-18-6 ";
                Class1.element[74].History = "Discovered by The Lawrence Berkeley National Laboratory";
                Class1.element[74].formula = "LvH2";
                Class1.element[75].name = "Fluorine  ";
                Class1.element[75].symbol = "F";
                Class1.element[75].Classification = "Halogen";
                Class1.element[75].number = "9";
                Class1.element[75].mass = "18.998404 amu ";
                Class1.element[75].level = "2-7 ";
                Class1.element[75].History = "Discovered by Moissan in 1886";
                Class1.element[75].formula = "CaF2 , Na3AlF6 , CCl2F2";
                Class1.element[76].name = "Chlorine";
                Class1.element[76].symbol = "Cl";
                Class1.element[76].Classification = "Halogen";
                Class1.element[76].number = "17";
                Class1.element[76].mass = "35.4527 amu";
                Class1.element[76].level = "2-8-7 ";
                Class1.element[76].History = "Discovered by Carl Wilhelm Scheele in 1774";
                Class1.element[76].formula = "HCl , NaCl , CCl2F2";
                Class1.element[77].name = "Bromine";
                Class1.element[77].symbol = "Br";
                Class1.element[77].Classification = "Halogen";
                Class1.element[77].number = "35";
                Class1.element[77].mass = "79.904 amu";
                Class1.element[77].level = "2-8-18-7 ";
                Class1.element[77].History = "Discovered by Anthoine Balard in 1826";
                Class1.element[77].formula = "FeBr3 ,  BBr3  , HBr";
                Class1.element[78].name = "Iodine";
                Class1.element[78].symbol = "I";
                Class1.element[78].Classification = "Halogen";
                Class1.element[78].number = "53";
                Class1.element[78].mass = "126.90447 amu";
                Class1.element[78].level = "2-8-18-18-7 ";
                Class1.element[78].History = "Discovered by Bernard Courtois in 1811";
                Class1.element[78].formula = " HI  ,  HOI  , IO3-";
                Class1.element[79].name = "Astatine ";
                Class1.element[79].symbol = "At";
                Class1.element[79].Classification = "Halogen";
                Class1.element[79].number = "85";
                Class1.element[79].mass = "(210.0) amu";
                Class1.element[79].level = "2-8-18-32-18-7 ";
                Class1.element[79].History = "Discovered by D.R. Corson 1940";
                Class1.element[79].formula = " C6H5AtCl2  ,  La(AtO3)3 ";
                Class1.element[80].name = "Unwmseptum ";
                Class1.element[80].symbol = "Uus";
                Class1.element[80].Classification = "unknown";
                Class1.element[80].mass = "unknown";
                Class1.element[80].level = "2-8-18-32-32-18-7 ";
                Class1.element[80].History = "Undiscovered";
                Class1.element[80].formula = "unknown ";
                Class1.element[81].name = "Helium ";
                Class1.element[81].symbol = "He";
                Class1.element[81].Classification = "Noble Gas";
                Class1.element[81].number = "2";
                Class1.element[81].mass = "4.002602 amu ";
                Class1.element[81].level = "2";
                Class1.element[81].History = "Discovered by Sir Ramsey in 1895";
                Class1.element[81].formula = " HeH+ , LiHe  ";
                Class1.element[82].name = "Neon";
                Class1.element[82].symbol = "Ne";
                Class1.element[82].Classification = "Noble Gas";
                Class1.element[82].number = "10";
                Class1.element[82].mass = " 20.1797 amu";
                Class1.element[82].level = "2-8";
                Class1.element[82].History = "Discovered by Sir Ramsey in 1898";
                Class1.element[82].formula = "  [NeAr]+ , [NeH]+ ";
                Class1.element[83].name = "Argon";
                Class1.element[83].symbol = "Ar";
                Class1.element[83].Classification = "Noble Gas";
                Class1.element[83].number = "18";
                Class1.element[83].mass = "39.948 amu";
                Class1.element[83].level = "2-8-8";
                Class1.element[83].History = "Discovered by Sir Ramsey in 1894";
                Class1.element[83].formula = "Ar(H2)2 ,  ArH+ ";
                Class1.element[84].name = "Krypton";
                Class1.element[84].symbol = "Kr";
                Class1.element[84].Classification = "Noble Gas";
                Class1.element[84].number = "36";
                Class1.element[84].mass = "83.8 amu";
                Class1.element[84].level = "2-8-18-8";
                Class1.element[84].History = "Discovered by Sir Ramsey in 1898";
                Class1.element[84].formula = "KrF2 ";
                Class1.element[85].name = "Xenon";
                Class1.element[85].symbol = "Xe";
                Class1.element[85].Classification = "Noble Gas";
                Class1.element[85].number = "54";
                Class1.element[85].mass = "131.29 amu";
                Class1.element[85].level = "2-8-18-18-8";
                Class1.element[85].History = "Discovered by Sir Ramsey in 1898";
                Class1.element[85].formula = "XeF2 , XeCl2";
                Class1.element[86].name = "Radon";
                Class1.element[86].symbol = "Rn";
                Class1.element[86].Classification = "Noble Gas";
                Class1.element[86].number = "86";
                Class1.element[86].mass = "(222.0) amu";
                Class1.element[86].level = "2-8-18-32-18-8";
                Class1.element[86].History = "Discovered by Fredrich Ernst Dorn in 1898";
                Class1.element[86].formula = "RnF , Ba2RnO6";
                Class1.element[87].name = "Oganesson";
                Class1.element[87].symbol = "Og";
                Class1.element[87].Classification = "unknown proprties";
                Class1.element[87].number = "118";
                Class1.element[87].mass = "unknown";
                Class1.element[87].level = "2-8-18-32-32-18-8";
                Class1.element[87].History = "Discovered by Team of Berkeley Lab scientists, 1999";
                Class1.element[87].formula = "OgH , OgF2";
                pictureBox1.BackgroundImage= Image.FromFile(Application.StartupPath + @"\" + Class1.col + ".jpg");
                showLesson(Class1.col);


        }
        public void showLesson(int num)
        {
            if (num >=0 && num < 88) 
            {
                label10.Text = Class1.element[num].name;
                label11.Text = Class1.element[num].symbol;
                label12.Text = Class1.element[num].Classification;
                label13.Text = Class1.element[num].number;
                label14.Text = Class1.element[num].mass;
                label15.Text = Class1.element[num].level;
                label9.Text = Class1.element[num].History;
                label16.Text = Class1.element[num].formula;
                Image img = Image.FromFile(Application.StartupPath + @"\" + num + ".jpg");
                pictureBox1.Image = img;
            }
            if(num == 87){button2.Enabled=false;}
            else { button2.Enabled = true; }
            if (num == 0) { button1.Enabled = false; }
            else { button1.Enabled = true; }
 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElementsScientists frm = new ElementsScientists();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
       
        private void button2_Click(object sender, EventArgs e)
        {
            //button for next
            if (vlaidateChosenElement()) {

            if ((comboBox1.Text).Equals("I Want To Move By Row"))
            {
                int num = Class1.col;
                for (int i = 0; i < Class1.rowArr.Length; i++)
                {
                    if (i < Class1.rowArr.Length - 1)
                    {
                        if (Class1.col.Equals(Class1.rowArr[i]))
                        {
                            int num2 = Class1.rowArr[i + 1];
                            showLesson(num2);
                            Class1.col = num2;
                            break;
                        }
                        }//end if 
                    }//end for
            }//end  if 
            else  if ((comboBox1.Text).Equals("I Want To Move By Blocks"))
            {
                int num = Class1.col;
                for (int i = 0; i < Class1.BlockArr.Length; i++)
                {
                    if (Class1.col.Equals(Class1.BlockArr[i]))
                    {
                        if (i < Class1.BlockArr.Length - 1)
                        {
                            int num2 = Class1.BlockArr[i + 1];
                            showLesson(num2);
                            Class1.col = num2;
                            break;
                        }
                    }//end if 
                }//end for
            }//end  if 
            else 
            {
                int num = Class1.col;
                showLesson(num + 1);
                Class1.col = Class1.col + 1;
            }
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vlaidateChosenElement())
            { 

            if ((comboBox1.Text).Equals("I Want To Move By Row")){
            
                int num = Class1.col;
                for (int i = 0; i < Class1.rowArr.Length; i++)
                {
                    if (Class1.col.Equals(Class1.rowArr[i]))
                    {
                        if (i > 0)
                        {

                            int num2 = Class1.rowArr[i - 1];
                            showLesson(num2);
                            Class1.col = num2;
                            break;

                        }//end if 
                    }//end if
                    }//end for
                
            }//end  if 
            else  if ((comboBox1.Text).Equals("I Want To Move By Blocks"))
            {
                int num = Class1.col;
                for (int i = 0; i >= 0 && i < Class1.BlockArr.Length; i++)
                {
                    if (Class1.col.Equals(Class1.BlockArr[i]))
                    {
                        if (i > 0)
                        {
                            int num2 = Class1.BlockArr[i - 1];
                            showLesson(num2);
                            Class1.col = num2;
                            break;
                        }
                    }//end if 
                }//end for
            }//end  if 
            else 
            {
                int num = Class1.col;
                showLesson(num - 1);
                Class1.col = Class1.col - 1;
            }
        }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            if (Class1.ExitConf())
            {
                Application.Exit();
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            TestMyK test = new TestMyK();
            test.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TestMyK test = new TestMyK();
            test.Show();
            this.Hide();
        }

        private void Nav_validating(object sender, CancelEventArgs e)
        {
            vlaidateChosenElement();
        }
        private bool vlaidateChosenElement()
        {
            bool flag = true;
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Choose the navigation type first!");
                flag = false;
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }
            return flag;
        }


       

      

    }
}
