namespace Project
{
    partial class InventoryForm
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
            searchButton = new Button();
            carPictureBox = new PictureBox();
            makeLabel = new Label();
            modelLabel = new Label();
            colorLabel = new Label();
            horsePowerLabel = new Label();
            typeLabel = new Label();
            purchasePriceLabel = new Label();
            sellingPriceLabel = new Label();
            carImageLabel = new Label();
            makeTextBox = new TextBox();
            modelTextBox = new TextBox();
            colorTextBox = new TextBox();
            horsePowerTextBox = new TextBox();
            purchasePriceTextBox = new TextBox();
            typeTextBox = new TextBox();
            carImageTextBox = new TextBox();
            sellingPriceTextBox = new TextBox();
            searchComboBox = new ComboBox();
            addButton = new Button();
            buyButton = new Button();
            sellButton = new Button();
            amountTextBox = new TextBox();
            amountLabel = new Label();
            backButton = new Button();
            resetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new Point(396, 18);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(82, 22);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // carPictureBox
            // 
            carPictureBox.Location = new Point(396, 65);
            carPictureBox.Margin = new Padding(3, 2, 3, 2);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(268, 169);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 2;
            carPictureBox.TabStop = false;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(49, 95);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(42, 15);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make :";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(49, 70);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(47, 15);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Model :";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(49, 120);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(42, 15);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Color :";
            // 
            // horsePowerLabel
            // 
            horsePowerLabel.AutoSize = true;
            horsePowerLabel.Location = new Point(49, 145);
            horsePowerLabel.Name = "horsePowerLabel";
            horsePowerLabel.Size = new Size(80, 15);
            horsePowerLabel.TabIndex = 6;
            horsePowerLabel.Text = "Horse Power :";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(49, 170);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(37, 15);
            typeLabel.TabIndex = 7;
            typeLabel.Text = "Type :";
            // 
            // purchasePriceLabel
            // 
            purchasePriceLabel.AutoSize = true;
            purchasePriceLabel.Location = new Point(49, 194);
            purchasePriceLabel.Name = "purchasePriceLabel";
            purchasePriceLabel.Size = new Size(90, 15);
            purchasePriceLabel.TabIndex = 8;
            purchasePriceLabel.Text = "Purchase Price :";
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.AutoSize = true;
            sellingPriceLabel.Location = new Point(49, 219);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new Size(77, 15);
            sellingPriceLabel.TabIndex = 9;
            sellingPriceLabel.Text = "Selling Price :";
            // 
            // carImageLabel
            // 
            carImageLabel.AutoSize = true;
            carImageLabel.Location = new Point(49, 244);
            carImageLabel.Name = "carImageLabel";
            carImageLabel.Size = new Size(91, 15);
            carImageLabel.TabIndex = 10;
            carImageLabel.Text = "Car Image URL :";
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(164, 90);
            makeTextBox.Margin = new Padding(3, 2, 3, 2);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(110, 23);
            makeTextBox.TabIndex = 11;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(164, 65);
            modelTextBox.Margin = new Padding(3, 2, 3, 2);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(110, 23);
            modelTextBox.TabIndex = 12;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(164, 115);
            colorTextBox.Margin = new Padding(3, 2, 3, 2);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(110, 23);
            colorTextBox.TabIndex = 13;
            // 
            // horsePowerTextBox
            // 
            horsePowerTextBox.Location = new Point(164, 140);
            horsePowerTextBox.Margin = new Padding(3, 2, 3, 2);
            horsePowerTextBox.Name = "horsePowerTextBox";
            horsePowerTextBox.Size = new Size(110, 23);
            horsePowerTextBox.TabIndex = 14;
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.Location = new Point(164, 189);
            purchasePriceTextBox.Margin = new Padding(3, 2, 3, 2);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.Size = new Size(110, 23);
            purchasePriceTextBox.TabIndex = 15;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(164, 164);
            typeTextBox.Margin = new Padding(3, 2, 3, 2);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(110, 23);
            typeTextBox.TabIndex = 16;
            // 
            // carImageTextBox
            // 
            carImageTextBox.Location = new Point(164, 238);
            carImageTextBox.Margin = new Padding(3, 2, 3, 2);
            carImageTextBox.Name = "carImageTextBox";
            carImageTextBox.Size = new Size(110, 23);
            carImageTextBox.TabIndex = 17;
            // 
            // sellingPriceTextBox
            // 
            sellingPriceTextBox.Location = new Point(164, 214);
            sellingPriceTextBox.Margin = new Padding(3, 2, 3, 2);
            sellingPriceTextBox.Name = "sellingPriceTextBox";
            sellingPriceTextBox.Size = new Size(110, 23);
            sellingPriceTextBox.TabIndex = 18;
            // 
            // searchComboBox
            // 
            searchComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Location = new Point(164, 18);
            searchComboBox.Margin = new Padding(3, 2, 3, 2);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(227, 23);
            searchComboBox.TabIndex = 19;
            // 
            // addButton
            // 
            addButton.Location = new Point(49, 302);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 22);
            addButton.TabIndex = 20;
            addButton.Text = "Add Car";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // buyButton
            // 
            buyButton.Location = new Point(49, 338);
            buyButton.Margin = new Padding(3, 2, 3, 2);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(82, 22);
            buyButton.TabIndex = 21;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // sellButton
            // 
            sellButton.Location = new Point(173, 338);
            sellButton.Margin = new Padding(3, 2, 3, 2);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(82, 22);
            sellButton.TabIndex = 22;
            sellButton.Text = "Sell";
            sellButton.UseVisualStyleBackColor = true;
            sellButton.Click += sellButton_Click;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(164, 263);
            amountTextBox.Margin = new Padding(3, 2, 3, 2);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(110, 23);
            amountTextBox.TabIndex = 24;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(49, 266);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(102, 15);
            amountLabel.TabIndex = 25;
            amountLabel.Text = "Amount in Stock :";
            // 
            // backButton
            // 
            backButton.Location = new Point(601, 340);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(88, 20);
            backButton.TabIndex = 26;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(173, 302);
            resetButton.Margin = new Padding(3, 2, 3, 2);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(82, 22);
            resetButton.TabIndex = 27;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 445);
            Controls.Add(resetButton);
            Controls.Add(backButton);
            Controls.Add(amountLabel);
            Controls.Add(amountTextBox);
            Controls.Add(sellButton);
            Controls.Add(buyButton);
            Controls.Add(addButton);
            Controls.Add(searchComboBox);
            Controls.Add(sellingPriceTextBox);
            Controls.Add(carImageTextBox);
            Controls.Add(typeTextBox);
            Controls.Add(purchasePriceTextBox);
            Controls.Add(horsePowerTextBox);
            Controls.Add(colorTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(makeTextBox);
            Controls.Add(carImageLabel);
            Controls.Add(sellingPriceLabel);
            Controls.Add(purchasePriceLabel);
            Controls.Add(typeLabel);
            Controls.Add(horsePowerLabel);
            Controls.Add(colorLabel);
            Controls.Add(modelLabel);
            Controls.Add(makeLabel);
            Controls.Add(carPictureBox);
            Controls.Add(searchButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button searchButton;
        private PictureBox carPictureBox;
        private Label makeLabel;
        private Label modelLabel;
        private Label colorLabel;
        private Label horsePowerLabel;
        private Label typeLabel;
        private Label purchasePriceLabel;
        private Label sellingPriceLabel;
        private Label carImageLabel;
        private TextBox makeTextBox;
        private TextBox modelTextBox;
        private TextBox colorTextBox;
        private TextBox horsePowerTextBox;
        private TextBox purchasePriceTextBox;
        private TextBox typeTextBox;
        private TextBox carImageTextBox;
        private TextBox sellingPriceTextBox;
        private ComboBox searchComboBox;
        private Button addButton;
        private Button buyButton;
        private Button sellButton;
        private TextBox amountTextBox;
        private Label amountLabel;
        private Button backButton;
        private Button resetButton;
    }
}