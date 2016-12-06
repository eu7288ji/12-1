using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_12_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {

            if (sender == btn0) { Calculator.adder(btn0, txtResult);}
            if (sender == btn1) { Calculator.adder(btn1, txtResult);}
            if (sender == btn2) { Calculator.adder(btn2, txtResult);}
            if (sender == btn3) { Calculator.adder(btn3, txtResult);}
            if (sender == btn4) { Calculator.adder(btn4, txtResult);}
            if (sender == btn5) { Calculator.adder(btn5, txtResult);}
            if (sender == btn6) { Calculator.adder(btn6, txtResult);}
            if (sender == btn7) { Calculator.adder(btn7, txtResult);}
            if (sender == btn8) { Calculator.adder(btn8, txtResult);}
            if (sender == btn9) { Calculator.adder(btn9, txtResult);}
            if (sender == btnAdd) { Calculator.adder(btnAdd, txtResult);}
            if (sender == btnSubtract) { Calculator.adder(btnSubtract, txtResult);}
            if (sender == btnMultiply) { Calculator.adder(btnMultiply, txtResult); }
            if (sender == btnDivide) { Calculator.adder(btnDivide, txtResult);}
            if (sender == btnDot) { Calculator.adder(btnDot, txtResult); }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Calculator.Calculate(txtResult);      
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            Calculator.Exponent(txtResult);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            Calculator.Squareroot(txtResult);
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            Calculator.Negate(txtResult);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Calculator.Back(txtResult);
        }
    }
}
