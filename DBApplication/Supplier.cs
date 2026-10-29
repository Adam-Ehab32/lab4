using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Supplier : Form
    {
        Controller controllerObj;

        public Supplier()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Supplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerObj.TerminateConnection();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            // should validate user input first !!!
            int status;
            if (!int.TryParse(statusTextBox.Text, out status))
            {
                MessageBox.Show("Status must be a number");
                return;
            }

            int result = controllerObj.InsertSupplier(sNumTextBox.Text,
                sNameTextBox.Text, cityTextBox.Text, status);

            if (result == 0)
            {
                MessageBox.Show("The insertion of a new supplier failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // should validate user input first !!!
            int result = controllerObj.DeleteSupplier(sNumDelTextBox.Text);

            if (result == 0)
            {
                MessageBox.Show("No rows were deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // should validate user input first !!!
            int result = controllerObj.UpdateSupplier(sNumUpdateTextBox.Text,
                cityUpdateTextBox.Text);

            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            countTextBox.Text = controllerObj.CountSuppliers().ToString();
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllSuppliers();
            suppliersDataGrid.DataSource = dt;
            suppliersDataGrid.Refresh();
        }
    }
}
