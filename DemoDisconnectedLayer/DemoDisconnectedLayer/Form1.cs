using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDisconnectedLayer
{
    public partial class frmMyStore : Form
    {
        public frmMyStore()
        {
            InitializeComponent();
        }
        // tao dataset luu ket qua tra ve tu truy van
        DataSet dsMyStore = new DataSet();
        private void frmMyStore_Load(object sender, EventArgs e)
        {
            string ConnectionString = "Server=PHUSCPC;uid=phusc;pwd=123;database=MyStore";
            string SQL = "Select ProductID, productName, UnitInStock From products; Select * from categories";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, ConnectionString);// ket noi csdl va thuc thi cau lenh
                dataAdapter.Fill(dsMyStore);// lay ket qua truy van cho vao trong dataset
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Data from database");
            }
            finally
            {
                // dong ket noi
            }
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[0];// lay ket qua truy van 1  
        }

        private void btnViewCatergories_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[1];// lay kq truy van 2
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
