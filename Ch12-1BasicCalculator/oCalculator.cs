using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_1BasicCalculator
{
    /// <summary>
    /// This class will hold all of the material of the calculator
    /// </summary>
    public class oCalculator
    {
        public List<string> NumList = new List<string>();
        public static List<string> Operand = new List<string>();
        //this makes a variable of the lblEquationAnswer item on the form.
        public System.Windows.Forms.Label lblEquationAnswer;
        public System.Windows.Forms.Label lblTextDisplay;

        public void ClearInfo()
        {
            //clear the current information in the list.
            NumList.Clear();
            Operand.Clear();
            //add a new item to the list.
            NumList.Add("");
            Operand.Add("");
        }

        public void AddNumberToCurrentValue(string typedNumber)
        {
            //Here we add information to the numList (shown above) and display the information for the user.
            CurrentValue += typedNumber;
            lblEquationAnswer.Text = CurrentValue;
        }

        public void AddDecimal()
        {
            //placed "!" at the start which is short hand for saying does not contain a "." then add a . to the list
            if (!NumList[NumList.Count -1].Contains("."))
            {
                AddNumberToCurrentValue(".");
            }
            if (CurrentValue == ".")
            {
                CurrentValue = " 0.";
            }
        }

        public string CurrentValue
        {
            //this is going to handle figuring out the process of removing an item from the string of numbers
            //the user put in and spitting it back out for the application to use.
            get { return NumList[NumList.Count - 1]; }
            set
            {
                NumList[NumList.Count - 1] = value;
                lblEquationAnswer.Text = CurrentValue;
            }
        }

        public string CurrentOperand
        {
            //pull the current selected operand from the typed information of the user
            get { return Operand[Operand.Count - 1]; }
            set
            {
                Operand[Operand.Count - 1] = value;
                lblEquationAnswer.Text = CurrentValue + CurrentOperand;
                //when this information is set it will then add another spot for a new number and operand in their list.
                NumList.Add("");
                Operand.Add("");
            }
        }

        public void AddPosNeg()
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

        public void TakeBacks()
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

        public void Equals()
        { 
            //When this button is pressed it is going to take the first operand, the operator and the last operand.
            //then work the equation and display the answer.
            string stringCalculation = "";
            decimal returnedCalculation = 0;

            try
            {
                returnedCalculation = oOperator.CalculateOperation(NumList, Operand);
                stringCalculation = oOperator.DisplayCalculation(NumList, Operand);
                ClearInfo();
                CurrentValue = returnedCalculation.ToString();
                lblEquationAnswer.Text = returnedCalculation.ToString();
                lblTextDisplay.Text = stringCalculation;
            }

            catch (DivideByZeroException ex)
            {
                ClearInfo();
                lblTextDisplay.Text = "";
                lblEquationAnswer.Text = "Cannot divide by zero";
            }
        }

        public void RecpricolAnswer()
        {
            //This is an extra item to be added.
            string stringCalculation = "";
            decimal returnedCalculation = 0;

            try
            {
                returnedCalculation = oOperator.CalculateOperation(NumList, Operand);
                ClearInfo();
                double x = Convert.ToDouble(returnedCalculation);
                x = 1 / (x);
                stringCalculation = "1 / (" + returnedCalculation.ToString() + ")";

                CurrentValue = x.ToString();
                lblEquationAnswer.Text = x.ToString();
                lblTextDisplay.Text = stringCalculation;
            }
            catch (DivideByZeroException ex)
            {
                ClearInfo();
                lblTextDisplay.Text = "";
                lblEquationAnswer.Text = "Cannot divide by zero";
            }
        }

        public void SqRoot()
        {
            //This is an extra item to be added.
            string stringCalculation = "";
            decimal returnedCalculation = 0;

            try
            {
                returnedCalculation = oOperator.CalculateOperation(NumList, Operand);
                ClearInfo();
                double x = Convert.ToDouble(returnedCalculation);
                x = Math.Sqrt(x);
                stringCalculation = "√(" + returnedCalculation + ")";

                CurrentValue = x.ToString();
                lblEquationAnswer.Text = x.ToString();
                lblTextDisplay.Text = stringCalculation;
            }
            catch (DivideByZeroException ex)
            {
                ClearInfo();
                lblTextDisplay.Text = "";
                lblEquationAnswer.Text = "Cannot divide by zero";
            }
        }

    }
}
