namespace Project
{
    partial class ServiceForm
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
            Serviecs = new TabControl();
            tabPage1 = new TabPage();
            payNowButton = new Button();
            paymentAmountLabel = new Label();
            hoursTextBox = new TextBox();
            amountOfHoursLabel = new Label();
            descriptionLabel = new Label();
            packageDescriptionTextBox = new RichTextBox();
            washPackageLabel = new Label();
            carTypeLabel = new Label();
            washPackageComboBox = new ComboBox();
            carTypeComboBox = new ComboBox();
            tabPage2 = new TabPage();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backButton = new Button();
            Serviecs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Serviecs
            // 
            Serviecs.Controls.Add(tabPage1);
            Serviecs.Controls.Add(tabPage2);
            Serviecs.Location = new Point(12, 12);
            Serviecs.Name = "Serviecs";
            Serviecs.SelectedIndex = 0;
            Serviecs.Size = new Size(541, 316);
            Serviecs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(payNowButton);
            tabPage1.Controls.Add(paymentAmountLabel);
            tabPage1.Controls.Add(hoursTextBox);
            tabPage1.Controls.Add(amountOfHoursLabel);
            tabPage1.Controls.Add(descriptionLabel);
            tabPage1.Controls.Add(packageDescriptionTextBox);
            tabPage1.Controls.Add(washPackageLabel);
            tabPage1.Controls.Add(carTypeLabel);
            tabPage1.Controls.Add(washPackageComboBox);
            tabPage1.Controls.Add(carTypeComboBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(533, 288);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Car Washes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // payNowButton
            // 
            payNowButton.Location = new Point(64, 229);
            payNowButton.Name = "payNowButton";
            payNowButton.Size = new Size(75, 23);
            payNowButton.TabIndex = 10;
            payNowButton.Text = "Pay Now";
            payNowButton.UseVisualStyleBackColor = true;
            payNowButton.Click += payNowButton_Click;
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.Location = new Point(6, 172);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new Size(110, 15);
            paymentAmountLabel.TabIndex = 8;
            paymentAmountLabel.Text = "Payment Amount : ";
            // 
            // hoursTextBox
            // 
            hoursTextBox.Location = new Point(113, 132);
            hoursTextBox.Name = "hoursTextBox";
            hoursTextBox.Size = new Size(90, 23);
            hoursTextBox.TabIndex = 7;
            hoursTextBox.TextChanged += HoursTextBox_TextChanged;
            // 
            // amountOfHoursLabel
            // 
            amountOfHoursLabel.AutoSize = true;
            amountOfHoursLabel.Location = new Point(6, 135);
            amountOfHoursLabel.Name = "amountOfHoursLabel";
            amountOfHoursLabel.Size = new Size(106, 15);
            amountOfHoursLabel.TabIndex = 6;
            amountOfHoursLabel.Text = "Amount of Hours :";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(247, 114);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(146, 15);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Wash Package Description";
            // 
            // packageDescriptionTextBox
            // 
            packageDescriptionTextBox.Location = new Point(247, 132);
            packageDescriptionTextBox.Name = "packageDescriptionTextBox";
            packageDescriptionTextBox.Size = new Size(266, 139);
            packageDescriptionTextBox.TabIndex = 4;
            packageDescriptionTextBox.Text = "";
            // 
            // washPackageLabel
            // 
            washPackageLabel.AutoSize = true;
            washPackageLabel.Location = new Point(38, 79);
            washPackageLabel.Name = "washPackageLabel";
            washPackageLabel.Size = new Size(89, 15);
            washPackageLabel.TabIndex = 3;
            washPackageLabel.Text = "Wash Package :";
            // 
            // carTypeLabel
            // 
            carTypeLabel.AutoSize = true;
            carTypeLabel.Location = new Point(48, 39);
            carTypeLabel.Name = "carTypeLabel";
            carTypeLabel.Size = new Size(58, 15);
            carTypeLabel.TabIndex = 2;
            carTypeLabel.Text = "Car Type :";
            // 
            // washPackageComboBox
            // 
            washPackageComboBox.FormattingEnabled = true;
            washPackageComboBox.Items.AddRange(new object[] { "Normal Package", "Luxury Package", "Deluxe Package" });
            washPackageComboBox.Location = new Point(171, 76);
            washPackageComboBox.Name = "washPackageComboBox";
            washPackageComboBox.Size = new Size(342, 23);
            washPackageComboBox.TabIndex = 1;
            washPackageComboBox.SelectedIndexChanged += washPackageComboBox_SelectedIndexChanged;
            // 
            // carTypeComboBox
            // 
            carTypeComboBox.FormattingEnabled = true;
            carTypeComboBox.Items.AddRange(new object[] { "Mini ", "Hatch Back", "Sedan", "SUV", "Sports" });
            carTypeComboBox.Location = new Point(171, 36);
            carTypeComboBox.Name = "carTypeComboBox";
            carTypeComboBox.Size = new Size(342, 23);
            carTypeComboBox.TabIndex = 0;
            carTypeComboBox.SelectedIndexChanged += carTypecomboBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(533, 288);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Car Mantinance";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SquareFont", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(54, 103);
            label6.Name = "label6";
            label6.Size = new Size(419, 50);
            label6.TabIndex = 0;
            label6.Text = "Coming Soon.........";
            // 
            // backButton
            // 
            backButton.Location = new Point(474, 334);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 12;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 367);
            Controls.Add(backButton);
            Controls.Add(Serviecs);
            Name = "ServiceForm";
            Text = "ServiceForm";
            Serviecs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Serviecs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox washPackageComboBox;
        private ComboBox carTypeComboBox;
        private RichTextBox packageDescriptionTextBox;
        private Label washPackageLabel;
        private Label carTypeLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox hoursTextBox;
        private Label amountOfHoursLabel;
        private Label descriptionLabel;
        private Button payNowButton;
        private Label paymentAmountLabel;
        private Label label6;
        private Button backButton;
    }
}