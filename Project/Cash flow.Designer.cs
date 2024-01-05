namespace Project
{
    partial class Cash_flow
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button8 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 27);
            textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(36, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 185);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expenses";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Location = new Point(431, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 185);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Incomes";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(117, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 94);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(117, 27);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(155, 49);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(117, 27);
            textBox6.TabIndex = 3;
            // 
            // button8
            // 
            button8.Location = new Point(285, 299);
            button8.Name = "button8";
            button8.Size = new Size(196, 51);
            button8.TabIndex = 8;
            button8.Text = "Add data";
            button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 52);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 6;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 97);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 7;
            label2.Text = "Expense";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 143);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 143);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 11;
            label4.Text = "Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 97);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 10;
            label5.Text = "Income";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 52);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 9;
            label6.Text = "Date";
            // 
            // Cash_flow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Cash_flow";
            Text = "Cash_flow";
            Load += Cash_flow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}