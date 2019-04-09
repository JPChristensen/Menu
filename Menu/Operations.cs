using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Operations
    {
        //Converts a decimal number to Hexadecimal
        public String ConvertToHex(int number)
        {
            String hexNumber = String.Empty;
            int loopCounter = 0;
            while (number >= 1)
            {
                int value = number % 16;
                if (value > 9)
                {
                    String hex = String.Empty;

                    switch (value)
                    {
                        case 10: hex = "A"; break;
                        case 11: hex = "B"; break;
                        case 12: hex = "C"; break;
                        case 13: hex = "D"; break;
                        case 14: hex = "E"; break;
                        case 15: hex = "F"; break;
                    }

                    if (loopCounter > 2)
                    {
                        hexNumber += hex + " ";
                        loopCounter = 0;
                    }
                    else
                    {
                        hexNumber += hex;
                        loopCounter++;
                    }

                }
                else
                {
                    if (loopCounter > 2)
                    {
                        hexNumber += value + " ";
                        loopCounter = 0;
                    }
                    else
                    {
                        hexNumber += value;
                        loopCounter++;
                    }


                }
                number = number / 16;
            }

            hexNumber = ReverseString(hexNumber);
            return hexNumber;

        }

        //Converts a decimal number to Octal
        public String ConvertToOctal(int number)
        {
            String octalNumber = String.Empty;
            int loopCounter = 0;

            while (number >= 1)
            {
                int value = number % 8;
                if (loopCounter > 2)
                {
                    octalNumber += " " + value;
                    loopCounter = 0;
                }
                else
                {
                    octalNumber += value;
                    loopCounter++;
                }

                number = number / 8;
            }

            octalNumber = ReverseString(octalNumber);
            return octalNumber;
        }

        //Converts a decimal number to Binary
        public String ConvertToBinary(int number)
        {
            String binaryNumber = String.Empty;
            int loopCounter = 0;

            while (number >= 1)
            {
                int value = number % 2;
                if (loopCounter > 2)
                {
                    binaryNumber += value + " ";
                    loopCounter = 0;
                }
                else
                {
                    binaryNumber += value;
                    loopCounter++;
                }
                number = number / 2;
            }

            binaryNumber = ReverseString(binaryNumber);
            return binaryNumber;
        }

        //Reverses a String
        private String ReverseString(String text)
        {
            char[] cArray = text.ToCharArray();
            String reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

            return reverse;
        }


        //Converts to Inch to Food
        public String InchToFoot(String from)
        {
            double from1 = Double.Parse(from);

            double value = from1 / 12;
            return String.Format("{0:N5}", value);
        }
        //Converts Foot to Yard
        public String FootToYard(String from)
        {
            double from1 = Double.Parse(from);

            double value = from1 / 3;
            return String.Format("{0:N5}", value);
        }
        //Converts Yard to Mile
        public String YardToMile(String from)
        {
            double from1 = Double.Parse(from);

            double value = from1 / 1760;
            return String.Format("{0:N5}", value);
        }

        //Converts Mile to Yard
        public String MileToYard(String from)
        {
            double from1 = Double.Parse(from);

            double value = from1 * 1760;
            return String.Format("{0:N5}", value);
        }
        //Converts Yard to Foot
        public String YardToFoot(String from)
        {
            double from1 = Double.Parse(from);

            double value = from1 * 3;
            return String.Format("{0:N5}", value);
        }
        //Converts Foot to Inch
        public String FootToInch(String from)
        {
            double from1 = Double.Parse(from);

            double value = from1 * 12;
            return String.Format("{0:N5}", value);
        }

        /* Calculator Logic
         *  Takes a String and parses it into a cArray
         *  Then checks each index for a " + / - * "
         *  anything before the operation symbol is considered operand1
         *  everything after operation is considered operand2
         * 
         *  Uses switch statement to check value of Operation
         *  based off value the operation is applied to operand1st and operand2nd
         *  returns the end value as a String
         */
        public String Calculate(String text)
        {
            char[] cArray = text.ToCharArray();
            String operand1 = String.Empty;
            String operand2 = String.Empty;
            char operation = ' ';
            bool secondOperand = false;
            String value = String.Empty;

           for (int i = 0; i < cArray.Length; i++)
            {
                if (cArray[i] == '+' || cArray[i] == '-' || cArray[i] == '*' || cArray[i] == '/')
                {
                    if (secondOperand)
                    {
                        operand1 = dueOperation(operation, Double.Parse(operand1), Double.Parse(operand2));
                        operand2 = String.Empty;
                        operation = cArray[i];
                    }

                    operation = cArray[i];
                    secondOperand = true;
        
                }
                else
                {

                    if (!secondOperand)
                    {
                        operand1 += cArray[i];
                    }
                    else
                    {
                        operand2 += cArray[i];
                    }
                }
            }

            if (operation == '/' && operand2 == "0")
            {
                value = "-1";
            }
            else
            {
                value = dueOperation(operation, Double.Parse(operand1), Double.Parse(operand2));
            }

            return value;
        }

        private String dueOperation(char operation, double op1,double op2)
        {
            double value = 0;

            switch (operation)
            {
                case '+': value = op1 + op2; break;
                case '-': value = op1 - op2; break;
                case '*': value = op1 * op2; break;
                case '/': value = op1 / op2; break;
            }

            return value.ToString();
        }
    }
}
