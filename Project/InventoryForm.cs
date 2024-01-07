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

using System.Data.SqlClient;




namespace Project
{
    public partial class InventoryForm : Form
    {
        Employee employeeCurrent = new Employee();
        Inventory inventoryObject = new Inventory();
        bool check = true;
        public static MainMenu prevForm = new MainMenu();

        public InventoryForm() { }
        public InventoryForm(Employee employee, MainMenu mainMenu)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            employeeCurrent = employee;
            prevForm = mainMenu;    

            foreach (Inventory inventory in Inventory.inventoryList)
            {
                searchComboBox.Items.Add(inventory.Car.Model);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
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
            amountTextBox.Text = inventoryObject.Quantity.ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=KOSHOK;Initial Catalog=""Car agency"";Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();

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
            BuyCarForm buyCarForm = new BuyCarForm(employeeCurrent, inventoryObject, this);
            this.Hide();
            buyCarForm.ShowDialog();
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            SellCarForm sellCarForm = new SellCarForm(employeeCurrent, inventoryObject, this);
            this.Hide();
            sellCarForm.ShowDialog();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            check = false;
            this.Hide();
            prevForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && check)
            {
                if (MessageBox.Show("Close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                e.Cancel = true;
            }
            check = true;
        }
    }
}
