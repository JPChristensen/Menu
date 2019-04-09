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
    public partial class Measurements : Form
    {
        public Measurements()
        {
            InitializeComponent();
        }

        Operations convert = new Operations();

        //Checks the value of cbFrom and uses a switch statement to call the corresponding Method
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            String valueFrom = cbFrom.Text;

            String valueTo = cbTo.Text;

            switch(valueFrom)
            {
                case "Inch": convertInch(valueTo); break;

                case "Foot": convertFoot(valueTo); break;

                case "Yard": convertYard(valueTo); break;

                case "Mile": convertMile(valueTo); break;
            }
        }

        /* If cbFrom was an Inch calls this method
        *   uses switch statement on cbTo to call corresponding Convert.*Operations method*
        *   Methods are nested for example Inch to Mile:
        *   Inch will call InchToFoot()
        *       after converted to a Foot than FootToYard()
        *           after this, finally converts to YardToMile()
        *           
        */
        private void convertInch(String to)
        {
            String value = String.Empty;

            switch(to)
            {
                case "Inch": value = tbValue.Text; break;
                case "Foot": value = convert.InchToFoot(tbValue.Text); break;
                case "Yard": value = convert.FootToYard(convert.InchToFoot(tbValue.Text)); break;
                case "Mile": value = convert.YardToMile(convert.FootToYard(convert.InchToFoot(tbValue.Text)));  break;
            }
            

            outputLabel.Text = value;
        }

        /*
         * If cbFrom was a Foot calls this method
         *  Same logic as convertInch()
         *  if Foot to Inch; FootToInch() is called from class Operations
         */
        private void convertFoot(String to)
        {
            String value = String.Empty;

            switch (to)
            {
                case "Inch": value = convert.FootToInch(tbValue.Text); break;
                case "Foot": value = tbValue.Text; break;
                case "Yard": value = convert.FootToYard(tbValue.Text); break;
                case "Mile": value = convert.YardToMile(convert.FootToYard(tbValue.Text)); break;
            }


            outputLabel.Text = value;
        }

        /*
         * If cbFrom was a Yard calls this method
         *  Same logic as convertInch()
         */
        private void convertYard(String to)
        {
            String value = String.Empty;

            switch (to)
            {
                case "Inch": value = convert.FootToInch(convert.YardToFoot(tbValue.Text)); break;
                case "Foot": value = convert.YardToFoot(tbValue.Text); break;
                case "Yard": value = tbValue.Text; break;
                case "Mile": value = convert.YardToMile(tbValue.Text); break;
            }


            outputLabel.Text = value;
        }

        /*
         * If cbFrom was a Mile; calls this method
         *  Same logic as convertInch()
         */
        private void convertMile(String to)
        {
            String value = String.Empty;

            switch (to)
            {
                case "Inch": value = convert.FootToInch(convert.YardToFoot(convert.MileToYard(tbValue.Text))); break;
                case "Foot": value = convert.YardToFoot(convert.MileToYard(tbValue.Text)); break;
                case "Yard": value = convert.MileToYard(tbValue.Text); break;
                case "Mile": value = tbValue.Text; break;
            }


            outputLabel.Text = value;
        }
    }
}
