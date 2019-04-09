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
    public partial class Programming : Form
    {
        public Programming()
        {
            InitializeComponent();
        }

        Operations calculator = new Operations();

        //Returns user input
        private String getUserInput()
        {
            return userInputTextBox.Text;
        }

        //Gets the Hexadecimal Result Label
        public String getHexResultLabel()
        {
            return hexResultLabel.Text;
        }
        //Sets the Hexadecimal Result Label
        public void setHexResultLabel(String input)
        {
            hexResultLabel.Text = input;
        }

        //Gets Octal Result Label
        public String getOctalResultLabel()
        {
            return octalResultLabel.Text;
        }
        //Sets Octal Result Label
        public void setOctalResultLabel(String input)
        {
            octalResultLabel.Text = input;
        }

        //Gets Binary Result Label
        public String getBinaryResultLabel()
        {
            return binaryResultLabel.Text;
        }
        //Sets Binary Result Label
        public void setBinaryResultLabel(String input)
        {
            binaryResultLabel.Text = input;
        }

        //Converts decimal to Octal using calculator.ConvertToOctal(int);
        private void OctalCheckB()
        {
            if (octalCheckBox.Checked)
            {
                octalResultLabel.Show();
                String userNumber = getUserInput();
                int userNumberInt = Int32.Parse(userNumber);

                String userNumberOctal = calculator.ConvertToOctal(userNumberInt);
                setOctalResultLabel(userNumberOctal);
            }
            else
            {
                octalResultLabel.Hide();
            }
        }
        //Converts decimal to Hexadecimal using calculator.ConvertToHex(int);
        private void HexCheckB()
        {
            if (hexCheckBox.Checked)
            {
                hexResultLabel.Show();

                String userNumber = getUserInput();
                int userNumberInt = Int32.Parse(userNumber);

                String userNumberHex = calculator.ConvertToHex(userNumberInt);
                setHexResultLabel(userNumberHex);
            }
            else
            {
                hexResultLabel.Hide();
            }
        }
        //Converts decimal to Binary using calculator.ConvertToBinary(int);
        private void BinaryCheckB()
        {
            if (binaryCheckBox.Checked)
            {
                binaryResultLabel.Show();

                String userNumber = getUserInput();
                int userNumberInt = Int32.Parse(userNumber);

                String userNumberBinary = calculator.ConvertToBinary(userNumberInt);
                setBinaryResultLabel(userNumberBinary);
            }
            else
            {
                binaryResultLabel.Hide();
            }
        }

        //Submit button
        //Checks if any CheckBoxes are selected, and calls methods
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (binaryCheckBox.Checked || octalCheckBox.Checked || hexCheckBox.Checked)
                {
                    int validInput = Int32.Parse(getUserInput());

                    if (validInput >= 1 && validInput < 256)
                    {
                        BinaryCheckB();
                        OctalCheckB();
                        HexCheckB();
                    }
                    else
                    {
                        MessageBox.Show("Input out of Range.");
                    }

                }
                else
                {
                    MessageBox.Show("Either no number is typed to be converted or " +
                        "no convert boxes are checked.");
                }

            }
            catch
            {
                MessageBox.Show("Invalid input. Please try again.");
                userInputTextBox.Clear();
            }
        }

    }
}
