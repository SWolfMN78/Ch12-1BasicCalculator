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
        /// </summary>

        //one list to hold the numbers and one list to hold the Operands for the equations that will be worked.
        //all of the information will be poured  into the two list then worked from here.  
        //This will allow for a string or strings of information to be worked easily.
        public List<string> NumList = new List<string>();
        public List<string> Operand = new List<string>();
        private string CurrentValue
        {
            //this is going to handle figuring out the process of removing an item from the string of numbers
            //the user put in and spitting it back out for the application to use.
            get
            {
                return NumList[NumList.Count - 1];
            }
            set
            {
                NumList[NumList.Count - 1] = value;
                lblEquationAnswer.Text = CurrentValue;
            }
                       
        }
        
        private void AddNumberToCurrentValue(string typedNumber)
        {
            //Here we add information to the numList (shown above) and display the information for the user.
            CurrentValue += typedNumber;
            lblEquationAnswer.Text = CurrentValue;
        }

        private void OperatorCheck(string typedOperator)
        {
            //here we're going to put in a switch to handle finding out which operator was clicked 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on form load clear the information from the current display
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
            //When this is pressed it will take one digit out of the listing.
            if (CurrentValue.Length > 0)
            {
                CurrentValue = CurrentValue.Remove(CurrentValue.Length - 1);
            }

            lblEquationAnswer.Text = CurrentValue;
            if (CurrentValue.Length == 0)
            {
                lblEquationAnswer.Text = "0";
            }
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
            //Check on the string to see if it holds a "-" if it doesn't then remove it 
            if (CurrentValue.Contains("-"))
            {
                CurrentValue = CurrentValue.Replace("-", "");
            }
            else
            {
                CurrentValue = "-" + CurrentValue;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            //placed "!" at the start which is short hand for saying does not contain a "." then add a . to the list
            if (!NumList[NumList.Count -1].Contains("."))
            {
                AddNumberToCurrentValue(".");
            }
            if (CurrentValue == ".")
            {
                CurrentValue = "0.";
            }

        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            //pass this information to the switch check OperatorCheck
            OperatorCheck("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //pass this information to the switch check OperatorCheck
            OperatorCheck("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //pass this information to the switch check OperatorCheck
            OperatorCheck("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //pass this information to the switch check OperatorCheck
            OperatorCheck("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //When this button is pressed it is going to take the first operand, the operator and the last operand.
            //then work the equation and display the answer.
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            //This is an extra item to be added.
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            //This is an extra item to be added.
        }

        #endregion

    }
}
