namespace CalculatorApp
{
    partial class CalculatorForm
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
            btn0 = new Button();
            BtnDot = new Button();
            Btn1 = new Button();
            Btn2 = new Button();
            Btn3 = new Button();
            Btn4 = new Button();
            Btn5 = new Button();
            Btn6 = new Button();
            Btn9 = new Button();
            Btn8 = new Button();
            Btn7 = new Button();
            BtnClear = new Button();
            BtnRedo = new Button();
            BtnUndo = new Button();
            BtnEqual = new Button();
            BtnAddition = new Button();
            BtnSubtraction = new Button();
            BtnMultiplication = new Button();
            BtnDivision = new Button();
            PanelHeader = new Panel();
            BtnClose = new Button();
            LabelHeader = new Label();
            TextBoxExpression = new TextBox();
            TextBoxDisplay = new TextBox();
            PanelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(60, 60, 60);
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Yu Gothic UI", 15F);
            btn0.ForeColor = Color.White;
            btn0.Location = new Point(12, 605);
            btn0.Name = "btn0";
            btn0.Size = new Size(252, 95);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += NumberButton_Click;
            // 
            // BtnDot
            // 
            BtnDot.BackColor = Color.FromArgb(60, 60, 60);
            BtnDot.FlatAppearance.BorderSize = 0;
            BtnDot.FlatStyle = FlatStyle.Flat;
            BtnDot.Font = new Font("Yu Gothic UI", 15F);
            BtnDot.ForeColor = Color.White;
            BtnDot.Location = new Point(270, 605);
            BtnDot.Name = "BtnDot";
            BtnDot.Size = new Size(123, 95);
            BtnDot.TabIndex = 1;
            BtnDot.Text = ".";
            BtnDot.UseVisualStyleBackColor = false;
            BtnDot.Click += DotButton_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.FromArgb(60, 60, 60);
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.Font = new Font("Yu Gothic UI", 15F);
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(12, 504);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(123, 95);
            Btn1.TabIndex = 2;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += NumberButton_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.FromArgb(60, 60, 60);
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.Font = new Font("Yu Gothic UI", 15F);
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(141, 504);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(123, 95);
            Btn2.TabIndex = 3;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += NumberButton_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.FromArgb(60, 60, 60);
            Btn3.FlatAppearance.BorderSize = 0;
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.Font = new Font("Yu Gothic UI", 15F);
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(270, 504);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(123, 95);
            Btn3.TabIndex = 4;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += NumberButton_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.FromArgb(60, 60, 60);
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.Font = new Font("Yu Gothic UI", 15F);
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(12, 403);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(123, 95);
            Btn4.TabIndex = 5;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += NumberButton_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.FromArgb(60, 60, 60);
            Btn5.FlatAppearance.BorderSize = 0;
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.Font = new Font("Yu Gothic UI", 15F);
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(141, 403);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(123, 95);
            Btn5.TabIndex = 6;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += NumberButton_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.FromArgb(60, 60, 60);
            Btn6.FlatAppearance.BorderSize = 0;
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.Font = new Font("Yu Gothic UI", 15F);
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(270, 403);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(123, 95);
            Btn6.TabIndex = 7;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += NumberButton_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.FromArgb(60, 60, 60);
            Btn9.FlatAppearance.BorderSize = 0;
            Btn9.FlatStyle = FlatStyle.Flat;
            Btn9.Font = new Font("Yu Gothic UI", 15F);
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(270, 302);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(123, 95);
            Btn9.TabIndex = 10;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += NumberButton_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.FromArgb(60, 60, 60);
            Btn8.FlatAppearance.BorderSize = 0;
            Btn8.FlatStyle = FlatStyle.Flat;
            Btn8.Font = new Font("Yu Gothic UI", 15F);
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(141, 302);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(123, 95);
            Btn8.TabIndex = 9;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += NumberButton_Click;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.FromArgb(60, 60, 60);
            Btn7.FlatAppearance.BorderSize = 0;
            Btn7.FlatStyle = FlatStyle.Flat;
            Btn7.Font = new Font("Yu Gothic UI", 15F);
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(12, 302);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(123, 95);
            Btn7.TabIndex = 8;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += NumberButton_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(60, 60, 60);
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Yu Gothic UI", 15F);
            BtnClear.ForeColor = Color.White;
            BtnClear.Location = new Point(270, 201);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(123, 95);
            BtnClear.TabIndex = 13;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += ClearButton_Click;
            // 
            // BtnRedo
            // 
            BtnRedo.BackColor = Color.FromArgb(60, 60, 60);
            BtnRedo.FlatAppearance.BorderSize = 0;
            BtnRedo.FlatStyle = FlatStyle.Flat;
            BtnRedo.Font = new Font("Yu Gothic UI", 9F);
            BtnRedo.ForeColor = Color.White;
            BtnRedo.Location = new Point(141, 201);
            BtnRedo.Name = "BtnRedo";
            BtnRedo.Size = new Size(123, 95);
            BtnRedo.TabIndex = 12;
            BtnRedo.Text = "Redo";
            BtnRedo.UseVisualStyleBackColor = false;
            BtnRedo.Click += RedoButton_Click;
            // 
            // BtnUndo
            // 
            BtnUndo.BackColor = Color.FromArgb(60, 60, 60);
            BtnUndo.FlatAppearance.BorderSize = 0;
            BtnUndo.FlatStyle = FlatStyle.Flat;
            BtnUndo.Font = new Font("Yu Gothic UI", 9F);
            BtnUndo.ForeColor = Color.White;
            BtnUndo.Location = new Point(12, 201);
            BtnUndo.Name = "BtnUndo";
            BtnUndo.Size = new Size(123, 95);
            BtnUndo.TabIndex = 11;
            BtnUndo.Text = "Undo";
            BtnUndo.UseVisualStyleBackColor = false;
            BtnUndo.Click += UndoButton_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = Color.FromArgb(60, 60, 60);
            BtnEqual.FlatAppearance.BorderSize = 0;
            BtnEqual.FlatStyle = FlatStyle.Flat;
            BtnEqual.Font = new Font("Yu Gothic UI", 15F);
            BtnEqual.ForeColor = Color.White;
            BtnEqual.Location = new Point(399, 605);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(123, 95);
            BtnEqual.TabIndex = 14;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += EqualButton_Click;
            // 
            // BtnAddition
            // 
            BtnAddition.BackColor = Color.FromArgb(60, 60, 60);
            BtnAddition.FlatAppearance.BorderSize = 0;
            BtnAddition.FlatStyle = FlatStyle.Flat;
            BtnAddition.Font = new Font("Yu Gothic UI", 15F);
            BtnAddition.ForeColor = Color.White;
            BtnAddition.Location = new Point(399, 504);
            BtnAddition.Name = "BtnAddition";
            BtnAddition.Size = new Size(123, 95);
            BtnAddition.TabIndex = 15;
            BtnAddition.Text = "+";
            BtnAddition.UseVisualStyleBackColor = false;
            BtnAddition.Click += OperationButton_Click;
            // 
            // BtnSubtraction
            // 
            BtnSubtraction.BackColor = Color.FromArgb(60, 60, 60);
            BtnSubtraction.FlatAppearance.BorderSize = 0;
            BtnSubtraction.FlatStyle = FlatStyle.Flat;
            BtnSubtraction.Font = new Font("Yu Gothic UI", 15F);
            BtnSubtraction.ForeColor = Color.White;
            BtnSubtraction.Location = new Point(399, 403);
            BtnSubtraction.Name = "BtnSubtraction";
            BtnSubtraction.Size = new Size(123, 95);
            BtnSubtraction.TabIndex = 16;
            BtnSubtraction.Text = "-";
            BtnSubtraction.UseVisualStyleBackColor = false;
            BtnSubtraction.Click += OperationButton_Click;
            // 
            // BtnMultiplication
            // 
            BtnMultiplication.BackColor = Color.FromArgb(60, 60, 60);
            BtnMultiplication.FlatAppearance.BorderSize = 0;
            BtnMultiplication.FlatStyle = FlatStyle.Flat;
            BtnMultiplication.Font = new Font("Yu Gothic UI", 15F);
            BtnMultiplication.ForeColor = Color.White;
            BtnMultiplication.Location = new Point(399, 302);
            BtnMultiplication.Name = "BtnMultiplication";
            BtnMultiplication.Size = new Size(123, 95);
            BtnMultiplication.TabIndex = 17;
            BtnMultiplication.Text = "×";
            BtnMultiplication.UseVisualStyleBackColor = false;
            BtnMultiplication.Click += OperationButton_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.BackColor = Color.FromArgb(60, 60, 60);
            BtnDivision.FlatAppearance.BorderSize = 0;
            BtnDivision.FlatStyle = FlatStyle.Flat;
            BtnDivision.Font = new Font("Yu Gothic UI", 15F);
            BtnDivision.ForeColor = Color.White;
            BtnDivision.Location = new Point(399, 201);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(123, 95);
            BtnDivision.TabIndex = 18;
            BtnDivision.Text = "=";
            BtnDivision.UseVisualStyleBackColor = false;
            BtnDivision.Click += EqualButton_Click;
            // 
            // PanelHeader
            // 
            PanelHeader.Controls.Add(BtnClose);
            PanelHeader.Controls.Add(LabelHeader);
            PanelHeader.Location = new Point(13, -4);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(509, 53);
            PanelHeader.TabIndex = 20;
            PanelHeader.MouseDown += FormMouseDown;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.Transparent;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.ForeColor = Color.White;
            BtnClose.Location = new Point(454, 5);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(41, 40);
            BtnClose.TabIndex = 2;
            BtnClose.Text = "×";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += CloseButton_Click;
            // 
            // LabelHeader
            // 
            LabelHeader.AutoSize = true;
            LabelHeader.ForeColor = Color.White;
            LabelHeader.Location = new Point(14, 12);
            LabelHeader.Name = "LabelHeader";
            LabelHeader.Size = new Size(120, 32);
            LabelHeader.TabIndex = 1;
            LabelHeader.Text = "Calculator";
            // 
            // TextBoxExpression
            // 
            TextBoxExpression.BackColor = Color.FromArgb(32, 32, 32);
            TextBoxExpression.BorderStyle = BorderStyle.None;
            TextBoxExpression.ForeColor = Color.DarkGray;
            TextBoxExpression.Location = new Point(13, 67);
            TextBoxExpression.Multiline = true;
            TextBoxExpression.Name = "TextBoxExpression";
            TextBoxExpression.Size = new Size(503, 55);
            TextBoxExpression.TabIndex = 21;
            TextBoxExpression.TextAlign = HorizontalAlignment.Right;
            // 
            // TextBoxDisplay
            // 
            TextBoxDisplay.BackColor = Color.FromArgb(32, 32, 32);
            TextBoxDisplay.BorderStyle = BorderStyle.None;
            TextBoxDisplay.Font = new Font("Yu Gothic UI", 14F);
            TextBoxDisplay.ForeColor = Color.DarkGray;
            TextBoxDisplay.Location = new Point(12, 126);
            TextBoxDisplay.Multiline = true;
            TextBoxDisplay.Name = "TextBoxDisplay";
            TextBoxDisplay.Size = new Size(510, 69);
            TextBoxDisplay.TabIndex = 22;
            TextBoxDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(534, 709);
            Controls.Add(TextBoxDisplay);
            Controls.Add(TextBoxExpression);
            Controls.Add(PanelHeader);
            Controls.Add(BtnDivision);
            Controls.Add(BtnMultiplication);
            Controls.Add(BtnSubtraction);
            Controls.Add(BtnAddition);
            Controls.Add(BtnEqual);
            Controls.Add(BtnClear);
            Controls.Add(BtnRedo);
            Controls.Add(BtnUndo);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(BtnDot);
            Controls.Add(btn0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalculatorForm";
            Text = "電卓";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn0;
        private Button BtnDot;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn9;
        private Button Btn8;
        private Button Btn7;
        private Button BtnClear;
        private Button BtnRedo;
        private Button BtnUndo;
        private Button BtnEqual;
        private Button BtnAddition;
        private Button BtnSubtraction;
        private Button BtnMultiplication;
        private Button BtnDivision;
        private Panel PanelHeader;
        private TextBox TextBoxExpression;
        private TextBox TextBoxDisplay;
        private Button BtnClose;
        private Label LabelHeader;
    }
}
