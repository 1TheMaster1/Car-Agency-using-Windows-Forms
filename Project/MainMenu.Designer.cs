namespace Project
{
    partial class MainMenu
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
            inventoryButton = new Button();
            managementButton = new Button();
            financeButton = new Button();
            serviceButton = new Button();
            backButton = new Button();
            userLabel1 = new Label();
            userLabel2 = new Label();
            SuspendLayout();
            // 
            // inventoryButton
            // 
            inventoryButton.Location = new Point(169, 51);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(127, 73);
            inventoryButton.TabIndex = 0;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // managementButton
            // 
            managementButton.Location = new Point(14, 51);
            managementButton.Name = "managementButton";
            managementButton.Size = new Size(149, 73);
            managementButton.TabIndex = 1;
            managementButton.Text = "Management";
            managementButton.UseVisualStyleBackColor = true;
            managementButton.Click += managementButton_Click;
            // 
            // financeButton
            // 
            financeButton.Location = new Point(303, 51);
            financeButton.Name = "financeButton";
            financeButton.Size = new Size(139, 73);
            financeButton.TabIndex = 2;
            financeButton.Text = "Finance";
            financeButton.UseVisualStyleBackColor = true;
            financeButton.Click += financeButton_Click;
            // 
            // serviceButton
            // 
            serviceButton.Location = new Point(449, 51);
            serviceButton.Name = "serviceButton";
            serviceButton.Size = new Size(149, 73);
            serviceButton.TabIndex = 3;
            serviceButton.Text = "Service";
            serviceButton.UseVisualStyleBackColor = true;
            serviceButton.Click += serviceButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(512, 273);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(86, 31);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // userLabel1
            // 
            userLabel1.AutoSize = true;
            userLabel1.Location = new Point(14, 9);
            userLabel1.Name = "userLabel1";
            userLabel1.Size = new Size(45, 20);
            userLabel1.TabIndex = 5;
            userLabel1.Text = "User :";
            // 
            // userLabel2
            // 
            userLabel2.AutoSize = true;
            userLabel2.Location = new Point(65, 9);
            userLabel2.Name = "userLabel2";
            userLabel2.Size = new Size(38, 20);
            userLabel2.TabIndex = 6;
            userLabel2.Text = "User";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 320);
            Controls.Add(userLabel2);
            Controls.Add(userLabel1);
            Controls.Add(backButton);
            Controls.Add(serviceButton);
            Controls.Add(financeButton);
            Controls.Add(managementButton);
            Controls.Add(inventoryButton);
            Name = "MainMenu";
            ShowIcon = false;
            Text = "MainMenu";
            FormClosed += MainMenu_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inventoryButton;
        private Button managementButton;
        private Button financeButton;
        private Button serviceButton;
        private Button backButton;
        private Label userLabel1;
        private Label userLabel2;
    }
}