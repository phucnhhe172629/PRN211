using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class frmEmployeeDetails : Form
    {
        public frmEmployeeDetails()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            cmbEmployee.Items.Add("Cap 1");
            cmbEmployee.Items.Add("Cap 2");
            cmbEmployee.Items.Add("Cap 3");
        }

        private void txtEmpPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // phai nhap du lieu vao
        private string Validate()
        {
            String result = "";
            String empId = txtEmpId.Text;
            String empName = txtEmpName.Text;
            String empPhone = txtEmpPhone.Text;
            String empDegree = cmbEmployee.Text;
            String empGender = (radFemale.Checked ? radFemale.Text : radMale.Text);
            // kiem tra
            if (empId.Length == 0)
            {
                MessageBox.Show("Bat buoc nhap ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // dat con tro tai noi thieu du lieu
                txtEmpId.Focus();
                return result;
            }
            if (empName.Length == 0)
            {
                MessageBox.Show("Bat buoc nhap Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // dat con tro tai noi thieu du lieu
                txtEmpName.Focus();
                return result;
            }
            if (empPhone.Length == 0)
            {
                MessageBox.Show("Bat buoc nhap Phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // dat con tro tai noi thieu du lieu
                txtEmpPhone.Focus();
                return result;
            }
            result = "ID: " + empId
                + "\nName: " + empName
                + "\nPhone: " + empPhone
                + "\nGender: " + empGender
                + "\nDegree: " + empDegree;
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String str = Validate();
            MessageBox.Show(str, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Item frmItem = new Item();
            //goi hien thi
            frmItem.Show();
            //an form hien tai
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String str = Validate();
            MessageBox.Show(str, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String str = Validate();
            MessageBox.Show(str, "Info Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
