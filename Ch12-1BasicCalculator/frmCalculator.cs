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

    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Create a basic calculator form that lets the user perform your basic +, -, *, / operation as well 
        /// as some added parts (square root = sqrt, and recepricol = 1/X).  All operations will be performed by
        /// a class.
        

        ///one list to hold the numbers and one list to hold the Operands for the equations that will be worked.
        ///all of the information will be poured  into the two list then worked from here.  
        ///This will allow for a string or strings of information to be worked easily.
        /// </summary>

        //moved reading destination from oCalculator to oMemory
        //Self note - if the information is ever switched out of oMemory to oCalculator there is a good chance
        //of explosion due to everything reading from the child (oMemory).
        //oCalculator oCalculator = new oCalculator();
        oMemory oCalculator = new oMemory();

        private void Form1_Load(object sender, EventArgs e)
        {
            //on form load clear the information from the current display
            oCalculator.ClearInfo();
            lblTextDisplay.Text = "";
            lblEquationAnswer.Text = "0";
            //set up to show what the labels in the form are for the objects.
            oCalculator.lblEquationAnswer = lblEquationAnswer;
            oCalculator.lblTextDisplay = lblTextDisplay;
            oCalculator.lblMemory = lblMemory;
        }

        #region Buttons

        private void btnBack_Click(object sender, EventArgs e)
        {
            //When the user presses the back button it  removes the last entered piece of data.
            oCalculator.TakeBacks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            oCalculator.ClearInfo();
            lblTextDisplay.Text = "";
            lblEquationAnswer.Text = "0";
        }
        
        private void btn0_Click(object sender, EventArgs e)
        {
            //when it calls this method it 
            oCalculator.AddNumberToCurrentValue("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            oCalculator.AddNumberToCurrentValue("9");
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            //have string add or remove the +/-
            oCalculator.AddPosNeg();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //check to see and add a decimal point.
            oCalculator.AddDecimal();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            //this will send the information to the oCalculator class to be set.
            oCalculator.CurrentOperand = "+";              
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //this will send the information to the oCalculator class to be set.
            oCalculator.CurrentOperand = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //this will send the information to the oCalculator class to be set.
            oCalculator.CurrentOperand = "*";  
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //this will send the information to the oCalculator class to be set.
            oCalculator.CurrentOperand = "/";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //When the user program 
            oCalculator.Equals();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            //calculate teh reciprocal
            oCalculator.RecpricolAnswer();
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            oCalculator.SqRoot();
        }

        #region Memory
        private void btnMemoryStore_Click(object sender, EventArgs e)
        {
            //This stores the the current value into memory for the user.
            oCalculator.MemStore();
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            //When pressed this will display the information stored in memory to the display.
            oCalculator.MemRecall();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            //When this is clicked it will add the value in memory to the value shown on the screen and store
            //the new value into memory.
            oCalculator.MemAdd();
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            //When this button is clicked the information will be cleared from memory.
            oCalculator.MemClear();
        }
        #endregion

        #endregion


    }
}