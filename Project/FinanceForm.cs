using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FinanceForm : Form
    {
        Employee employeeCurrent = new Employee();
        public FinanceForm(Employee employee)
        {
            InitializeComponent();
            employeeCurrent = employee;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
