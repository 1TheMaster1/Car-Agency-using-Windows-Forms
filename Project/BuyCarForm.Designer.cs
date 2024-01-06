namespace Project
{
    partial class BuyCarForm
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
            yesButton = new Button();
            noButton = new Button();
            amountLabel = new Label();
            amountTextBox = new TextBox();
            proceedLabel = new Label();
            paymentLabel = new Label();
            SuspendLayout();
            // 
            // yesButton
            // 
            yesButton.Location = new Point(284, 311);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(94, 29);
            yesButton.TabIndex = 0;
            yesButton.Text = "Yes";
            yesButton.UseVisualStyleBackColor = true;
            yesButton.Click += yesButton_Click;
            // 
            // noButton
            // 
            noButton.Location = new Point(446, 311);
            noButton.Name = "noButton";
            noButton.Size = new Size(94, 29);
            noButton.TabIndex = 1;
            noButton.Text = "No";
            noButton.UseVisualStyleBackColor = true;
            noButton.Click += noButton_Click;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(165, 96);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(115, 20);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "Amount to buy :";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(342, 96);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(125, 27);
            amountTextBox.TabIndex = 3;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // proceedLabel
            // 
            proceedLabel.AutoSize = true;
            proceedLabel.Location = new Point(135, 315);
            proceedLabel.Name = "proceedLabel";
            proceedLabel.Size = new Size(70, 20);
            proceedLabel.TabIndex = 4;
            proceedLabel.Text = "Proceed :";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new Point(171, 188);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new Size(109, 20);
            paymentLabel.TabIndex = 5;
            paymentLabel.Text = "Total Payment :";
            // 
            // BuyCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(paymentLabel);
            Controls.Add(proceedLabel);
            Controls.Add(amountTextBox);
            Controls.Add(amountLabel);
            Controls.Add(noButton);
            Controls.Add(yesButton);
            Name = "BuyCarForm";
            Text = "BuyCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button yesButton;
        private Button noButton;
        private Label amountLabel;
        private TextBox amountTextBox;
        private Label proceedLabel;
        private Label paymentLabel;
    }
}