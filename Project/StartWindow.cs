using System.Data.SqlClient;

namespace Project
{
    public partial class StartWindow : Form
    {        
        public StartWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            if(passwordTextBox.TextLength > 14 )
            {
                passwordTextBox.Text = null;
                MessageBox.Show("Password exceeding max length (14 characters)");
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {


            foreach (Employee employee in Employee.employeeList.ToList())
            {
                if (NameTextBox.Text == employee.Name && passwordTextBox.Text == employee.Password)
                {
                    MainMenu mainMenu = new MainMenu(employee, this);
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }
        }
    }
}