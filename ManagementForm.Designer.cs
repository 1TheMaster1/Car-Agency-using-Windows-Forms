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
            employeeGroupBox.Controls.Add(jobLabel);
            employeeGroupBox.Controls.Add(jobComboBox);
            employeeGroupBox.Controls.Add(salaryLabel);
            employeeGroupBox.Controls.Add(ageLabel);
            employeeGroupBox.Controls.Add(nameLabel);
            employeeGroupBox.Controls.Add(addEmployeeButton);
            employeeGroupBox.Controls.Add(salaryTextBox);
            employeeGroupBox.Controls.Add(ageTextBox);
            employeeGroupBox.Controls.Add(nameTextBox);
            employeeGroupBox.Location = new Point(12, 13);
            employeeGroupBox.Margin = new Padding(3, 4, 3, 4);
            employeeGroupBox.Name = "employeeGroupBox";
            employeeGroupBox.Padding = new Padding(3, 4, 3, 4);
            employeeGroupBox.Size = new Size(374, 351);
            employeeGroupBox.TabIndex = 0;
            employeeGroupBox.TabStop = false;
            employeeGroupBox.Text = "Add Employee";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new Point(37, 173);
            jobLabel.Margin = new Padding(2, 0, 2, 0);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new Size(39, 20);
            jobLabel.TabIndex = 13;
            jobLabel.Text = "Job :";
            // 
            // jobComboBox
            // 
            jobComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            jobComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            jobComboBox.FormattingEnabled = true;
            jobComboBox.Items.AddRange(new object[] { "Management", "Sales", "CommissionedSales", "Finance", "Technician" });
            jobComboBox.Location = new Point(137, 165);
            jobComboBox.Margin = new Padding(2, 3, 2, 3);
            jobComboBox.Name = "jobComboBox";
            jobComboBox.Size = new Size(226, 28);
            jobComboBox.TabIndex = 12;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(37, 136);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(56, 20);
            salaryLabel.TabIndex = 10;
            salaryLabel.Text = "Salary :";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(37, 98);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(43, 20);
            ageLabel.TabIndex = 9;
            ageLabel.Text = "Age :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(37, 59);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 20);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name :";
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.Location = new Point(292, 310);
            addEmployeeButton.Margin = new Padding(3, 4, 3, 4);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(76, 33);
            addEmployeeButton.TabIndex = 7;
            addEmployeeButton.Text = "Add";
            addEmployeeButton.UseVisualStyleBackColor = true;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // salaryTextBox
            // 
            salaryTextBox.Location = new Point(137, 129);
            salaryTextBox.Margin = new Padding(3, 4, 3, 4);
            salaryTextBox.Name = "salaryTextBox";
            salaryTextBox.Size = new Size(226, 27);
            salaryTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(137, 91);
            ageTextBox.Margin = new Padding(3, 4, 3, 4);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(226, 27);
            ageTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(137, 52);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(226, 27);
            nameTextBox.TabIndex = 0;
            // 
            // employeeDisplayList
            // 
            employeeDisplayList.FormattingEnabled = true;
            employeeDisplayList.ItemHeight = 20;
            employeeDisplayList.Location = new Point(391, 13);
            employeeDisplayList.Margin = new Padding(2, 3, 2, 3);
            employeeDisplayList.Name = "employeeDisplayList";
            employeeDisplayList.Size = new Size(615, 304);
            employeeDisplayList.TabIndex = 1;
            // 
            // updateEmployeeButton
            // 
            updateEmployeeButton.Location = new Point(868, 323);
            updateEmployeeButton.Margin = new Padding(2, 3, 2, 3);
            updateEmployeeButton.Name = "updateEmployeeButton";
            updateEmployeeButton.Size = new Size(138, 37);
            updateEmployeeButton.TabIndex = 2;
            updateEmployeeButton.Text = "Update Employee";
            updateEmployeeButton.UseVisualStyleBackColor = true;
            updateEmployeeButton.Click += updateEmployeeButton_Click;
            // 
            // removeEmployeeButton
            // 
            removeEmployeeButton.Location = new Point(715, 323);
            removeEmployeeButton.Margin = new Padding(2, 3, 2, 3);
            removeEmployeeButton.Name = "removeEmployeeButton";
            removeEmployeeButton.Size = new Size(149, 37);
            removeEmployeeButton.TabIndex = 3;
            removeEmployeeButton.Text = "Remove Employee";
            removeEmployeeButton.UseVisualStyleBackColor = true;
            removeEmployeeButton.Click += removeEmployeeButton_Click;
            // 
            // customerGroupBox
            // 
            customerGroupBox.Controls.Add(customerNumberTextBox);
            customerGroupBox.Controls.Add(customerAgeTextBox);
            customerGroupBox.Controls.Add(customerNameTextBox);
            customerGroupBox.Controls.Add(addCustomerButton);
            customerGroupBox.Controls.Add(customerPhoneNumber);
            customerGroupBox.Controls.Add(customerAge);
            customerGroupBox.Controls.Add(customerName);
            customerGroupBox.Location = new Point(12, 371);
            customerGroupBox.Margin = new Padding(2, 3, 2, 3);
            customerGroupBox.Name = "customerGroupBox";
            customerGroupBox.Padding = new Padding(2, 3, 2, 3);
            customerGroupBox.Size = new Size(374, 292);
            customerGroupBox.TabIndex = 4;
            customerGroupBox.TabStop = false;
            customerGroupBox.Text = "Add Customer";
            // 
            // customerNumberTextBox
            // 
            customerNumberTextBox.Location = new Point(137, 163);
            customerNumberTextBox.Margin = new Padding(2, 3, 2, 3);
            customerNumberTextBox.Name = "customerNumberTextBox";
            customerNumberTextBox.Size = new Size(228, 27);
            customerNumberTextBox.TabIndex = 6;
            // 
            // customerAgeTextBox
            // 
            customerAgeTextBox.Location = new Point(137, 124);
            customerAgeTextBox.Margin = new Padding(2, 3, 2, 3);
            customerAgeTextBox.Name = "customerAgeTextBox";
            customerAgeTextBox.Size = new Size(226, 27);
            customerAgeTextBox.TabIndex = 5;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new Point(137, 85);
            customerNameTextBox.Margin = new Padding(2, 3, 2, 3);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(226, 27);
            customerNameTextBox.TabIndex = 4;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(292, 250);
            addCustomerButton.Margin = new Padding(2, 3, 2, 3);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(78, 36);
            addCustomerButton.TabIndex = 3;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // customerPhoneNumber
            // 
            customerPhoneNumber.AutoSize = true;
            customerPhoneNumber.Location = new Point(6, 167);
            customerPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            customerPhoneNumber.Name = "customerPhoneNumber";
            customerPhoneNumber.Size = new Size(108, 20);
            customerPhoneNumber.TabIndex = 2;
            customerPhoneNumber.Text = "Phone Number";
            // 
            // customerAge
            // 
            customerAge.AutoSize = true;
            customerAge.Location = new Point(45, 129);
            customerAge.Margin = new Padding(2, 0, 2, 0);
            customerAge.Name = "customerAge";
            customerAge.Size = new Size(36, 20);
            customerAge.TabIndex = 1;
            customerAge.Text = "Age";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(37, 89);
            customerName.Margin = new Padding(2, 0, 2, 0);
            customerName.Name = "customerName";
            customerName.Size = new Size(49, 20);
            customerName.TabIndex = 0;
            customerName.Text = "Name";
            // 
            // customerDisplayList
            // 
            customerDisplayList.FormattingEnabled = true;
            customerDisplayList.ItemHeight = 20;
            customerDisplayList.Location = new Point(391, 371);
            customerDisplayList.Margin = new Padding(2, 3, 2, 3);
            customerDisplayList.Name = "customerDisplayList";
            customerDisplayList.Size = new Size(615, 244);
            customerDisplayList.TabIndex = 5;
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.Location = new Point(868, 621);
            updateCustomerButton.Margin = new Padding(2, 3, 2, 3);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(138, 36);
            updateCustomerButton.TabIndex = 6;
            updateCustomerButton.Text = "Update Customer";
            updateCustomerButton.UseVisualStyleBackColor = true;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // removeCustomerButton
            // 
            removeCustomerButton.Location = new Point(713, 621);
            removeCustomerButton.Margin = new Padding(2, 3, 2, 3);
            removeCustomerButton.Name = "removeCustomerButton";
            removeCustomerButton.Size = new Size(151, 36);
            removeCustomerButton.TabIndex = 7;
            removeCustomerButton.Text = "Remove Customer";
            removeCustomerButton.UseVisualStyleBackColor = true;
            removeCustomerButton.Click += removeCustomerButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(868, 691);
            backButton.Name = "backButton";
            backButton.Size = new Size(137, 28);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 731);
            Controls.Add(backButton);
            Controls.Add(removeCustomerButton);
            Controls.Add(updateCustomerButton);
            Controls.Add(customerDisplayList);
            Controls.Add(customerGroupBox);
            Controls.Add(removeEmployeeButton);
            Controls.Add(updateEmployeeButton);
            Controls.Add(employeeDisplayList);
            Controls.Add(employeeGroupBox);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}