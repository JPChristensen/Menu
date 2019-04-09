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
    public partial class MathForm : Form
    {
        public MathForm()
        {
            InitializeComponent();
        }

        Operations operate = new Operations();

        //Changes colors of the buttons
       /* private void colorChanges()
        {
            this.button0.BackColor = Color.Yellow;
            this.button1.BackColor = Color.Azure;
            this.button2.BackColor = Color.Red;
            this.button3.BackColor = Color.Green;
            this.button4.BackColor = Color.Brown;
            this.button5.BackColor = Color.Purple;
            this.button6.BackColor = Color.Pink;
            this.button7.BackColor = Color.Gray;
            this.button8.BackColor = Color.Orange;
            this.button9.BackColor = Color.CornflowerBlue;

            this.buttonAdd.BackColor = Color.Aquamarine;
            this.buttonDivide.BackColor = Color.BlanchedAlmond;
            this.buttonMultiply.BackColor = Color.Turquoise;
            this.buttonSubtract.BackColor = Color.YellowGreen;


        }
        */

        private void MathForm_Load(object sender, EventArgs e)
        {
            // colorChanges();
        }

        /*
         * button0-9_Click add their text to the labelOutput 
         */

        private void button9_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button7.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button3.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelOutput.Text += button0.Text;
        }

        //Clears the labelOuput and tbInput 
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelOutput.Text = "";
            tbInput.Text = "";
        }

        // button Multiply/add/subtract/divide add their corresponding values to the labelOutput
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            labelOutput.Text += buttonMultiply.Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            labelOutput.Text += buttonAdd.Text;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            labelOutput.Text += buttonSubtract.Text;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            labelOutput.Text += buttonDivide.Text;
        }

        /* 
         * Takes the String in labelOutput breaks it into a cArray using operate.Calculate(String)
        *  Checks if the tbInput is empty for calculating value in labelOutput
        *  Displays the value of of the parsed String in labelOutput
        */
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                String text = String.Empty;
                if (tbInput.Text == "" || tbInput.Text == null)
                {
                    text = operate.Calculate(labelOutput.Text);
                }
                else
                {
                    text = operate.Calculate(tbInput.Text);
                    tbInput.Text = "";
                }

                if (text == "-1")
                {
                    MessageBox.Show("Can not divide by Zero");
                    text = "";
                }

                labelOutput.Text = text;

            } catch (Exception em) {
                MessageBox.Show(em.Message);
            }
        }

    }
}
