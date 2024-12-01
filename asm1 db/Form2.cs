using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm1_db
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee employeeManagementToolStripMenuItem =  new Employee();
            employeeManagementToolStripMenuItem.ShowDialog();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Management productManagementToolStripMenuItem = new Product_Management();
            productManagementToolStripMenuItem.ShowDialog();
        }

        private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customerManagementToolStripMenuItem = new Customer();
            customerManagementToolStripMenuItem.ShowDialog();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics statisticsToolStripMenuItem = new Statistics();
            statisticsToolStripMenuItem.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order orderToolStripMenuItem = new Order();
            orderToolStripMenuItem.ShowDialog();
        }
    }
}
