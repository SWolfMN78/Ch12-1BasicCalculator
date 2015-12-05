using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_1BasicCalculator
{
    //Class to handle doing the operations for when the main form calls the class. +,-,*,/, and =
    //applied inheritance to pull the string informatin from the main form.
    class oOperator
    {
        
        public static decimal CalculateOperation(List<string> numList, List<string> operandList)
        {
            decimal currentTotal = 0;
            if (numList[0] != "")
            {
                currentTotal = Convert.ToDecimal(numList[0]);
            }
            int numIndex = 1;

            //create a loop which runs through through the list and pulls out the strings.
            foreach (string operand in operandList)
            {
                //If the list of numbers is less than the index of information then run the set code.
                if (numIndex < numList.Count)
                {
                    decimal nextNumber = 0;
                    if (numList[numIndex] != "")
                    {
                        nextNumber = Convert.ToDecimal(numList[numIndex]);
                    }
                    numIndex = numIndex + 1;


                    //switch statement to add the operator to the equation.
                    switch (operand)
                    {
                        case "+":
                            currentTotal = currentTotal + nextNumber;
                            break;
                        case "-":
                            currentTotal = currentTotal - nextNumber;
                            break;
                        case "*":
                            currentTotal = currentTotal * nextNumber;
                            break;
                        case "/":
                            currentTotal = currentTotal / nextNumber;
                            break;
                    }
                }
            }
            return currentTotal;
        }

        public static string DisplayCalculation(List<string> numList, List<string> operandList)
        {
            string runningTotal = numList[0];
            int numIndex = 1;

            //create a loop which runs through through the list and pulls out the strings.
            foreach (string operand in operandList)
            {
                //If the list of numbers is less than the index of information then run the set code.
                if (numIndex < numList.Count)
                {
                    string nextNumber = numList[numIndex];
                    numIndex = numIndex + 1;

                    //switch statement to add the operator to the equation.
                    switch (operand)
                    {
                        case "+":
                            runningTotal = runningTotal + " + " + nextNumber;
                            break;
                        case "-":
                            runningTotal = runningTotal + "-" + nextNumber;
                            break;
                        case "*":
                            runningTotal = runningTotal + "*" + nextNumber;
                            break;
                        case "/":
                            runningTotal = runningTotal + "/" + nextNumber;
                            break;
                    }
                }
            }
            return runningTotal;
        }
    }
}