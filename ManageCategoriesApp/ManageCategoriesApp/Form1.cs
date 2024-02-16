using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCategoriesApp
{
    public partial class frmManageCategories : Form
    {
        ManageCategories manageCategories = new ManageCategories();
        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {
            var categories = manageCategories.GetCategories();// lay gia tri tu class
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            // them du lieu vao
            txtCategoryID.DataBindings.Add("Text", categories, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", categories, "CategoryName");
            // them du lieu vao datagridview
            dgvData.DataSource = categories;
        }
        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    // CategoryID = int.Parse(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text,
                };
                manageCategories.InsertCategory(category);
                LoadCategories();// cap nhat lại dgv

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert category");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryID = int.Parse(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text,
                };
                manageCategories.UpdateCategory(category);
                LoadCategories();// cap nhat lai
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update category");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var category = new Category
                {
                    CategoryID = int.Parse(txtCategoryID.Text),
                    // CategoryName = txtCategoryName.Text,
                };
                manageCategories.DeleteCategory(category);
                LoadCategories();// cap nhat lai
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update category");
            }
        }
    }
}
