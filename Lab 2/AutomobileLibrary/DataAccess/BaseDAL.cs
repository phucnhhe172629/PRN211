using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AutomobileLibrary.DataAccess

{
    public class BaseDAL
    {
        public StockDataProvider dataProvider { get; set; } = null;
        public SqlConnection connection = null;
        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            dataProvider = new StockDataProvider(connectionString);
        }

        private string GetConnectionString()
        {
            string connnectionString;
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            connnectionString = config["ConnectionString:MyStockDB"];
            return connnectionString;
        }
        public void CloseConnection() => dataProvider.CloseConnection(connection);
    }
}
