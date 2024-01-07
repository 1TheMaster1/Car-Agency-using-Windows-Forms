namespace Project
{
    partial class ManagementForm
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
            employeeGroupBox = new GroupBox();
            employeeResetButton = new Button();
            jobLabel = new Label();
            jobComboBox = new ComboBox();
            salaryLabel = new Label();
            ageLabel = new Label();
            nameLabel = new Label();
            addEmployeeButton = new Button();
            salaryTextBox = new TextBox();
            ageTextBox = new TextBox();
            nameTextBox = new TextBox();
            employeeDisplayList = new ListBox();
            updateEmployeeButton = new Button();
            removeEmployeeButton = new Button();
            customerGroupBox = new GroupBox();
            customerResetButton = new Button();
            customerNumberTextBox = new TextBox();
            customerAgeTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            addCustomerButton = new Button();
            customerPhoneNumber = new Label();
            customerAge = new Label();
            customerName = new Label();
            customerDisplayList = new ListBox();
            updateCustomerButton = new Button();
            removeCustomerButton = new Button();
            backButton = new Button();
            employeeGroupBox.SuspendLayout();
            customerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // employeeGroupBox
            // 
            employeeGroupBox.Controls.Add(employeeResetButton);
            employeeGroupBox.Controls.Add(jobLabel);
            employeeGroupBox.Controls.Add(jobComboBox);
            employeeGroupBox.Controls.Add(salaryLabel);
            employeeGroupBox.Controls.Add(ageLabel);
            employeeGroupBox.Controls.Add(nameLabel);
            employeeGroupBox.Controls.Add(addEmployeeButton);
            employeeGroupBox.Controls.Add(salaryTextBox);
            employeeGroupBox.Controls.Add(ageTextBox);
            employeeGroupBox.Controls.Add(nameTextBox);
            employeeGroupBox.Location = new Point(10, 10);
            employeeGroupBox.Name = "employeeGroupBox";
            employeeGroupBox.Size = new Size(327, 263);
            employeeGroupBox.TabIndex = 0;
            employeeGroupBox.TabStop = false;
            employeeGroupBox.Text = "Add Employee";
            // 
            // employeeResetButton
            // 
            employeeResetButton.Location = new Point(32, 232);
            employeeResetButton.Margin = new Padding(3, 2, 3, 2);
            employeeResetButton.Name = "employeeResetButton";
            employeeResetButton.Size = new Size(67, 25);
            employeeResetButton.TabIndex = 14;
            employeeResetButton.Text = "Reset";
            employeeResetButton.UseVisualStyleBackColor = true;
            employeeResetButton.Click += employeeResetButton_Click;
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new Point(32, 130);
            jobLabel.Margin = new Padding(2, 0, 2, 0);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new Size(31, 15);
            jobLabel.TabIndex = 13;
            jobLabel.Text = "Job :";
            // 
            // jobComboBox
            // 
            jobComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            jobComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            jobComboBox.FormattingEnabled = true;
            jobComboBox.Items.AddRange(new object[] { "Management", "Sales", "CommissionedSales", "Finance", "Technician" });
            jobComboBox.Location = new Point(120, 124);
            jobComboBox.Margin = new Padding(2);
            jobComboBox.Name = "jobComboBox";
            jobComboBox.Size = new Size(198, 23);
            jobComboBox.TabIndex = 12;
            jobComboBox.SelectedIndexChanged += jobComboBox_SelectedIndexChanged;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(32, 102);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(44, 15);
            salaryLabel.TabIndex = 10;
            salaryLabel.Text = "Salary :";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(32, 74);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(34, 15);
            ageLabel.TabIndex = 9;
            ageLabel.Text = "Age :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(32, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 15);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name :";
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.Location = new Point(256, 232);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(66, 25);
            addEmployeeButton.TabIndex = 7;
            addEmployeeButton.Text = "Add";
            addEmployeeButton.UseVisualStyleBackColor = true;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(120, 97);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(198, 23);
            salaryTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(120, 68);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(198, 23);
            ageTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(120, 39);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(198, 23);
            nameTextBox.TabIndex = 0;
            // 
            // employeeDisplayList
            // 
            employeeDisplayList.FormattingEnabled = true;
            employeeDisplayList.ItemHeight = 15;
            employeeDisplayList.Location = new Point(342, 10);
            employeeDisplayList.Margin = new Padding(2);
            employeeDisplayList.Name = "employeeDisplayList";
            employeeDisplayList.Size = new Size(539, 229);
            employeeDisplayList.TabIndex = 1;
            // 
            // updateEmployeeButton
            // 
            updateEmployeeButton.Location = new Point(760, 242);
            updateEmployeeButton.Margin = new Padding(2);
            updateEmployeeButton.Name = "updateEmployeeButton";
            updateEmployeeButton.Size = new Size(121, 28);
            updateEmployeeButton.TabIndex = 2;
            updateEmployeeButton.Text = "Update Employee";
            updateEmployeeButton.UseVisualStyleBackColor = true;
            updateEmployeeButton.Click += updateEmployeeButton_Click;
            // 
            // removeEmployeeButton
            // 
            removeEmployeeButton.Location = new Point(626, 242);
            removeEmployeeButton.Margin = new Padding(2);
            removeEmployeeButton.Name = "removeEmployeeButton";
            removeEmployeeButton.Size = new Size(130, 28);
            removeEmployeeButton.TabIndex = 3;
            removeEmployeeButton.Text = "Remove Employee";
            removeEmployeeButton.UseVisualStyleBackColor = true;
            removeEmployeeButton.Click += removeEmployeeButton_Click;
            // 
            // customerGroupBox
            // 
            customerGroupBox.Controls.Add(customerResetButton);
            customerGroupBox.Controls.Add(customerNumberTextBox);
            customerGroupBox.Controls.Add(customerAgeTextBox);
            customerGroupBox.Controls.Add(customerNameTextBox);
            customerGroupBox.Controls.Add(addCustomerButton);
            customerGroupBox.Controls.Add(customerPhoneNumber);
            customerGroupBox.Controls.Add(customerAge);
            customerGroupBox.Controls.Add(customerName);
            customerGroupBox.Location = new Point(10, 278);
            customerGroupBox.Margin = new Padding(2);
            customerGroupBox.Name = "customerGroupBox";
            customerGroupBox.Padding = new Padding(2);
            customerGroupBox.Size = new Size(327, 219);
            customerGroupBox.TabIndex = 4;
            customerGroupBox.TabStop = false;
            customerGroupBox.Text = "Add Customer";
            // 
            // customerResetButton
            // 
            customerResetButton.Location = new Point(32, 188);
            customerResetButton.Margin = new Padding(3, 2, 3, 2);
            customerResetButton.Name = "customerResetButton";
            customerResetButton.Size = new Size(67, 27);
            customerResetButton.TabIndex = 7;
            customerResetButton.Text = "Reset";
            customerResetButton.UseVisualStyleBackColor = true;
            customerResetButton.Click += customerResetButton_Click;
            // 
            // customerNumberTextBox
            // 
            customerNumberTextBox.Location = new Point(120, 122);
            customerNumberTextBox.Margin = new Padding(2);
            customerNumberTextBox.Name = "customerNumberTextBox";
            customerNumberTextBox.Size = new Size(200, 23);
            customerNumberTextBox.TabIndex = 6;
            // 
            // customerAgeTextBox
            // 
            customerAgeTextBox.Location = new Point(120, 93);
            customerAgeTextBox.Margin = new Padding(2);
            customerAgeTextBox.Name = "customerAgeTextBox";
            customerAgeTextBox.Size = new Size(198, 23);
            customerAgeTextBox.TabIndex = 5;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(120, 64);
            customerNameTextBox.Margin = new Padding(2);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(198, 23);
            customerNameTextBox.TabIndex = 4;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(256, 188);
            addCustomerButton.Margin = new Padding(2);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(68, 27);
            addCustomerButton.TabIndex = 3;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // customerPhoneNumber
            // 
            customerPhoneNumber.AutoSize = true;
            customerPhoneNumber.Location = new Point(5, 125);
            customerPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            customerPhoneNumber.Name = "customerPhoneNumber";
            customerPhoneNumber.Size = new Size(88, 15);
            customerPhoneNumber.TabIndex = 2;
            customerPhoneNumber.Text = "Phone Number";
            // 
            // customerAge
            // 
            customerAge.AutoSize = true;
            customerAge.Location = new Point(39, 97);
            customerAge.Margin = new Padding(2, 0, 2, 0);
            customerAge.Name = "customerAge";
            customerAge.Size = new Size(28, 15);
            customerAge.TabIndex = 1;
            customerAge.Text = "Age";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(32, 67);
            customerName.Margin = new Padding(2, 0, 2, 0);
            customerName.Name = "customerName";
            customerName.Size = new Size(39, 15);
            customerName.TabIndex = 0;
            customerName.Text = "Name";
            // 
            // customerDisplayList
            // 
            customerDisplayList.FormattingEnabled = true;
            customerDisplayList.ItemHeight = 15;
            customerDisplayList.Location = new Point(342, 278);
            customerDisplayList.Margin = new Padding(2);
            customerDisplayList.Name = "customerDisplayList";
            customerDisplayList.Size = new Size(539, 184);
            customerDisplayList.TabIndex = 5;
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.Location = new Point(760, 466);
            updateCustomerButton.Margin = new Padding(2);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(121, 27);
            updateCustomerButton.TabIndex = 6;
            updateCustomerButton.Text = "Update Customer";
            updateCustomerButton.UseVisualStyleBackColor = true;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // removeCustomerButton
            // 
            removeCustomerButton.Location = new Point(624, 466);
            removeCustomerButton.Margin = new Padding(2);
            removeCustomerButton.Name = "removeCustomerButton";
            removeCustomerButton.Size = new Size(132, 27);
            removeCustomerButton.TabIndex = 7;
            removeCustomerButton.Text = "Remove Customer";
            removeCustomerButton.UseVisualStyleBackColor = true;
            removeCustomerButton.Click += removeCustomerButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(760, 518);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(120, 21);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 548);
            Controls.Add(backButton);
            Controls.Add(removeCustomerButton);
            Controls.Add(updateCustomerButton);
            Controls.Add(customerDisplayList);
            Controls.Add(customerGroupBox);
            Controls.Add(removeEmployeeButton);
            Controls.Add(updateEmployeeButton);
            Controls.Add(employeeDisplayList);
            Controls.Add(employeeGroupBox);
            Name = "ManagementForm";
            Text = "ManagementForm";
            employeeGroupBox.ResumeLayout(false);
            employeeGroupBox.PerformLayout();
            customerGroupBox.ResumeLayout(false);
            customerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox employeeGroupBox;
        private TextBox salaryTextBox;
        private TextBox ageTextBox;
        private TextBox nameTextBox;
        private Label salaryLabel;
        private Label ageLabel;
        private Label nameLabel;
        private Button addEmployeeButton;
        private ComboBox jobComboBox;
        private Label jobLabel;
        private ListBox employeeDisplayList;
        private Button updateEmployeeButton;
        private Button removeEmployeeButton;
        private GroupBox customerGroupBox;
        private ListBox customerDisplayList;
        private TextBox customerNumberTextBox;
        private TextBox customerAgeTextBox;
        private TextBox customerNameTextBox;
        private Button addCustomerButton;
        private Label customerPhoneNumber;
        private Label customerAge;
        private Label customerName;
        private Button updateCustomerButton;
        private Button removeCustomerButton;
        private Button backButton;
        private Button employeeResetButton;
        private Button customerResetButton;
    }
}