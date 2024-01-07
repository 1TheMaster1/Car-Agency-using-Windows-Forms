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
            Amount = new Label();
            payNowButton = new Button();
            label5 = new Label();
            HoursTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            PackageDescriptionTextBox = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            washPackageComboBox = new ComboBox();
            carTypecomboBox = new ComboBox();
            tabPage2 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Serviecs.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabPage1.Controls.Add(Amount);
            tabPage1.Controls.Add(payNowButton);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(HoursTextBox);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(PackageDescriptionTextBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(washPackageComboBox);
            tabPage1.Controls.Add(carTypecomboBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(533, 288);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Car Washes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Location = new Point(113, 187);
            Amount.Name = "Amount";
            Amount.Size = new Size(51, 15);
            Amount.TabIndex = 11;
            Amount.Text = "Amount";
            Amount.Click += Amount_Click;
            // 
            // payNowButton
            // 
            payNowButton.Location = new Point(152, 248);
            payNowButton.Name = "payNowButton";
            payNowButton.Size = new Size(75, 23);
            payNowButton.TabIndex = 10;
            payNowButton.Text = "Pay Now";
            payNowButton.UseVisualStyleBackColor = true;
            payNowButton.Click += payNowButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 187);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 8;
            label5.Text = "Payment Amount : ";
            // 
            // HoursTextBox
            // 
            HoursTextBox.Location = new Point(48, 156);
            HoursTextBox.Name = "HoursTextBox";
            HoursTextBox.Size = new Size(179, 23);
            HoursTextBox.TabIndex = 7;
            HoursTextBox.TextChanged += HoursTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 135);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 6;
            label4.Text = "Amount of hours :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 114);
            label3.Name = "label3";
            label3.Size = new Size(145, 15);
            label3.TabIndex = 5;
            label3.Text = "Wash package description";
            // 
            // PackageDescriptionTextBox
            // 
            PackageDescriptionTextBox.Location = new Point(247, 132);
            PackageDescriptionTextBox.Name = "PackageDescriptionTextBox";
            PackageDescriptionTextBox.Size = new Size(266, 139);
            PackageDescriptionTextBox.TabIndex = 4;
            PackageDescriptionTextBox.Text = "";
            PackageDescriptionTextBox.TextChanged += PackageDescriptionTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 79);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "Wash Package";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 39);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Car Type";
            // 
            // washPackageComboBox
            // 
            washPackageComboBox.FormattingEnabled = true;
            washPackageComboBox.Items.AddRange(new object[] { "Normal Package", "Lauxary Package", "Deluex Package" });
            washPackageComboBox.Location = new Point(171, 76);
            washPackageComboBox.Name = "washPackageComboBox";
            washPackageComboBox.Size = new Size(342, 23);
            washPackageComboBox.TabIndex = 1;
            washPackageComboBox.SelectedIndexChanged += washPackageComboBox_SelectedIndexChanged;
            // 
            // carTypecomboBox
            // 
            carTypecomboBox.FormattingEnabled = true;
            carTypecomboBox.Items.AddRange(new object[] { "Mini Car", "Hatch Back", "Sedan", "SUV", "Sports Car" });
            carTypecomboBox.Location = new Point(171, 36);
            carTypecomboBox.Name = "carTypecomboBox";
            carTypecomboBox.Size = new Size(342, 23);
            carTypecomboBox.TabIndex = 0;
            carTypecomboBox.SelectedIndexChanged += carTypecomboBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(533, 288);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Car Mantinance";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 333);
            Controls.Add(Serviecs);
            Name = "ServiceForm";
            Text = "ServiceForm";
            Serviecs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Serviecs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox washPackageComboBox;
        private ComboBox carTypecomboBox;
        private RichTextBox PackageDescriptionTextBox;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox HoursTextBox;
        private Label label4;
        private Label label3;
        private Button payNowButton;
        private Label label5;
        private Label Amount;
    }
}