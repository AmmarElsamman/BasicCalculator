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
        }
        #endregion

        #region Number Methods

        /// <summary>
        /// Adds the 0 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="e">the event arguments</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            //checks if there is only a zero in the textbox 
            if(this.UserInput.Text != "0")
                //insert a zero if there isn't a zero already
                InsertTextValue("0");

                
            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 1 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("1");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 2 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("2");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 3 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("3");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 4 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("4");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 5 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("5");

            //focus the user input text
            FocusInput();
        }


        /// <summary>
        /// Adds the 6 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("6");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 7 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            InsertTextValue("7");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 8 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("8");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the 9 character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            //insert the value in the user textbox at the currently position
            InsertTextValue("9");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the . character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text == "0")
                this.UserInput.Text = "";

            if(this.UserInput.Text != "")
                
                //insert the value in the user textbox at the currently position
                InsertTextValue(".");

            //focus the user input text
            FocusInput();
        }
        #endregion

        #region Operations Methods

        /// <summary>
        /// Adds the divide character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            //calculate the previous opertion
            CalculateEquation();

            if (this.UserInput.Text != "" && !this.UserInput.Text.Contains('/'))
                //insert the value in the user textbox at the currently position
                InsertTextValue("/");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the times character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimesButton_Click(object sender, EventArgs e)
        {
            //calculate the previous opertion
            CalculateEquation();

            if(this.UserInput.Text != "" && !this.UserInput.Text.Contains('*'))
                //insert the value in the user textbox at the currently position
                InsertTextValue("*");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the minus character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minusButton_Click(object sender, EventArgs e)
        {
            //calculate the previous opertion
            CalculateEquation();

            if (this.UserInput.Text != "" && !this.UserInput.Text.Contains('-'))
                //insert the value in the user textbox at the currently position
                InsertTextValue("-");

            //focus the user input text
            FocusInput();
        }

        /// <summary>
        /// Adds the plus character to the text at the current selection postion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            //calculate the previous opertion
            CalculateEquation();

            if (this.UserInput.Text != "" && !this.UserInput.Text.Contains('+'))
                //insert the value in the user textbox at the currently position
                InsertTextValue("+");

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
        /// //Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string ParseOperation()
        {
            try
            {
                //Get the user's equation
                var userInput = this.UserInput.Text;

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
                    else if ("+-*/".Any(c => userInput[i] == c))
                    {
                        if (leftSide)
                        {
                            //Gets the operator type
                            var operationType = GetOperationType(userInput[i]);
                            operation.OperationType = operationType;
                            leftSide = false;

                        }
                       

                    }
                }

                if (operation.RightSide != "")
                {
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
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        result =  (left + right);
                        break;

                    case OperationType.Minus:
                        result = (left - right);
                        break;

                    case OperationType.Multiply:
                        result =  (left * right);
                        break;

                    case OperationType.Divide:
                        result = Math.Round((left / right),5);
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation");
                }
                if (result.ToString() == "NaN")
                {
                    this.UserInput.Text = string.Empty;
                    return "Result is undefined";
                }else if ((operation.OperationType == OperationType.Divide) && right == 0)
                {
                    this.UserInput.Text = string.Empty;
                    return "Cannot divide by zero";
                }

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
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case '*':
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
            //Clears the text from the user input text box
            this.UserInput.Text = string.Empty;
            

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
            //Clears the text from the user input text box
            this.UserInput.Text = string.Empty;
            this.ErrorMessageLabel.Text = String.Empty;

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

        #region helpful Methods

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInput()
        {
            this.UserInput.Focus();
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
            string s = this.UserInput.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
            }

            this.UserInput.Text = s;
            this.UserInput.SelectionStart = this.UserInput.Text.Length;
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
            #endregion

        }

    }
}