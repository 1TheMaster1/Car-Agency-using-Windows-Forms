namespace Project
{
    partial class FinanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backButton = new Button();
            revenueGroupBox = new GroupBox();
            revenueLabel = new Label();
            serviceTextBox = new TextBox();
            salesTextBox = new TextBox();
            serviceLabel = new Label();
            salesLabel = new Label();
            expensesGroupBox = new GroupBox();
            otherTextBox = new TextBox();
            otherLabel = new Label();
            expensesLabel = new Label();
            rentTextBox = new TextBox();
            rentLabel = new Label();
            carCostsTextBox = new TextBox();
            salariesTextBox = new TextBox();
            carCostsLabel = new Label();
            salariesLabel = new Label();
            profitLabel = new Label();
            inputButton = new Button();
            databaseButton = new Button();
            resetButton = new Button();
            revenueGroupBox.SuspendLayout();
            expensesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(633, 344);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // revenueGroupBox
            // 
            revenueGroupBox.Controls.Add(revenueLabel);
            revenueGroupBox.Controls.Add(serviceTextBox);
            revenueGroupBox.Controls.Add(salesTextBox);
            revenueGroupBox.Controls.Add(serviceLabel);
            revenueGroupBox.Controls.Add(salesLabel);
            revenueGroupBox.Location = new Point(12, 12);
            revenueGroupBox.Name = "revenueGroupBox";
            revenueGroupBox.Size = new Size(247, 146);
            revenueGroupBox.TabIndex = 3;
            revenueGroupBox.TabStop = false;
            revenueGroupBox.Text = "Revenue";
            // 
            // revenueLabel
            // 
            revenueLabel.AutoSize = true;
            revenueLabel.Location = new Point(6, 114);
            revenueLabel.Name = "revenueLabel";
            revenueLabel.Size = new Size(113, 20);
            revenueLabel.TabIndex = 4;
            revenueLabel.Text = "Total Revenue : ";
            // 
            // serviceTextBox
            // 
            serviceTextBox.Location = new Point(128, 72);
            serviceTextBox.Name = "serviceTextBox";
            serviceTextBox.Size = new Size(113, 27);
            serviceTextBox.TabIndex = 3;
            // 
            // salesTextBox
            // 
            salesTextBox.Location = new Point(128, 39);
            salesTextBox.Name = "salesTextBox";
            salesTextBox.Size = new Size(113, 27);
            salesTextBox.TabIndex = 2;
            // 
            // serviceLabel
            // 
            serviceLabel.AutoSize = true;
            serviceLabel.Location = new Point(6, 75);
            serviceLabel.Name = "serviceLabel";
            serviceLabel.Size = new Size(67, 20);
            serviceLabel.TabIndex = 1;
            serviceLabel.Text = "Service : ";
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Location = new Point(6, 42);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(50, 20);
            salesLabel.TabIndex = 0;
            salesLabel.Text = "Sales :";
            // 
            // expensesGroupBox
            // 
            expensesGroupBox.Controls.Add(otherTextBox);
            expensesGroupBox.Controls.Add(otherLabel);
            expensesGroupBox.Controls.Add(expensesLabel);
            expensesGroupBox.Controls.Add(rentTextBox);
            expensesGroupBox.Controls.Add(rentLabel);
            expensesGroupBox.Controls.Add(carCostsTextBox);
            expensesGroupBox.Controls.Add(salariesTextBox);
            expensesGroupBox.Controls.Add(carCostsLabel);
            expensesGroupBox.Controls.Add(salariesLabel);
            expensesGroupBox.Location = new Point(12, 164);
            expensesGroupBox.Name = "expensesGroupBox";
            expensesGroupBox.Size = new Size(247, 206);
            expensesGroupBox.TabIndex = 4;
            expensesGroupBox.TabStop = false;
            expensesGroupBox.Text = "Expenses";
            // 
            // otherTextBox
            // 
            otherTextBox.Location = new Point(128, 135);
            otherTextBox.Name = "otherTextBox";
            otherTextBox.Size = new Size(113, 27);
            otherTextBox.TabIndex = 10;
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.Location = new Point(6, 138);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new Size(53, 20);
            otherLabel.TabIndex = 10;
            otherLabel.Text = "Other :";
            // 
            // expensesLabel
            // 
            expensesLabel.AutoSize = true;
            expensesLabel.Location = new Point(6, 183);
            expensesLabel.Name = "expensesLabel";
            expensesLabel.Size = new Size(113, 20);
            expensesLabel.TabIndex = 6;
            expensesLabel.Text = "Total Expenses :";
            // 
            // rentTextBox
            // 
            rentTextBox.Location = new Point(128, 102);
            rentTextBox.Name = "rentTextBox";
            rentTextBox.Size = new Size(113, 27);
            rentTextBox.TabIndex = 5;
            // 
            // rentLabel
            // 
            rentLabel.AutoSize = true;
            rentLabel.Location = new Point(6, 105);
            rentLabel.Name = "rentLabel";
            rentLabel.Size = new Size(46, 20);
            rentLabel.TabIndex = 4;
            rentLabel.Text = "Rent :";
            // 
            // carCostsTextBox
            // 
            carCostsTextBox.Location = new Point(128, 69);
            carCostsTextBox.Name = "carCostsTextBox";
            carCostsTextBox.Size = new Size(113, 27);
            carCostsTextBox.TabIndex = 3;
            // 
            // salariesTextBox
            // 
            salariesTextBox.Location = new Point(128, 36);
            salariesTextBox.Name = "salariesTextBox";
            salariesTextBox.Size = new Size(113, 27);
            salariesTextBox.TabIndex = 2;
            // 
            // carCostsLabel
            // 
            carCostsLabel.AutoSize = true;
            carCostsLabel.Location = new Point(6, 72);
            carCostsLabel.Name = "carCostsLabel";
            carCostsLabel.Size = new Size(77, 20);
            carCostsLabel.TabIndex = 1;
            carCostsLabel.Text = "Car Costs :";
            // 
            // salariesLabel
            // 
            salariesLabel.AutoSize = true;
            salariesLabel.Location = new Point(6, 39);
            salariesLabel.Name = "salariesLabel";
            salariesLabel.Size = new Size(71, 20);
            salariesLabel.TabIndex = 0;
            salariesLabel.Text = "Salaries : ";
            // 
            // profitLabel
            // 
            profitLabel.AutoSize = true;
            profitLabel.Location = new Point(330, 236);
            profitLabel.Name = "profitLabel";
            profitLabel.Size = new Size(113, 20);
            profitLabel.TabIndex = 6;
            profitLabel.Text = "Profit Amount : ";
            // 
            // inputButton
            // 
            inputButton.Location = new Point(330, 45);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(238, 29);
            inputButton.TabIndex = 8;
            inputButton.Text = "Calculate profit from input";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // databaseButton
            // 
            databaseButton.Location = new Point(330, 140);
            databaseButton.Name = "databaseButton";
            databaseButton.Size = new Size(238, 29);
            databaseButton.TabIndex = 9;
            databaseButton.Text = "Calculate profit from database";
            databaseButton.UseVisualStyleBackColor = true;
            databaseButton.Click += databaseButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(330, 344);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 10;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // FinanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 385);
            Controls.Add(resetButton);
            Controls.Add(databaseButton);
            Controls.Add(inputButton);
            Controls.Add(profitLabel);
            Controls.Add(expensesGroupBox);
            Controls.Add(revenueGroupBox);
            Controls.Add(backButton);
            Name = "FinanceForm";
            Text = "FinanceForm";
            revenueGroupBox.ResumeLayout(false);
            revenueGroupBox.PerformLayout();
            expensesGroupBox.ResumeLayout(false);
            expensesGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backButton;
        private GroupBox revenueGroupBox;
        private Label revenueLabel;
        private TextBox serviceTextBox;
        private TextBox salesTextBox;
        private Label serviceLabel;
        private Label salesLabel;
        private GroupBox expensesGroupBox;
        private Label expensesLabel;
        private TextBox rentTextBox;
        private Label rentLabel;
        private TextBox carCostsTextBox;
        private TextBox salariesTextBox;
        private Label carCostsLabel;
        private Label salariesLabel;
        private Label profitLabel;
        private TextBox otherTextBox;
        private Label otherLabel;
        private Button inputButton;
        private Button databaseButton;
        private Button resetButton;
    }
}