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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
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
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.Location = new System.Drawing.Point(12, 46);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(358, 27);
            this.UserInput.TabIndex = 0;
            this.UserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInput_KeyPress);
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPanel.Controls.Add(this.EqualButton, 3, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonsPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonsPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonsPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonsPanel.Controls.Add(this.minusButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonsPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonsPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonsPanel.Controls.Add(this.TimesButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonsPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonsPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonsPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.BackspaceButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 171);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(358, 390);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EqualButton.Location = new System.Drawing.Point(270, 315);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(85, 72);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // DotButton
            // 
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Location = new System.Drawing.Point(181, 315);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(83, 72);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = true;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Location = new System.Drawing.Point(92, 315);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(83, 72);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Location = new System.Drawing.Point(270, 237);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(85, 72);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Location = new System.Drawing.Point(181, 237);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(83, 72);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Location = new System.Drawing.Point(92, 237);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(83, 72);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Location = new System.Drawing.Point(3, 237);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(83, 72);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Location = new System.Drawing.Point(270, 159);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(85, 72);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Location = new System.Drawing.Point(181, 159);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(83, 72);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Location = new System.Drawing.Point(92, 159);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(83, 72);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Location = new System.Drawing.Point(3, 159);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(83, 72);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // TimesButton
            // 
            this.TimesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimesButton.Location = new System.Drawing.Point(270, 81);
            this.TimesButton.Name = "TimesButton";
            this.TimesButton.Size = new System.Drawing.Size(85, 72);
            this.TimesButton.TabIndex = 7;
            this.TimesButton.Text = "X";
            this.TimesButton.UseVisualStyleBackColor = true;
            this.TimesButton.Click += new System.EventHandler(this.TimesButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Location = new System.Drawing.Point(181, 81);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(83, 72);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Location = new System.Drawing.Point(92, 81);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(83, 72);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Location = new System.Drawing.Point(3, 81);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(83, 72);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Location = new System.Drawing.Point(270, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(85, 72);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackspaceButton.Location = new System.Drawing.Point(181, 3);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(83, 72);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Text = "⌫ ";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(92, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(83, 72);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // CEButton
            // 
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(83, 72);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(12, 99);
            this.ErrorMessageLabel.MaximumSize = new System.Drawing.Size(300, 40);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorMessageLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.EqualButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(382, 573);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.UserInput);
            this.MinimumSize = new System.Drawing.Size(400, 620);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox UserInput;
        private TableLayoutPanel ButtonsPanel;
        private Button EqualButton;
        private Button DotButton;
        private Button ZeroButton;
        private Button PlusButton;
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
    }
}