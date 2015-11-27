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

        //one list to hold the numbers and one list to hold the Operands for the equations that will be worked.
        public List<string> NumList = new List<string>();
        public List<string> Operand = new List<string>();

        private void AddNumberToCurrentValue(string typedNumber)
        {
            NumList[NumList.Count - 1] += typedNumber;
            lblEquationAnswer.Text = NumList[NumList.Count - 1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ClearInfo();
        }

        private void ClearInfo()
        {
            //clear the current information in the numlist.
            NumList.Clear();
            //add a new item to the numlist.
            NumList.Add("");
            lblTextDisplay.Text = "";
            lblEquationAnswer.Text = "0";
        }
        
        #region Buttons

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }
        
        private void btn0_Click(object sender, EventArgs e)
        {
            //when it calls this method it 
            AddNumberToCurrentValue("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddNumberToCurrentValue("9");
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //placed "!" at the start which is short hand for saying does not contain a "." then add a . to the list
            if (!NumList[NumList.Count -1].Contains("."))
            {
                AddNumberToCurrentValue(".");
            }
            

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {

        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
