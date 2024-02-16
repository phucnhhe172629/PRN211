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

namespace DemoConnectedLayer
{
    public partial class frmViewProducts : Form
    {
        public frmViewProducts()
        {
            InitializeComponent();
        }

        private void frmViewProducts_Load(object sender, EventArgs e)
        {
            //Create a list to store
            List<dynamic> products = new List<dynamic>();
            String ConnectionString = "server=PHUSCPC;database=MyStock;uid=phusc;pwd=123";
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand("select * from Cars", conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows == true )
            {
                while ( reader.Read())
                {
                    products.Add(new
                    {
                        CarID = reader.GetInt32(reader.GetOrdinal("CarID")),
                        CarName = reader.GetString(reader.GetOrdinal("CarName")),
                        Manufacture = reader.GetString(reader.GetOrdinal("CarName")),
                        Price = reader.GetDecimal(reader.GetOrdinal("Price")),
                        ReleasedYear = reader.GetInt32(reader.GetOrdinal("ReleasedYear"))
                    });
                }
                dgvData.DataSource = products;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
