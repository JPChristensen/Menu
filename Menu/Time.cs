using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
        }

        private void Time_Load(object sender, EventArgs e)
        {

        }

        private void Button_Enter(object sender, EventArgs e)
        {
            CalculateHour();
        }

        //Represents the 12 hour range
        private void CalculateHour()
        {

            //Removes colon from String
            int valueFrom = removeC(tbFrom.Text);
            if (valueFrom > 11)
            {
                valueFrom -= 1200;
            }

            //Removes colon from String
            int valueTo = removeC(tbTo.Text);
            int total = valueFrom - valueTo;

            //Makes the value positive
            if (total < 0)
            {
                total *= -1;
            }
            if (total > 1200)
            {
                total -= 1200;
            }
            //inserts a Colon in the number
            String totalString = addC(total.ToString());
     
            labelResult.Text = totalString.ToString();

        }

        // Removes Colons from strings
        private int removeC(String text)
        {
            char[] cArray = text.ToCharArray();
            String value = String.Empty;

            for(int i = 0; i < cArray.Length; i++)
            {
                if (cArray[i] == ':')
                {
                    continue;
                }
                else
                {
                    value += cArray[i];
                }


            }
            return Int32.Parse(value);
        }

        //Adds Colons to String
        private String addC(String text)
        {
            if (text.Length <= 3)
            {
                text = text.Insert(1, ":");
            }
            else
            {
                text = text.Insert(2, ":");
            }

            return text ;
        }

    }
}
