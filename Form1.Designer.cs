namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserInput = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PercentageButton = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.Squared = new System.Windows.Forms.Button();
            this.InverseFraction = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.NegativeSign = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.TimesButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.MemoryTable = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryAdd = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.MemorySubtract = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.MemoryRecall = new System.Windows.Forms.Button();
            this.MemoryHistory = new System.Windows.Forms.ComboBox();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.StandardCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.ScientificCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorType = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.S_Clear = new System.Windows.Forms.Button();
            this.S_Backspace = new System.Windows.Forms.Button();
            this.S_SquareRoot = new System.Windows.Forms.Button();
            this.S_Squared = new System.Windows.Forms.Button();
            this.S_NineButton = new System.Windows.Forms.Button();
            this.S_EightButton = new System.Windows.Forms.Button();
            this.S_SevenButton = new System.Windows.Forms.Button();
            this.S_ln = new System.Windows.Forms.Button();
            this.S_log = new System.Windows.Forms.Button();
            this.S_Base10 = new System.Windows.Forms.Button();
            this.S_Power = new System.Windows.Forms.Button();
            this.S_Factorial = new System.Windows.Forms.Button();
            this.S_RightBracket = new System.Windows.Forms.Button();
            this.S_LeftBracket = new System.Windows.Forms.Button();
            this.S_Mod = new System.Windows.Forms.Button();
            this.ExponentButton = new System.Windows.Forms.Button();
            this.S_Absolute = new System.Windows.Forms.Button();
            this.S_InverseFraction = new System.Windows.Forms.Button();
            this.S_e = new System.Windows.Forms.Button();
            this.S_Pi = new System.Windows.Forms.Button();
            this.S_SixButton = new System.Windows.Forms.Button();
            this.S_FiveButton = new System.Windows.Forms.Button();
            this.S_FourButton = new System.Windows.Forms.Button();
            this.S_OneButton = new System.Windows.Forms.Button();
            this.S_TwoButton = new System.Windows.Forms.Button();
            this.S_ThreeButton = new System.Windows.Forms.Button();
            this.S_DividedSign = new System.Windows.Forms.Button();
            this.S_TimesSign = new System.Windows.Forms.Button();
            this.S_MinusSign = new System.Windows.Forms.Button();
            this.S_PlusSign = new System.Windows.Forms.Button();
            this.S_EqualSign = new System.Windows.Forms.Button();
            this.S_DotButton = new System.Windows.Forms.Button();
            this.S_ZeroButton = new System.Windows.Forms.Button();
            this.S_NegativeSign = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.MemoryTable.SuspendLayout();
            this.CalculatorType.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.UserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserInput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserInput.Location = new System.Drawing.Point(12, 77);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(378, 54);
            this.UserInput.TabIndex = 0;
            this.UserInput.Text = "0";
            this.UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInput_KeyPress);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.PercentageButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.SquareRoot, 2, 1);
            this.ButtonsPanel.Controls.Add(this.Squared, 1, 1);
            this.ButtonsPanel.Controls.Add(this.InverseFraction, 0, 1);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 5);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 5);
            this.ButtonsPanel.Controls.Add(this.NegativeSign, 0, 5);
            this.ButtonsPanel.Controls.Add(this.EqualButton, 3, 5);
            this.ButtonsPanel.Controls.Add(this.PlusButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 4);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 4);
            this.ButtonsPanel.Controls.Add(this.minusButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.TimesButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.DivideButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.BackspaceButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.CButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 1, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 201);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 6;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(402, 369);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // PercentageButton
            // 
            this.PercentageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.PercentageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentageButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PercentageButton.Location = new System.Drawing.Point(3, 3);
            this.PercentageButton.Name = "PercentageButton";
            this.PercentageButton.Size = new System.Drawing.Size(94, 55);
            this.PercentageButton.TabIndex = 39;
            this.PercentageButton.Text = "%";
            this.PercentageButton.UseVisualStyleBackColor = false;
            this.PercentageButton.Click += new System.EventHandler(this.PercentageButton_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.SquareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SquareRoot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SquareRoot.Location = new System.Drawing.Point(203, 64);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(94, 55);
            this.SquareRoot.TabIndex = 38;
            this.SquareRoot.Text = "²√x";
            this.SquareRoot.UseVisualStyleBackColor = false;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // Squared
            // 
            this.Squared.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Squared.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Squared.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Squared.Location = new System.Drawing.Point(103, 64);
            this.Squared.Name = "Squared";
            this.Squared.Size = new System.Drawing.Size(94, 55);
            this.Squared.TabIndex = 37;
            this.Squared.Text = "x²";
            this.Squared.UseVisualStyleBackColor = false;
            this.Squared.Click += new System.EventHandler(this.Squared_Click);
            // 
            // InverseFraction
            // 
            this.InverseFraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.InverseFraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InverseFraction.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InverseFraction.Location = new System.Drawing.Point(3, 64);
            this.InverseFraction.Name = "InverseFraction";
            this.InverseFraction.Size = new System.Drawing.Size(94, 55);
            this.InverseFraction.TabIndex = 36;
            this.InverseFraction.Text = "1/x";
            this.InverseFraction.UseVisualStyleBackColor = false;
            this.InverseFraction.Click += new System.EventHandler(this.InverseFraction_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DotButton.Location = new System.Drawing.Point(203, 308);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(94, 58);
            this.DotButton.TabIndex = 34;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZeroButton.Location = new System.Drawing.Point(103, 308);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(94, 58);
            this.ZeroButton.TabIndex = 33;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // NegativeSign
            // 
            this.NegativeSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.NegativeSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NegativeSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NegativeSign.Location = new System.Drawing.Point(3, 308);
            this.NegativeSign.Name = "NegativeSign";
            this.NegativeSign.Size = new System.Drawing.Size(94, 58);
            this.NegativeSign.TabIndex = 32;
            this.NegativeSign.Text = "+/-";
            this.NegativeSign.UseVisualStyleBackColor = false;
            this.NegativeSign.Click += new System.EventHandler(this.NegativeSign_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EqualButton.Location = new System.Drawing.Point(303, 308);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(96, 58);
            this.EqualButton.TabIndex = 30;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.Silver;
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusButton.Location = new System.Drawing.Point(303, 247);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(96, 55);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThreeButton.Location = new System.Drawing.Point(203, 247);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(94, 55);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwoButton.Location = new System.Drawing.Point(103, 247);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(94, 55);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneButton.Location = new System.Drawing.Point(3, 247);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(94, 55);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Silver;
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusButton.Location = new System.Drawing.Point(303, 186);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(96, 55);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixButton.Location = new System.Drawing.Point(203, 186);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(94, 55);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiveButton.Location = new System.Drawing.Point(103, 186);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(94, 55);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FourButton.Location = new System.Drawing.Point(3, 186);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(94, 55);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.BackColor = System.Drawing.Color.Silver;
            this.TimesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimesButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimesButton.Location = new System.Drawing.Point(303, 125);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(96, 55);
            this.TimesButton.TabIndex = 7;
            this.TimesButton.Text = "x";
            this.TimesButton.UseVisualStyleBackColor = false;
            this.TimesButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NineButton.Location = new System.Drawing.Point(203, 125);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(94, 55);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightButton.Location = new System.Drawing.Point(103, 125);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(94, 55);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SevenButton.Location = new System.Drawing.Point(3, 125);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(94, 55);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.Silver;
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.Location = new System.Drawing.Point(303, 64);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(96, 55);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.BackspaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackspaceButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackspaceButton.Location = new System.Drawing.Point(303, 3);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(96, 55);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Text = "⌫ ";
            this.BackspaceButton.UseVisualStyleBackColor = false;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CButton.Location = new System.Drawing.Point(203, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(94, 55);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CEButton.Location = new System.Drawing.Point(103, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(94, 55);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessageLabel.Location = new System.Drawing.Point(12, 28);
            this.ErrorMessageLabel.MaximumSize = new System.Drawing.Size(300, 40);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 25);
            this.ErrorMessageLabel.TabIndex = 2;
            // 
            // MemoryTable
            // 
            this.MemoryTable.BackColor = System.Drawing.Color.Transparent;
            this.MemoryTable.ColumnCount = 5;
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66389F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.MemoryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66722F));
            this.MemoryTable.Controls.Add(this.MemoryAdd, 0, 0);
            this.MemoryTable.Controls.Add(this.MemorySave, 0, 0);
            this.MemoryTable.Controls.Add(this.MemorySubtract, 0, 0);
            this.MemoryTable.Controls.Add(this.MemoryClear, 0, 0);
            this.MemoryTable.Controls.Add(this.MemoryRecall, 0, 0);
            this.MemoryTable.Location = new System.Drawing.Point(1, 162);
            this.MemoryTable.Name = "MemoryTable";
            this.MemoryTable.RowCount = 1;
            this.MemoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MemoryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MemoryTable.Size = new System.Drawing.Size(334, 36);
            this.MemoryTable.TabIndex = 3;
            // 
            // MemoryAdd
            // 
            this.MemoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemoryAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemoryAdd.Location = new System.Drawing.Point(201, 3);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Size = new System.Drawing.Size(60, 30);
            this.MemoryAdd.TabIndex = 10;
            this.MemoryAdd.Text = "M+";
            this.MemoryAdd.UseVisualStyleBackColor = false;
            this.MemoryAdd.Click += new System.EventHandler(this.MemoryAdd_Click);
            // 
            // MemorySave
            // 
            this.MemorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemorySave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemorySave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemorySave.Location = new System.Drawing.Point(267, 3);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(64, 30);
            this.MemorySave.TabIndex = 9;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = false;
            this.MemorySave.Click += new System.EventHandler(this.MemorySave_Click);
            // 
            // MemorySubtract
            // 
            this.MemorySubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemorySubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemorySubtract.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemorySubtract.Location = new System.Drawing.Point(135, 3);
            this.MemorySubtract.Name = "MemorySubtract";
            this.MemorySubtract.Size = new System.Drawing.Size(60, 30);
            this.MemorySubtract.TabIndex = 8;
            this.MemorySubtract.Text = "M-";
            this.MemorySubtract.UseVisualStyleBackColor = false;
            this.MemorySubtract.Click += new System.EventHandler(this.MemorySubtract_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemoryClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemoryClear.Location = new System.Drawing.Point(3, 3);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(60, 30);
            this.MemoryClear.TabIndex = 7;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = false;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // MemoryRecall
            // 
            this.MemoryRecall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MemoryRecall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryRecall.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemoryRecall.Location = new System.Drawing.Point(69, 3);
            this.MemoryRecall.Name = "MemoryRecall";
            this.MemoryRecall.Size = new System.Drawing.Size(60, 30);
            this.MemoryRecall.TabIndex = 2;
            this.MemoryRecall.Text = "MR";
            this.MemoryRecall.UseVisualStyleBackColor = false;
            this.MemoryRecall.Click += new System.EventHandler(this.MemoryRecall_Click);
            // 
            // MemoryHistory
            // 
            this.MemoryHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MemoryHistory.BackColor = System.Drawing.Color.White;
            this.MemoryHistory.DropDownHeight = 380;
            this.MemoryHistory.DropDownWidth = 150;
            this.MemoryHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemoryHistory.FormattingEnabled = true;
            this.MemoryHistory.IntegralHeight = false;
            this.MemoryHistory.Location = new System.Drawing.Point(341, 162);
            this.MemoryHistory.Name = "MemoryHistory";
            this.MemoryHistory.Size = new System.Drawing.Size(57, 36);
            this.MemoryHistory.TabIndex = 7;
            this.MemoryHistory.Text = "M";
            this.MemoryHistory.SelectedIndexChanged += new System.EventHandler(this.MemoryHistory_SelectedIndexChanged);
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemoryLabel.Location = new System.Drawing.Point(12, 134);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(0, 25);
            this.MemoryLabel.TabIndex = 8;
            // 
            // StandardCalc
            // 
            this.StandardCalc.Name = "StandardCalc";
            this.StandardCalc.Size = new System.Drawing.Size(83, 24);
            this.StandardCalc.Text = "Standard";
            this.StandardCalc.Click += new System.EventHandler(this.StandardCalc_Click);
            // 
            // ScientificCalc
            // 
            this.ScientificCalc.Name = "ScientificCalc";
            this.ScientificCalc.Size = new System.Drawing.Size(83, 24);
            this.ScientificCalc.Text = "Scientific";
            this.ScientificCalc.Click += new System.EventHandler(this.ScientificCalc_Click);
            // 
            // CalculatorType
            // 
            this.CalculatorType.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CalculatorType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StandardCalc,
            this.ScientificCalc});
            this.CalculatorType.Location = new System.Drawing.Point(0, 0);
            this.CalculatorType.Name = "CalculatorType";
            this.CalculatorType.Size = new System.Drawing.Size(402, 28);
            this.CalculatorType.TabIndex = 9;
            this.CalculatorType.Text = "menuStrip1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.S_Clear, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.S_Backspace, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.S_SquareRoot, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.S_Squared, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.S_NineButton, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.S_EightButton, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.S_SevenButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.S_ln, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.S_log, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.S_Base10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.S_Power, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.S_Factorial, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.S_RightBracket, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.S_LeftBracket, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.S_Mod, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.ExponentButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.S_Absolute, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.S_InverseFraction, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.S_e, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.S_Pi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.S_SixButton, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.S_FiveButton, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.S_FourButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.S_OneButton, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.S_TwoButton, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.S_ThreeButton, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.S_DividedSign, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.S_TimesSign, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.S_MinusSign, 4, 4);
            this.tableLayoutPanel2.Controls.Add(this.S_PlusSign, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.S_EqualSign, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.S_DotButton, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.S_ZeroButton, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.S_NegativeSign, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(976, 615);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel2.TabIndex = 10;
            this.tableLayoutPanel2.Visible = false;
            // 
            // S_Clear
            // 
            this.S_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Clear.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Clear.Location = new System.Drawing.Point(3, 3);
            this.S_Clear.Name = "S_Clear";
            this.S_Clear.Size = new System.Drawing.Size(1, 1);
            this.S_Clear.TabIndex = 76;
            this.S_Clear.Text = "C";
            this.S_Clear.UseVisualStyleBackColor = false;
            this.S_Clear.Click += new System.EventHandler(this.CButton_Click);
            // 
            // S_Backspace
            // 
            this.S_Backspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Backspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Backspace.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Backspace.Location = new System.Drawing.Point(3, 3);
            this.S_Backspace.Name = "S_Backspace";
            this.S_Backspace.Size = new System.Drawing.Size(1, 1);
            this.S_Backspace.TabIndex = 75;
            this.S_Backspace.Text = "⌫ ";
            this.S_Backspace.UseVisualStyleBackColor = false;
            this.S_Backspace.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // S_SquareRoot
            // 
            this.S_SquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_SquareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_SquareRoot.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_SquareRoot.Location = new System.Drawing.Point(3, 3);
            this.S_SquareRoot.Name = "S_SquareRoot";
            this.S_SquareRoot.Size = new System.Drawing.Size(1, 1);
            this.S_SquareRoot.TabIndex = 74;
            this.S_SquareRoot.Text = "²√x";
            this.S_SquareRoot.UseVisualStyleBackColor = false;
            this.S_SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // S_Squared
            // 
            this.S_Squared.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Squared.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Squared.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Squared.Location = new System.Drawing.Point(3, 3);
            this.S_Squared.Name = "S_Squared";
            this.S_Squared.Size = new System.Drawing.Size(1, 1);
            this.S_Squared.TabIndex = 73;
            this.S_Squared.Text = "x²";
            this.S_Squared.UseVisualStyleBackColor = false;
            this.S_Squared.Click += new System.EventHandler(this.Squared_Click);
            // 
            // S_NineButton
            // 
            this.S_NineButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_NineButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_NineButton.Location = new System.Drawing.Point(3, 3);
            this.S_NineButton.Name = "S_NineButton";
            this.S_NineButton.Size = new System.Drawing.Size(1, 1);
            this.S_NineButton.TabIndex = 72;
            this.S_NineButton.Text = "9";
            this.S_NineButton.UseVisualStyleBackColor = false;
            this.S_NineButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_EightButton
            // 
            this.S_EightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_EightButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_EightButton.Location = new System.Drawing.Point(3, 3);
            this.S_EightButton.Name = "S_EightButton";
            this.S_EightButton.Size = new System.Drawing.Size(1, 1);
            this.S_EightButton.TabIndex = 71;
            this.S_EightButton.Text = "8";
            this.S_EightButton.UseVisualStyleBackColor = false;
            this.S_EightButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_SevenButton
            // 
            this.S_SevenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_SevenButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_SevenButton.Location = new System.Drawing.Point(3, 3);
            this.S_SevenButton.Name = "S_SevenButton";
            this.S_SevenButton.Size = new System.Drawing.Size(1, 1);
            this.S_SevenButton.TabIndex = 70;
            this.S_SevenButton.Text = "7";
            this.S_SevenButton.UseVisualStyleBackColor = false;
            this.S_SevenButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_ln
            // 
            this.S_ln.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_ln.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_ln.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_ln.Location = new System.Drawing.Point(3, 3);
            this.S_ln.Name = "S_ln";
            this.S_ln.Size = new System.Drawing.Size(1, 1);
            this.S_ln.TabIndex = 69;
            this.S_ln.Text = "ln";
            this.S_ln.UseVisualStyleBackColor = false;
            // 
            // S_log
            // 
            this.S_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_log.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_log.Location = new System.Drawing.Point(3, 3);
            this.S_log.Name = "S_log";
            this.S_log.Size = new System.Drawing.Size(1, 1);
            this.S_log.TabIndex = 68;
            this.S_log.Text = "log";
            this.S_log.UseVisualStyleBackColor = false;
            // 
            // S_Base10
            // 
            this.S_Base10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Base10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Base10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Base10.Location = new System.Drawing.Point(3, 3);
            this.S_Base10.Name = "S_Base10";
            this.S_Base10.Size = new System.Drawing.Size(1, 1);
            this.S_Base10.TabIndex = 67;
            this.S_Base10.Text = "10^x";
            this.S_Base10.UseVisualStyleBackColor = false;
            this.S_Base10.Click += new System.EventHandler(this.S_Base10_Click);
            // 
            // S_Power
            // 
            this.S_Power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Power.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Power.Location = new System.Drawing.Point(3, 3);
            this.S_Power.Name = "S_Power";
            this.S_Power.Size = new System.Drawing.Size(1, 1);
            this.S_Power.TabIndex = 64;
            this.S_Power.Text = "X^y";
            this.S_Power.UseVisualStyleBackColor = false;
            // 
            // S_Factorial
            // 
            this.S_Factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Factorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Factorial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Factorial.Location = new System.Drawing.Point(3, 3);
            this.S_Factorial.Name = "S_Factorial";
            this.S_Factorial.Size = new System.Drawing.Size(1, 1);
            this.S_Factorial.TabIndex = 63;
            this.S_Factorial.Text = "n!";
            this.S_Factorial.UseVisualStyleBackColor = false;
            this.S_Factorial.Click += new System.EventHandler(this.S_Factorial_Click);
            // 
            // S_RightBracket
            // 
            this.S_RightBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_RightBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_RightBracket.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_RightBracket.Location = new System.Drawing.Point(3, 3);
            this.S_RightBracket.Name = "S_RightBracket";
            this.S_RightBracket.Size = new System.Drawing.Size(1, 1);
            this.S_RightBracket.TabIndex = 62;
            this.S_RightBracket.Text = ")";
            this.S_RightBracket.UseVisualStyleBackColor = false;
            // 
            // S_LeftBracket
            // 
            this.S_LeftBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_LeftBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_LeftBracket.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_LeftBracket.Location = new System.Drawing.Point(3, 3);
            this.S_LeftBracket.Name = "S_LeftBracket";
            this.S_LeftBracket.Size = new System.Drawing.Size(1, 1);
            this.S_LeftBracket.TabIndex = 61;
            this.S_LeftBracket.Text = "(";
            this.S_LeftBracket.UseVisualStyleBackColor = false;
            // 
            // S_Mod
            // 
            this.S_Mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Mod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Mod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Mod.Location = new System.Drawing.Point(3, 3);
            this.S_Mod.Name = "S_Mod";
            this.S_Mod.Size = new System.Drawing.Size(1, 1);
            this.S_Mod.TabIndex = 59;
            this.S_Mod.Text = "mod";
            this.S_Mod.UseVisualStyleBackColor = false;
            // 
            // ExponentButton
            // 
            this.ExponentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ExponentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExponentButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExponentButton.Location = new System.Drawing.Point(3, 3);
            this.ExponentButton.Name = "ExponentButton";
            this.ExponentButton.Size = new System.Drawing.Size(1, 1);
            this.ExponentButton.TabIndex = 58;
            this.ExponentButton.Text = "exp";
            this.ExponentButton.UseVisualStyleBackColor = false;
            // 
            // S_Absolute
            // 
            this.S_Absolute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Absolute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Absolute.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Absolute.Location = new System.Drawing.Point(3, 3);
            this.S_Absolute.Name = "S_Absolute";
            this.S_Absolute.Size = new System.Drawing.Size(1, 1);
            this.S_Absolute.TabIndex = 57;
            this.S_Absolute.Text = "|x|";
            this.S_Absolute.UseVisualStyleBackColor = false;
            // 
            // S_InverseFraction
            // 
            this.S_InverseFraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_InverseFraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_InverseFraction.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_InverseFraction.Location = new System.Drawing.Point(3, 3);
            this.S_InverseFraction.Name = "S_InverseFraction";
            this.S_InverseFraction.Size = new System.Drawing.Size(1, 1);
            this.S_InverseFraction.TabIndex = 56;
            this.S_InverseFraction.Text = "1/x";
            this.S_InverseFraction.UseVisualStyleBackColor = false;
            this.S_InverseFraction.Click += new System.EventHandler(this.InverseFraction_Click);
            // 
            // S_e
            // 
            this.S_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_e.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_e.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_e.Location = new System.Drawing.Point(3, 3);
            this.S_e.Name = "S_e";
            this.S_e.Size = new System.Drawing.Size(1, 1);
            this.S_e.TabIndex = 52;
            this.S_e.Text = "e";
            this.S_e.UseVisualStyleBackColor = false;
            this.S_e.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_Pi
            // 
            this.S_Pi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_Pi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_Pi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_Pi.Location = new System.Drawing.Point(3, 3);
            this.S_Pi.Name = "S_Pi";
            this.S_Pi.Size = new System.Drawing.Size(1, 1);
            this.S_Pi.TabIndex = 51;
            this.S_Pi.Text = "π";
            this.S_Pi.UseVisualStyleBackColor = false;
            this.S_Pi.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_SixButton
            // 
            this.S_SixButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_SixButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_SixButton.Location = new System.Drawing.Point(3, 3);
            this.S_SixButton.Name = "S_SixButton";
            this.S_SixButton.Size = new System.Drawing.Size(1, 1);
            this.S_SixButton.TabIndex = 48;
            this.S_SixButton.Text = "6";
            this.S_SixButton.UseVisualStyleBackColor = false;
            this.S_SixButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_FiveButton
            // 
            this.S_FiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_FiveButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_FiveButton.Location = new System.Drawing.Point(3, 3);
            this.S_FiveButton.Name = "S_FiveButton";
            this.S_FiveButton.Size = new System.Drawing.Size(1, 1);
            this.S_FiveButton.TabIndex = 47;
            this.S_FiveButton.Text = "5";
            this.S_FiveButton.UseVisualStyleBackColor = false;
            this.S_FiveButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_FourButton
            // 
            this.S_FourButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_FourButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_FourButton.Location = new System.Drawing.Point(3, 3);
            this.S_FourButton.Name = "S_FourButton";
            this.S_FourButton.Size = new System.Drawing.Size(1, 1);
            this.S_FourButton.TabIndex = 46;
            this.S_FourButton.Text = "4";
            this.S_FourButton.UseVisualStyleBackColor = false;
            this.S_FourButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_OneButton
            // 
            this.S_OneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_OneButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_OneButton.Location = new System.Drawing.Point(3, 3);
            this.S_OneButton.Name = "S_OneButton";
            this.S_OneButton.Size = new System.Drawing.Size(1, 1);
            this.S_OneButton.TabIndex = 45;
            this.S_OneButton.Text = "1";
            this.S_OneButton.UseVisualStyleBackColor = false;
            this.S_OneButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_TwoButton
            // 
            this.S_TwoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_TwoButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_TwoButton.Location = new System.Drawing.Point(3, 3);
            this.S_TwoButton.Name = "S_TwoButton";
            this.S_TwoButton.Size = new System.Drawing.Size(1, 1);
            this.S_TwoButton.TabIndex = 44;
            this.S_TwoButton.Text = "2";
            this.S_TwoButton.UseVisualStyleBackColor = false;
            this.S_TwoButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_ThreeButton
            // 
            this.S_ThreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_ThreeButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_ThreeButton.Location = new System.Drawing.Point(3, 3);
            this.S_ThreeButton.Name = "S_ThreeButton";
            this.S_ThreeButton.Size = new System.Drawing.Size(1, 1);
            this.S_ThreeButton.TabIndex = 43;
            this.S_ThreeButton.Text = "3";
            this.S_ThreeButton.UseVisualStyleBackColor = false;
            this.S_ThreeButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_DividedSign
            // 
            this.S_DividedSign.BackColor = System.Drawing.Color.Silver;
            this.S_DividedSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_DividedSign.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_DividedSign.Location = new System.Drawing.Point(3, 3);
            this.S_DividedSign.Name = "S_DividedSign";
            this.S_DividedSign.Size = new System.Drawing.Size(1, 1);
            this.S_DividedSign.TabIndex = 42;
            this.S_DividedSign.Text = "/";
            this.S_DividedSign.UseVisualStyleBackColor = false;
            this.S_DividedSign.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // S_TimesSign
            // 
            this.S_TimesSign.BackColor = System.Drawing.Color.Silver;
            this.S_TimesSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_TimesSign.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_TimesSign.Location = new System.Drawing.Point(3, 3);
            this.S_TimesSign.Name = "S_TimesSign";
            this.S_TimesSign.Size = new System.Drawing.Size(1, 1);
            this.S_TimesSign.TabIndex = 41;
            this.S_TimesSign.Text = "x";
            this.S_TimesSign.UseVisualStyleBackColor = false;
            this.S_TimesSign.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // S_MinusSign
            // 
            this.S_MinusSign.BackColor = System.Drawing.Color.Silver;
            this.S_MinusSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_MinusSign.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_MinusSign.Location = new System.Drawing.Point(3, 3);
            this.S_MinusSign.Name = "S_MinusSign";
            this.S_MinusSign.Size = new System.Drawing.Size(1, 1);
            this.S_MinusSign.TabIndex = 40;
            this.S_MinusSign.Text = "-";
            this.S_MinusSign.UseVisualStyleBackColor = false;
            this.S_MinusSign.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // S_PlusSign
            // 
            this.S_PlusSign.BackColor = System.Drawing.Color.Silver;
            this.S_PlusSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_PlusSign.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_PlusSign.Location = new System.Drawing.Point(3, 3);
            this.S_PlusSign.Name = "S_PlusSign";
            this.S_PlusSign.Size = new System.Drawing.Size(1, 1);
            this.S_PlusSign.TabIndex = 39;
            this.S_PlusSign.Text = "+";
            this.S_PlusSign.UseVisualStyleBackColor = false;
            this.S_PlusSign.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // S_EqualSign
            // 
            this.S_EqualSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(26)))), ((int)(((byte)(21)))));
            this.S_EqualSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_EqualSign.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_EqualSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.S_EqualSign.Location = new System.Drawing.Point(3, 3);
            this.S_EqualSign.Name = "S_EqualSign";
            this.S_EqualSign.Size = new System.Drawing.Size(1, 1);
            this.S_EqualSign.TabIndex = 38;
            this.S_EqualSign.Text = "=";
            this.S_EqualSign.UseVisualStyleBackColor = false;
            this.S_EqualSign.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // S_DotButton
            // 
            this.S_DotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_DotButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_DotButton.Location = new System.Drawing.Point(3, 3);
            this.S_DotButton.Name = "S_DotButton";
            this.S_DotButton.Size = new System.Drawing.Size(1, 1);
            this.S_DotButton.TabIndex = 37;
            this.S_DotButton.Text = ".";
            this.S_DotButton.UseVisualStyleBackColor = false;
            this.S_DotButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_ZeroButton
            // 
            this.S_ZeroButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_ZeroButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_ZeroButton.Location = new System.Drawing.Point(3, 3);
            this.S_ZeroButton.Name = "S_ZeroButton";
            this.S_ZeroButton.Size = new System.Drawing.Size(1, 1);
            this.S_ZeroButton.TabIndex = 36;
            this.S_ZeroButton.Text = "0";
            this.S_ZeroButton.UseVisualStyleBackColor = false;
            this.S_ZeroButton.Click += new System.EventHandler(this.DigitButton_Click);
            // 
            // S_NegativeSign
            // 
            this.S_NegativeSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.S_NegativeSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.S_NegativeSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S_NegativeSign.Location = new System.Drawing.Point(3, 3);
            this.S_NegativeSign.Name = "S_NegativeSign";
            this.S_NegativeSign.Size = new System.Drawing.Size(1, 1);
            this.S_NegativeSign.TabIndex = 35;
            this.S_NegativeSign.Text = "+/-";
            this.S_NegativeSign.UseVisualStyleBackColor = false;
            this.S_NegativeSign.Click += new System.EventHandler(this.NegativeSign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(402, 573);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.MemoryTable);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.MemoryHistory);
            this.Controls.Add(this.CalculatorType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.CalculatorType;
            this.MinimumSize = new System.Drawing.Size(420, 620);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.MemoryTable.ResumeLayout(false);
            this.CalculatorType.ResumeLayout(false);
            this.CalculatorType.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserInput;
        private TableLayoutPanel ButtonsPanel;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button minusButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button TimesButton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button DivideButton;
        private Button BackspaceButton;
        private Button CButton;
        private Button CEButton;
        private Label ErrorMessageLabel;
        private TableLayoutPanel MemoryTable;
        private ComboBox MemoryHistory;
        private Button MemoryRecall;
        private Button MemoryAdd;
        private Button MemorySave;
        private Button MemorySubtract;
        private Button MemoryClear;
        private Label MemoryLabel;
        private Button PlusButton;
        private Button EqualButton;
        private Button DotButton;
        private Button ZeroButton;
        private Button NegativeSign;
        private Button PercentageButton;
        private Button SquareRoot;
        private Button Squared;
        private Button InverseFraction;
        private ToolStripMenuItem StandardCalc;
        private ToolStripMenuItem ScientificCalc;
        private MenuStrip CalculatorType;
        private TableLayoutPanel tableLayoutPanel2;
        private Button S_SixButton;
        private Button S_FiveButton;
        private Button S_FourButton;
        private Button S_OneButton;
        private Button S_TwoButton;
        private Button S_ThreeButton;
        private Button S_DividedSign;
        private Button S_TimesSign;
        private Button S_MinusSign;
        private Button S_PlusSign;
        private Button S_EqualSign;
        private Button S_DotButton;
        private Button S_ZeroButton;
        private Button S_NegativeSign;
        private Button S_SquareRoot;
        private Button S_Squared;
        private Button S_NineButton;
        private Button S_EightButton;
        private Button S_SevenButton;
        private Button S_ln;
        private Button S_log;
        private Button S_Base10;
        private Button S_Power;
        private Button S_Factorial;
        private Button S_RightBracket;
        private Button S_LeftBracket;
        private Button S_Mod;
        private Button ExponentButton;
        private Button S_Absolute;
        private Button S_e;
        private Button S_Pi;
        private Button S_Clear;
        private Button S_Backspace;
        private Button S_InverseFraction;
    }
}