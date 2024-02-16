using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Procedures_Demonstration
{
    internal class Program
    {
        static (int OutputValue, int ReturnValue) CountProductsByCategoryID(int CategoryID)
        {

            //Dec1are a Tuple
            (int OutputValue, int ReturnValue) result;
            string ConnectionString = "Server=PHUSCPC;uid=phusc;pwd=123;database=MyStore";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            CountProductsUsingOutputValue();
            CountProductsUsingReturnValue();
            //DecIare Local Functions
            void CountProductsUsingOutputValue()
            {
                command.CommandText = "spCountProductsUsingOutputValue";
                command.Parameters.AddWithValue("@CategoryID", CategoryID);
                //Using Output value
                command.Parameters.Add("@NumberOfProducts", SqlDbType.Int).
                    Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                result.OutputValue = (int)command.Parameters["@NumberOfProducts"].Value;
            } // end function
            void CountProductsUsingReturnValue()
            {
                command.CommandText = "spCountProductsUsingReturnValue";
                //Using Return value
                command.Parameters["@NumberOfProducts"].Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                result.ReturnValue = (int)command.Parameters["@NumberOfProducts"].Value;
                //end function
            }
            connection.Close();
            return result;
        }
        static void Main(string[] args)
        {
            int CategoryID = 1;
            var result = CountProductsByCategoryID(CategoryID);
            Console.WriteLine($"Number of products by CategoryID:{CategoryID}");
            Console.WriteLine($"-->OutputValue: {result.OutputValue}, ReturnValue: {result.ReturnValue}");
            CategoryID = 3;
            result = CountProductsByCategoryID(CategoryID);
            Console.WriteLine($"Number of products by CategoryID:{CategoryID}");
            Console.WriteLine($"-->OutputValue: {result.OutputValue}, ReturnValue: {result.ReturnValue}");
        }
    }
}
