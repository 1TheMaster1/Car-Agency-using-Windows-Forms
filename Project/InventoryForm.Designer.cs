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
            searchButton.Location = new Point(452, 24);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 1;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // carPictureBox
            // 
            carPictureBox.Location = new Point(452, 87);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(306, 225);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 2;
            carPictureBox.TabStop = false;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(56, 127);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(52, 20);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make :";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(56, 94);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(59, 20);
            modelLabel.TabIndex = 4;
            modelLabel.Text = "Model :";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(56, 160);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(52, 20);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Color :";
            // 
            // horsePowerLabel
            // 
            horsePowerLabel.AutoSize = true;
            horsePowerLabel.Location = new Point(56, 193);
            horsePowerLabel.Name = "horsePowerLabel";
            horsePowerLabel.Size = new Size(99, 20);
            horsePowerLabel.TabIndex = 6;
            horsePowerLabel.Text = "Horse Power :";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(56, 226);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(47, 20);
            typeLabel.TabIndex = 7;
            typeLabel.Text = "Type :";
            // 
            // purchasePriceLabel
            // 
            purchasePriceLabel.AutoSize = true;
            purchasePriceLabel.Location = new Point(56, 259);
            purchasePriceLabel.Name = "purchasePriceLabel";
            purchasePriceLabel.Size = new Size(110, 20);
            purchasePriceLabel.TabIndex = 8;
            purchasePriceLabel.Text = "Purchase Price :";
            // 
            // sellingPriceLabel
            // 
            sellingPriceLabel.AutoSize = true;
            sellingPriceLabel.Location = new Point(56, 292);
            sellingPriceLabel.Name = "sellingPriceLabel";
            sellingPriceLabel.Size = new Size(97, 20);
            sellingPriceLabel.TabIndex = 9;
            sellingPriceLabel.Text = "Selling Price :";
            // 
            // carImageLabel
            // 
            carImageLabel.AutoSize = true;
            carImageLabel.Location = new Point(56, 325);
            carImageLabel.Name = "carImageLabel";
            carImageLabel.Size = new Size(114, 20);
            carImageLabel.TabIndex = 10;
            carImageLabel.Text = "Car Image URL :";
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(187, 120);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(125, 27);
            makeTextBox.TabIndex = 11;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(187, 87);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(125, 27);
            modelTextBox.TabIndex = 12;
            // 
            // colorTextBox
            // 
            colorTextBox.Location = new Point(187, 153);
            colorTextBox.Name = "colorTextBox";
            colorTextBox.Size = new Size(125, 27);
            colorTextBox.TabIndex = 13;
            // 
            // horsePowerTextBox
            // 
            horsePowerTextBox.Location = new Point(187, 186);
            horsePowerTextBox.Name = "horsePowerTextBox";
            horsePowerTextBox.Size = new Size(125, 27);
            horsePowerTextBox.TabIndex = 14;
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.Location = new Point(187, 252);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.Size = new Size(125, 27);
            purchasePriceTextBox.TabIndex = 15;
            // 
            // typeTextBox
            // 
            typeTextBox.Location = new Point(187, 219);
            typeTextBox.Name = "typeTextBox";
            typeTextBox.Size = new Size(125, 27);
            typeTextBox.TabIndex = 16;
            // 
            // carImageTextBox
            // 
            carImageTextBox.Location = new Point(187, 318);
            carImageTextBox.Name = "carImageTextBox";
            carImageTextBox.Size = new Size(125, 27);
            carImageTextBox.TabIndex = 17;
            // 
            // sellingPriceTextBox
            // 
            sellingPriceTextBox.Location = new Point(187, 285);
            sellingPriceTextBox.Name = "sellingPriceTextBox";
            sellingPriceTextBox.Size = new Size(125, 27);
            sellingPriceTextBox.TabIndex = 18;
            // 
            // searchComboBox
            // 
            searchComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Location = new Point(187, 24);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(259, 28);
            searchComboBox.TabIndex = 19;
            // 
            // addButton
            // 
            addButton.Location = new Point(56, 402);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 20;
            addButton.Text = "Add Car";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // buyButton
            // 
            buyButton.Location = new Point(56, 450);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(94, 29);
            buyButton.TabIndex = 21;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // sellButton
            // 
            sellButton.Location = new Point(198, 450);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(94, 29);
            sellButton.TabIndex = 22;
            sellButton.Text = "Sell";
            sellButton.UseVisualStyleBackColor = true;
            sellButton.Click += sellButton_Click;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(187, 351);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(125, 27);
            amountTextBox.TabIndex = 24;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(56, 354);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(125, 20);
            amountLabel.TabIndex = 25;
            amountLabel.Text = "Amount in Stock :";
            // 
            // backButton
            // 
            backButton.Location = new Point(687, 453);
            backButton.Name = "backButton";
            backButton.Size = new Size(101, 26);
            backButton.TabIndex = 26;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(198, 402);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(94, 29);
            resetButton.TabIndex = 27;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
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