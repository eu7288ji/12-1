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
            if (sender == btn0) { Calculator.Equate(btn0, txtResult);}
            if (sender == btn1) { Calculator.Equate(btn1, txtResult);}
            if (sender == btn2) { Calculator.Equate(btn2, txtResult);}
            if (sender == btn3) { Calculator.Equate(btn3, txtResult);}
            if (sender == btn4) { Calculator.Equate(btn4, txtResult);}
            if (sender == btn5) { Calculator.Equate(btn5, txtResult);}
            if (sender == btn6) { Calculator.Equate(btn6, txtResult);}
            if (sender == btn7) { Calculator.Equate(btn7, txtResult);}
            if (sender == btn8) { Calculator.Equate(btn8, txtResult);}
            if (sender == btn9) { Calculator.Equate(btn9, txtResult);}
            if (sender == btnAdd) { Calculator.Equate(btnAdd, txtResult);}
            if (sender == btnSubtract) { Calculator.Equate(btnSubtract, txtResult);}
            if (sender == btnMultiply) { Calculator.Equate(btnMultiply, txtResult); }
            if (sender == btnDivide) { Calculator.Equate(btnDivide, txtResult);}
            if (sender == btnDecimal) { Calculator.Equate(btnDecimal, txtResult); }
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
            txtResult.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Calculator.Back(txtResult);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
