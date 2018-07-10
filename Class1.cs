using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCIproject
{
    class Class1
    {

        public static string username = "";
        public static int falseTry = 0;
        public static int correctedTry = 0;
        public static bool game = false;
        public static bool test = false;
        public static int exerciseType;
        public static bool expert= false;
        public static int draggedCorrectly = 0;

        public static string message0 = "In this type you have to drag the element name below to its specific position on the table";
        public static string message1 = "In this type you have to drag the element name below to the row where it belong, you don not have to drag it to its specific position";
        public static string message2 = "In this type you have to drag the element name below to the column where it belong, you don not have to drag it to its specific position";
        public static string message3 = "In this type you have to drag the element name below to the specification(same colour) that it belong to, you don not have to drag it to its specific position";

        public static Elements[] element = new Elements[88];
        public static int col;
        public static int block;
        public static int[] rowArr = new int[] { 0, 81, 1, 7, 51, 57, 63, 69, 75, 82, 2, 8, 52, 58, 64, 70, 76, 83, 3, 9, 13, 15, 19, 23, 27, 31, 35, 39, 43, 47, 53, 59, 65, 71, 77, 84, 4, 10, 14, 16, 20, 24, 28, 32, 36, 40, 44, 48, 54, 60, 66, 72, 78, 85, 5, 11, 17, 21, 25, 29, 33, 37, 41, 45, 49, 55, 61, 67, 73, 79, 86, 6, 12, 18, 22, 26, 30, 34, 38, 42, 46, 50, 56, 62, 68, 74, 80, 87 };
        public static int[] BlockArr = new int[] { 0, 57, 63, 69, 64, 70, 71, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 39, 40, 41, 43, 44, 45, 47, 48, 49, 50, 51, 58, 59, 65, 66, 72, 52, 53, 54, 55, 60, 61, 67, 73, 57, 63, 64, 69, 70, 71, 75, 76, 77, 78, 79, 81, 82, 83, 84, 85, 86, 38, 42, 46, 56, 62, 68, 74, 80, 87 };



        public struct Elements
        {
            public string name;
            public string symbol;
            public string Classification;
            //public string Pictur;
            public string number;
            public string mass;
            public string level;
            public string History;
            public string formula;
        }


        public static bool ExitConf()
        {
            const string msg = "Are you sure you want to exit?";
            const string caption = "Exit confirmation";
            DialogResult res = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool desc()
        {
            DialogResult rslt = MessageBox.Show(message0, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rslt == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        public static bool desc1()
        {
            DialogResult rslt = MessageBox.Show(message1, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rslt == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        public static bool desc2()
        {
            DialogResult rslt = MessageBox.Show(message2, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rslt == DialogResult.OK)
            {
                return true;
            }
            return false;
        }


        public static bool desc3()
        {
            DialogResult rslt = MessageBox.Show(message3, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (rslt == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    
    
    
    
    
    
    
    
    
    }
}
