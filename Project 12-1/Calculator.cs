using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_1
{
    class Calculator //created class for calculator form
    {
        public static void Calculate (TextBox Inside) //calculation called for equals button 
        {
            
            string num = Convert.ToString(Inside.Text);
            string[] nstring = new string[2];
            double[] ndub = new  double[2];
            char[] nchar = new char[] { '+', '/', '*', '-' };
            double sum = 0;
            if (num.EndsWith("+") || num.EndsWith("-") || num.EndsWith("*") || num.EndsWith("/"))
            {
                MessageBox.Show("Invalid calculation. Include another integer.");
            }
            else
            {
                if (!num.StartsWith("-")){ nstring = num.Split(nchar); }
                if (num.StartsWith("-"))
                {
                    string[] elevator = new string[2];
                    num = num.Remove(0, 1);
                    nstring = num.Split(nchar);
                    nstring[0] = "-" + nstring[0];
                }

                ndub = Array.ConvertAll(nstring, double.Parse);
                if (num.Contains('+')) { sum = ndub[0] + ndub[1]; }
                if (num.Contains('-')) { sum = ndub[0] - ndub[1]; }
                if (num.Contains('*')) { sum = ndub[0] * ndub[1]; }
                if (num.Contains('/')) { sum = ndub[0] / ndub[1]; }
                Inside.Text = Convert.ToString(sum);
            }   
        }

        public static void Equate (Button number, TextBox text)
        {

            string[] notIn = {"++", "+-", "+*", "+/", "--", "-+", "-/", "/-", "/+", "**", "-*", "//","/*", "*+", "*-","*/"};
            string OldNum = Convert.ToString(text.Text);
            string Num = Convert.ToString(number.Tag);
            string NewNum = OldNum + Num;

            for (int n = 0; n < notIn.Length; n++)
            {
                if (NewNum.Contains(notIn[n])){ MessageBox.Show("Only one operator allowed."); }

                else{ text.Text = NewNum; }
            }      
        }

        public static void Exponent (TextBox Inside)
        {
            double n1 = Convert.ToDouble(Inside.Text);
            double exponent = 1 / n1;
            Inside.Text = Convert.ToString(exponent);
        }

        public static void Negate (TextBox Inside)
        {
            string n2 = Convert.ToString(Inside.Text);
            string negate = "";

            if (n2.StartsWith("-")) { negate = n2.Trim('-'); }
            else { negate = "-" + n2; }

            Inside.Text = Convert.ToString(negate);
        }

        public static void Squareroot (TextBox Inside)
        {
            double n3 = Convert.ToDouble(Inside.Text);
            double sqrt = Math.Sqrt(n3);
            Inside.Text = Convert.ToString(sqrt);
        }

        public static void Back(TextBox Inside)
        {
            string n4 = Convert.ToString(Inside.Text);
            string back = n4.Remove(n4.Length - 1);
            Inside.Text = Convert.ToString(back); 
        }


    }
}
