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
    public partial class ServiceForm : Form
    {
        Employee employeeCurrent = new Employee();
        public ServiceForm(Employee employee)
        {
            InitializeComponent();
            employeeCurrent = employee;
        }
    }
}
