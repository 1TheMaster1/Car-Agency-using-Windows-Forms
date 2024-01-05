using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class InventoryForm : Form
    {
        Employee employeeCurrent = new Employee();
        public InventoryForm(Employee employee)
        {
            InitializeComponent();
            employeeCurrent = employee;
            foreach (Inventory inventory in Inventory.inventoryList)
            {
                searchComboBox.Items.Add(inventory.Car.Model);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Inventory inventoryObject = new Inventory();
            foreach (Inventory inventory in Inventory.inventoryList)
            {
                if (searchComboBox.Text == inventory.Car.Model)
                {
                    inventoryObject = inventory;
                }
            }
            modelTextBox.Text = inventoryObject.Car.Model;
            makeTextBox.Text = inventoryObject.Car.Make;
            colorTextBox.Text = inventoryObject.Car.Color;
            horsePowerTextBox.Text = inventoryObject.Car.HoursePower.ToString();
            typeTextBox.Text = inventoryObject.Car.Type;
            purchasePriceTextBox.Text = inventoryObject.Car.PurchasePrice.ToString();
            sellingPriceTextBox.Text = inventoryObject.Car.SellingPrice.ToString();
            if (inventoryObject.Car.CarImage != null)
            {
                Bitmap image = new Bitmap(inventoryObject.Car.CarImage);
                carPictureBox.Image = (Image)image;
            }
            amountInStockLabel.Text = "Amount in stock : " + inventoryObject.Quantity;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                    if (textBox != null)
                    {
                        if (textBox.Text == string.Empty)
                        {
                            MessageBox.Show("There is an empty box");
                            return;
                        }
                    } 
                }
            }
            string model = modelTextBox.Text;
            string make = makeTextBox.Text;
            string color = colorTextBox.Text;
            int horsePower = Convert.ToInt32(horsePowerTextBox.Text);
            string type = typeTextBox.Text;
            int purchasePrice = Convert.ToInt32(purchasePriceTextBox.Text);
            int sellingPrice = Convert.ToInt32(sellingPriceTextBox.Text);
            Bitmap carImage = new Bitmap(carImageTextBox.Text);
            Car car = new Car(model, make, color, horsePower, type, purchasePrice, sellingPrice, carImage);
            int quantity = Convert.ToInt32(amountTextBox.Text);
            Inventory inventory = new Inventory(car, quantity);
            Inventory.inventoryList.Add(inventory);
            searchComboBox.Items.Clear();
            foreach (Inventory inventoryObject in Inventory.inventoryList)
            {
                searchComboBox.Items.Add(inventoryObject.Car.Model);
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            Inventory inventoryObject = new Inventory();
            foreach (Inventory inventory in Inventory.inventoryList)
            {
                if (searchComboBox.Text == inventory.Car.Model)
                {
                    inventoryObject = inventory;
                }
            }
            inventoryObject.Quantity += Convert.ToInt32(amountTextBox.Text);

        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            Inventory inventoryObject = new Inventory();
            foreach (Inventory inventory in Inventory.inventoryList)
            {
                if (searchComboBox.Text == inventory.Car.Model)
                {
                    inventoryObject = inventory;
                }
            }
            inventoryObject.Quantity -= Convert.ToInt32(amountTextBox.Text);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox? textBox = c as System.Windows.Forms.TextBox;
                    if (textBox != null)
                        if (textBox.Text != string.Empty)
                        {
                            textBox.Text = string.Empty;
                        }
                }
            }
            carPictureBox.Image = null;
        }
    }
}
