namespace BasicCalculator
{
    /// <summary>
    /// A Basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.UserInput.SelectionStart = this.UserInput.Text.Length;
        }
        #endregion

        #region Number Methods
        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button digit = (Button)sender;

            if (sender.Equals(ZeroButton) || sender.Equals(S_ZeroButton))
            {
                if (this.UserInput.Text != "0")
                    //insert a zero if there isn't a zero already
                    InsertTextValue("0");

                //focus the user input text
                FocusInput();
            }
            else if (sender.Equals(DotButton) || sender.Equals(S_DotButton))
            {
                if (this.UserInput.Text != "")

                    //insert the value in the user textbox at the currently position
                    if(!this.UserInput.Text.Contains('.'))
                        InsertTextValue(".");

                //focus the user input text
                FocusInput();
            }
            else if (sender.Equals(S_Pi))
            {
                this.UserInput.Text = "";

                InsertTextValue(Convert.ToString(Math.PI));

            } 
            else if (sender.Equals(S_e))
            {
                this.UserInput.Text = "";

                InsertTextValue(Convert.ToString(Math.E));

            }
            else
            {
                if (this.UserInput.Text == "0")
                    this.UserInput.Text = "";

                //insert the value in the user textbox at the currently position
                InsertTextValue(digit.Text);

                //focus the user input text
                FocusInput();
            }
            
            
        }
        #endregion

        #region Operations Methods

        private void OperationButton_Click(object sender, EventArgs e)
        {

            Button operationSign = (Button)sender;

            //calculate the previous opertion
            CalculateEquation();

            if (this.UserInput.Text != "" && this.UserInput.Text.Contains(operationSign.Text))
            {
                if (operationSign.Text == "-")
                {
                    if (this.UserInput.Text[0] == '-')
                    {

                        //insert the value in the user textbox at the currently position
                        this.ErrorMessageLabel.Text += '-';
                        this.UserInput.Text = "0";

                    }else
                    {
                        return;
                    }
                }
                
            }
            else
            {
                //insert the value in the user textbox at the currently position
                this.ErrorMessageLabel.Text += operationSign.Text;

                this.UserInput.Text = "0";
            }

            //focus the user input text
            FocusInput();

        }


        #endregion

        /// <summary>
        /// printes the output
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
            //Calculates the equation
            CalculateEquation();

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Calculates the given equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateEquation()
        {

            //Parses the users equation and calculates the result
            this.ErrorMessageLabel.Text = ParseOperation();

            //focus the user input text
            FocusInput();
        }

        #region Calculating operations...

        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string ParseOperation()
        {
            try
            {
                //Get the user's equation
                var userInput = this.ErrorMessageLabel.Text;

                //create a new top-level operation
                var operation = new Operation();
                var leftSide = true;

                for (int i = 0; i < userInput.Length; i++)
                {
                    //checks if the input is a number
                    if ("0123456789.".Any(c => userInput[i] == c))
                    {
                        //if we on the left side concatenate the number to the left side of the operation
                        if (leftSide)
                            operation.LeftSide = AddNumCharacter(operation.LeftSide, userInput[i]);
                        else
                            operation.RightSide = AddNumCharacter(operation.RightSide, userInput[i]);
                    }
                    //if it is an operator set the operator type
                    else if ("+-x/".Any(c => userInput[i] == c))
                    {
                        if (leftSide)
                        {
                            //Gets the operator type
                            var operationType = GetOperationType(userInput[i]);

                            if (operation.LeftSide.Length == 0)
                            {
                                //check if the operator is not a minus
                                if (operationType == OperationType.Minus)

                                    //if we got a minus 
                                    operation.LeftSide += userInput[i];

                            }
                            else
                            {
                                // Now we got a left number so we need to move to the right side

                                //set operation type
                                operation.OperationType = operationType;

                                //Move to the right side
                                leftSide = false;
                            }

                        }

                    }
                }
                if (operation.RightSide == "" && leftSide == false)
                {
                    //Take the right side of the opertion from the text box
                    operation.RightSide = this.UserInput.Text;

                    //If we are done parsing, calculate the equation
                    return CalculateOperation(operation);
                }

                return this.UserInput.Text;
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates the operation
        /// </summary>
        /// <param name="operation">the operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {

            double result = 0;
            double left = 0;
            double right = 0;

            //check if the left side is a valid number
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
            {
                throw new InvalidOperationException($"Left side of the operation is not a valid number. {operation.LeftSide}");
            }

            //check if the right side is a valid number
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
            {
                throw new InvalidOperationException($"Right side of the operation is not a valid number. {operation.RightSide}");
            }

            try
            {
                //making calculations according to the opertion type
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        result = (left + right);
                        break;

                    case OperationType.Minus:
                        result = (left - right);
                        break;

                    case OperationType.Multiply:
                        result = (left * right);
                        break;

                    case OperationType.Divide:
                        result = Math.Round((left / right), 5);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation");
                }

                //if zero is divided by zero
                if (result.ToString() == "NaN")
                {
                    this.UserInput.Text = string.Empty;
                    return "Result is undefined";
                }

                //cannot divide by zero
                else if ((operation.OperationType == OperationType.Divide) && right == 0)
                {
                    this.UserInput.Text = string.Empty;
                    return "Cannot divide by zero";
                }

                //writing the output (result)
                this.UserInput.Text = result.ToString();
                this.UserInput.SelectionStart = this.UserInput.Text.Length;
                return result.ToString();


            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }

        }
        /// <summary>
        /// Accepts a character and returns the known operation 
        /// </summary>
        /// <param name="character">operationion</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            //setting the operation type
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case 'x':
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");
            }
        }

        /// <summary>
        /// appends a given character to the current number 
        /// </summary>
        /// <param name="currentNum">the current number string</param>
        /// <param name="newChar">the new character to append</param>
        /// <returns></returns>
        private string AddNumCharacter(string currentNum, char newChar)
        {
            //checks if there is already a . in the number
            if (newChar == '.' && currentNum.Contains('.'))
                throw new InvalidOperationException($"Number {currentNum} already contains a '.' and another can not be added  ");
            return currentNum + newChar;
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// clears the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {

            //if it is the final answer and the user cleared the the input it deletes the result too
            if (this.UserInput.Text == this.ErrorMessageLabel.Text)
            {
                this.UserInput.Text = string.Empty;
                this.ErrorMessageLabel.Text = string.Empty;
            }

            //Clears the text from the user input text box
            this.UserInput.Text = string.Empty;

            this.UserInput.Text = "0";

            //focus the user input text
            FocusInput();

        }

        /// <summary>
        /// clears the message box and the user input box 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CButton_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box and the result box
            this.UserInput.Text = string.Empty;
            this.ErrorMessageLabel.Text = String.Empty;

            this.UserInput.Text = "0";

            //focus the user input text
            FocusInput();

        }

        /// <summary>
        /// Deletes the first character after the cursor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            //Delete the value after the selected position
            DeleteTextValue();

            //focus the user input text
            FocusInput();

        }
        #endregion

        #region Handling Other Characters
        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //does't allow any character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '+')
                && (e.KeyChar != '-') && (e.KeyChar != '*') && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }

            //allow decimal point
            if ((e.KeyChar == '.') && UserInput.Text.IndexOf('.') < -1)
            {
                e.Handled = true;
            }

            //allow plus character
            if ((e.KeyChar == '+') && UserInput.Text.IndexOf('.') < -1)
            {
                e.Handled = true;
            }

            //allow minus character
            if ((e.KeyChar == '-') && UserInput.Text.IndexOf('.') < -1)
            {
                e.Handled = true;
            }

            //allow times character
            if ((e.KeyChar == '*') && UserInput.Text.IndexOf('.') < -1)
            {
                e.Handled = true;
            }

            //allow divide character
            if ((e.KeyChar == '/') && UserInput.Text.IndexOf('.') < -1)
            {
                e.Handled = true;
            }

        }

        #endregion

        #region helpful Methods

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInput()
        {
            this.UserInput.Focus();
            this.UserInput.SelectionStart = this.UserInput.Text.Length;


            //---------------------------------------------------------------------------

            //var str = this.UserInput.Text.ToCharArray();
            //var sb = new System.Text.StringBuilder();

            //if(this.UserInput.Text.Length > 3)
            //{
            //    for(int k = str.Length-1; k > -1; k--)
            //    {
            //        if ((k % 3 == 0) && k != 0 && str[k-1] != ',' )
            //        {
            //            sb.Append(str[k]);
            //            sb.Append(',');
            //        }
            //        else
            //        {
            //            sb.Append(str[k]);
            //        }
            //    }
            //    this.UserInput.Text = sb.ToString();
            //}
            //---------------------------------------------------------------------------

        }

        /// <summary>
        /// Insert the given value into the user input textbox
        /// </summary>
        /// <param name="value">the value to insert</param>
        private void InsertTextValue(string value)
        {
            //remember cursor location
            var selectionStart = this.UserInput.SelectionStart;

            //set new text
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, value);

            //Return the cursor to the last location
            //this.UserInput.SelectionStart = selectionStart + value.Length;

            //unhighlight the text
            this.UserInput.SelectionStart = this.UserInput.Text.Length;

        }

        /// <summary>
        /// Deletes the character to the right of the cursor of the user input textbox
        /// </summary>
        private void DeleteTextValue()
        {


            if (this.UserInput.Text.Length > 1)
            {
                this.UserInput.Text = this.UserInput.Text.Substring(0, this.UserInput.Text.Length - 1);
            }
            else if (this.UserInput.Text.Length == 1)
            {

                if (this.UserInput.Text == "0")
                {
                    this.UserInput.Text = this.UserInput.Text;
                    this.UserInput.SelectionStart = this.UserInput.Text.Length;
                    return;
                }
                else
                {
                    this.UserInput.Text = this.UserInput.Text.Substring(0, this.UserInput.Text.Length - 1);
                    this.UserInput.Text = "0";
                }

            }

            this.UserInput.Text = this.UserInput.Text;
            this.UserInput.SelectionStart = this.UserInput.Text.Length;
        }

        #endregion

        #region Memory Handling

        /// <summary>
        /// initialize the memory class
        /// </summary>
        MemoryData memory = new MemoryData();


        int index = 1;

        /// <summary>
        /// rewrite the memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemorySave_Click(object sender, EventArgs e)
        {
            if (index == 1)
            {
                this.MemoryHistory.Items.Insert(0, "M");
            }

            if (this.UserInput.Text != "")
            {
                //save the value to the memory
                memory.Memory = Convert.ToDouble(this.UserInput.Text);

                this.MemoryHistory.Items.Insert(index, memory.Memory);

                //right the value of the memory
                this.MemoryLabel.Text = $"M= {memory.Memory}";

                index++;

                this.UserInput.Text = "0";
            }
            else
            {
                return;
            }
        }

        /// <summary>
            /// add the given value to the memory
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void MemoryAdd_Click(object sender, EventArgs e)
        {
            //add the value in the text box to the memory 
            memory.Add(Convert.ToDouble(this.UserInput.Text));

            //right the value of the memory
            this.MemoryLabel.Text = $"M= {memory.Memory}";

            if (index == 1)
            {
                this.MemoryHistory.Items.Insert(0, "M");
                this.MemoryHistory.Items.Insert(index, memory.Memory);
                index++;
                return;
            }
            else
            {
                this.MemoryHistory.Items.RemoveAt(index - 1);
                this.MemoryHistory.Items.Insert(index - 1, memory.Memory);
            }
            this.UserInput.Text = "0";
        }

        /// <summary>
        /// subtract the given value from the memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemorySubtract_Click(object sender, EventArgs e)
        {
            //subtract the vlue in the text box from the memory
            memory.Subtract(Convert.ToDouble(this.UserInput.Text));

            //right the value of the memory
            this.MemoryLabel.Text = $"M= {memory.Memory}";

            if (index == 1)
            {
                this.MemoryHistory.Items.Insert(0, "M");
                this.MemoryHistory.Items.Insert(index, memory.Memory);
                index++;
                return;
            }
            else
            {
                this.MemoryHistory.Items.RemoveAt(index - 1);
                this.MemoryHistory.Items.Insert(index - 1, memory.Memory);

            }
            this.UserInput.Text = "0";

        }

        /// <summary>
        /// recall the value in the memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemoryRecall_Click(object sender, EventArgs e)
        {
            //right the value of the memory in the text box
            this.UserInput.Text = string.Empty;
            this.UserInput.Text = memory.Memory.ToString();
        }

        /// <summary>
        /// Clears the memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemoryClear_Click(object sender, EventArgs e)
        {
            memory.Memory = 0;

            //clear the value of the memory
            this.MemoryLabel.Text = string.Empty;

            this.MemoryHistory.Items.Clear();

        }

        private void MemoryHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedValue = this.MemoryHistory.SelectedItem.ToString();

            for (int i = 0; i < selectedValue.Length; i++)
            {
                if ("-0123456789.".Any(c => selectedValue[i] == c))
                {
                    this.UserInput.Text = selectedValue;
                    this.MemoryHistory.SelectedIndex = 0;
                    FocusInput();
                    this.UserInput.SelectionStart = this.UserInput.Text.Length;
                }
                else
                {
                    FocusInput();
                    this.UserInput.SelectionStart = this.UserInput.Text.Length;
                    return;
                }
            }

        }

        #endregion

        #region Other Functions

        /// <summary>
        /// Set Negative numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NegativeSign_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text != string.Empty)
            {
                if (!this.UserInput.Text.Contains('-'))
                {

                    this.UserInput.SelectionStart = 0;

                    InsertTextValue("-");

                    this.UserInput.SelectionStart = this.UserInput.Text.Length;

                }
                else
                {
                    var negativeIndex = this.UserInput.Text.IndexOf('-');
                    this.UserInput.Text = this.UserInput.Text.Substring(1, this.UserInput.Text.Length - 1);
                    this.UserInput.SelectionStart = this.UserInput.Text.Length;
                }
            }
        }

        /// <summary>
        /// Get the certain percentage of a value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PercentageButton_Click(object sender, EventArgs e)
        {
            var leftSide = "";
            var value = this.ErrorMessageLabel.Text;

            if (this.ErrorMessageLabel.Text != "")
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if ("0123456789.".Any(c => value[i] == c))
                    {
                        leftSide += value[i];
                    }
                    else
                    {
                        break;
                    }
                }
                var valueToCalculate = Convert.ToDouble(leftSide);
                var percentage = valueToCalculate * (Convert.ToDouble(this.UserInput.Text) / 100);
                this.UserInput.Text = percentage.ToString();
            }
            else
            {
                this.UserInput.Text = "0";
                this.ErrorMessageLabel.Text = "0";
            }
        }

        /// <summary>
        /// Get the Multiplication Inverse of a value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InverseFraction_Click(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(this.UserInput.Text);

            if (value != 0)
            {
                var multiInverse = 1 / value;
                this.UserInput.Text = multiInverse.ToString();
                this.ErrorMessageLabel.Text = $" 1/({value.ToString()})";
            }
            else
            {

                this.ErrorMessageLabel.Text = "Cannot divide by zero";
            }
        }

        /// <summary>
        /// Gets the Square root of a value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SquareRoot_Click(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(this.UserInput.Text);
            
            var squareRoot = Math.Sqrt(value);

            this.UserInput.Text = squareRoot.ToString();

            this.ErrorMessageLabel.Text = $"√({value.ToString()})";

        }

        /// <summary>
        /// Gets the square power of a value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Squared_Click(object sender, EventArgs e)
        {

            var value = Convert.ToDouble(this.UserInput.Text);

            var squared = Math.Pow(value, 2);

            this.UserInput.Text = squared.ToString();

            this.ErrorMessageLabel.Text = $"sqr({value})";

        }

        #endregion

        #region Menu Strip

        private void ScientificCalc_Click(object sender, EventArgs e)
        {
            this.ButtonsPanel.Visible = false;
            this.tableLayoutPanel2.Visible = true;
            this.tableLayoutPanel2.Size = this.ButtonsPanel.Size;
            this.tableLayoutPanel2.Location = this.ButtonsPanel.Location;

        }

        private void StandardCalc_Click(object sender, EventArgs e)
        {
            if (this.tableLayoutPanel2.Visible == false)
            {
                return;
            }
            else
            {
                this.tableLayoutPanel2.Visible = false;
                this.ButtonsPanel.Visible = true;
                this.ButtonsPanel.Size = this.tableLayoutPanel2.Size;
                this.ButtonsPanel.Location = this.tableLayoutPanel2.Location;
            }
        }

        #endregion


        #region Scientific Opertions

        /// <summary>
        /// Raises 10 to a given power
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void S_Base10_Click(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(this.UserInput.Text);

            double result = Math.Pow(10, value);

            this.UserInput.Text = Convert.ToDouble(result).ToString();

            this.ErrorMessageLabel.Text = "10^("+value+")";

        }

        /// <summary>
        /// Get The factorial of the value given
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void S_Factorial_Click(object sender, EventArgs e)
        {
            var value = Convert.ToDouble(this.UserInput.Text);
            int value_int = Convert.ToInt32(value);
            double result = 1;

            for(int i = value_int; i > 0; i--)
            {
                result *= i;
            }
        

            this.UserInput.Text = Convert.ToDouble(result).ToString();
            this.ErrorMessageLabel.Text = $"fact({value})";

        }





        #endregion

    }
}
