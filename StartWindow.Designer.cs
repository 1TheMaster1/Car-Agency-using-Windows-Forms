namespace Project
{
    partial class StartWindow
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
            welcomeLabel = new Label();
            loginButton = new Button();
            nameLabel = new Label();
            passwordLabel = new Label();
            NameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Magneto", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(14, 12);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(477, 141);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Star's Car Agency";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(153, 296);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(203, 69);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(26, 167);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(91, 20);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(35, 216);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(79, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(125, 163);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(334, 27);
            NameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(125, 212);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(334, 27);
            passwordTextBox.TabIndex = 5;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(504, 404);
            Controls.Add(passwordTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(nameLabel);
            Controls.Add(loginButton);
            Controls.Add(welcomeLabel);
            Name = "StartWindow";
            Text = "StartWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button loginButton;
        private Label nameLabel;
        private Label passwordLabel;
        private TextBox NameTextBox;
        private TextBox passwordTextBox;
    }
}