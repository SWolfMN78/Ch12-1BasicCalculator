using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_1BasicCalculator
{

    public partial class Form1 : Form
    {
        decimal 7;
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Create a basic calculator form that lets the user perform your basic +, -, *, / operation as well 
        /// as some added parts (square root = sqrt, and recepricol = 1/X).  All operations will be performed by
        /// a class.
        /// 
        /// Current found issue the button seems to flip +/- to -/+ and viceversa.  This issue is causing problems
        /// with 1/X
        /// </summary>

        

        #region Buttons

        private void btn7_Click(object sender, EventArgs e)
        {
            lblTextDisplay.Text = "7";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblTextDisplay.Text = "4";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTextDisplay.Text = "";
            lblEquationAnswer.Text = "0";

        }



        #endregion


    }
}
