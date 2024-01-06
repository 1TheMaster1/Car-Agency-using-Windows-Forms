namespace Project
{
    partial class SellCarForm
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
            customerDisplayList = new ListBox();
            yesButton = new Button();
            noButton = new Button();
            amountLabel = new Label();
            proceedLabel = new Label();
            amountTextBox = new TextBox();
            paymentLabel = new Label();
            SuspendLayout();
            // 
            // customerDisplayList
            // 
            customerDisplayList.FormattingEnabled = true;
            customerDisplayList.ItemHeight = 20;
            customerDisplayList.Location = new Point(318, 12);
            customerDisplayList.Name = "customerDisplayList";
            customerDisplayList.Size = new Size(432, 224);
            customerDisplayList.TabIndex = 0;
            // 
            // yesButton
            // 
            yesButton.Location = new Point(130, 296);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(94, 29);
            yesButton.TabIndex = 1;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            // 
            // noButton
            // 
            noButton.Location = new Point(261, 296);
            noButton.Name = "noButton";
            noButton.Size = new Size(94, 29);
            noButton.TabIndex = 2;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(32, 105);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(113, 20);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "Amount to sell :";
            // 
            // proceedLabel
            // 
            proceedLabel.AutoSize = true;
            proceedLabel.Location = new Point(32, 296);
            proceedLabel.Name = "proceedLabel";
            proceedLabel.Size = new Size(74, 20);
            proceedLabel.TabIndex = 4;
            proceedLabel.Text = "Proceed : ";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(168, 102);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(125, 27);
            amountTextBox.TabIndex = 5;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new Point(32, 180);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(109, 20);
            paymentLabel.TabIndex = 6;
            paymentLabel.Text = "Total Payment :";
            // 
            // SellCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 355);
            Controls.Add(paymentLabel);
            Controls.Add(amountTextBox);
            Controls.Add(proceedLabel);
            Controls.Add(amountLabel);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Controls.Add(customerDisplayList);
            Name = "SellCarForm";
            Text = "SellCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox customerDisplayList;
        private Button yesButton;
        private Button noButton;
        private Label amountLabel;
        private Label proceedLabel;
        private TextBox amountTextBox;
        private Label paymentLabel;
    }
}