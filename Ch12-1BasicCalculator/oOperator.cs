using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_1BasicCalculator
{
    //Class to handle doing the operations for when the main form calls the class. +,-,*,/, and =
    //applied inheritance to pull the string informatin from the main form.
    class oOperator : frmCalculator
    {
        public static string operand1;
        public static string operand2;
        public static string resultDisplay;
        public static decimal finalAnswer;

        public static string FindOperator(string operation)
        {
            //switch statement to add the operator to the equation.
            switch (operation)
            {
                case "+":
                    return operation = "+";
                case "-" :
                    return operation = "-";
                case "*" :
                    return operation = "*";
                case "/" :
                    return operation = "/";
                case "=" :
                    return operation = "=";
            }
            return null;
        }


    }
}
