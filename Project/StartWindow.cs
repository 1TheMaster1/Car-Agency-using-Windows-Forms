using System.Data.SqlClient;
using System.Media;

namespace Project
{
    public partial class StartWindow : Form
    {        
        private SoundPlayer _player;
        
        public StartWindow()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _player = new SoundPlayer("C:\\Users\\Koshok\\source\\repos\\1TheMaster1\\Car-Agency-New\\Project\\bin\\Debug\\Charlie.wav");
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
                    _player.Play();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }
        }
    }
}