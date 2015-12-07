using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_1BasicCalculator
{
    public class oMemory : oCalculator
    {
        public Label lblMemory;
        public string memoryStoredValue = "";

        public void MemStore()
        {
            //store it
            memoryStoredValue = CurrentValue;
            if (memoryStoredValue != "")
            {
                lblMemory.Text = "M";
            }
            else
            {
                lblMemory.Text = "";
                lblEquationAnswer.Text = "You must enter a value first";
            }
        }

        public void MemClear()
        {
            //clear it
            memoryStoredValue = "";
            lblMemory.Text = "";
        }
        public void MemAdd()
        {
            //add it
            decimal memoyCalculation = Convert.ToDecimal(memoryStoredValue);
            decimal ValueCalculation = Convert.ToDecimal(CurrentValue);

            //converted the strings to decimals to be calculated then back to a string
            memoryStoredValue = (memoyCalculation + ValueCalculation).ToString();
            lblMemory.Text = "M";
        }
        public void MemRecall()
        {
            //recall it
            CurrentValue = memoryStoredValue;
        }
    }
}
