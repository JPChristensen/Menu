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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // colorChanges();
        }

        //Changes the colors of the buttons
        /*private void colorChanges()
        {

            buttonTime.BackColor = Color.RoyalBlue;
            buttonTime.ForeColor = Color.WhiteSmoke;

            buttonProgram.BackColor = Color.Purple;
            buttonProgram.ForeColor = Color.PowderBlue;

            buttonMath.BackColor = Color.Green;
            buttonMath.ForeColor = Color.Black;

            buttonMeasure.BackColor = Color.Red;
            buttonMeasure.ForeColor = Color.Yellow;
        }
        */

        //When Basic Math is pressed, calls MathForm
        private void Button_BasicMath(object sender, EventArgs e)
        {
            // Creates an object of type MathForm
            MathForm mathfrm = new MathForm();
            //Displays the Math form object
            mathfrm.ShowDialog();

        }
        //When Measure button is pressed, calls Measurements Form
        private void Button_Measure(object sender, EventArgs e)
        {
            // Creates an object of type Measurements
            Measurements measure = new Measurements();
            //Displays the Measure form object
            measure.ShowDialog();
        }
        //When Programming is pressed, calls Programming Form
        private void Button_Program(object sender, EventArgs e)
        {
            //Creates an object of type Programming
            Programming prog = new Programming();
            //Display the Program Form object
            prog.ShowDialog();
        }
        //When Time is pressed, calls Time Frm
        private void Button_Time(object sender, EventArgs e)
        {
            //Creates an object of type Time
            Time time = new Time();
            //Display the Time Form object
            time.ShowDialog();
        }
    }
}
