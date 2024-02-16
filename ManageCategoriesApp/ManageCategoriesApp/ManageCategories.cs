using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCategoriesApp
{
    internal class ManageCategories
    {
        SqlConnection _connection;
        SqlCommand _command;
        string ConnectionString = "Server=PHUSCPC;uid=phusc;pwd=123;database=MyStore";
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            _connection = new SqlConnection(ConnectionString);
            string SQL = "Select CategoryID, CategoryName from Categories";
            _command = new SqlCommand(SQL, _connection);// ket noi va thuc thi lenh
            try
            {
                _connection.Open();// mo ket noi
                SqlDataReader reader = _command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryID = reader.GetInt32(reader.GetOrdinal("CategoryID")),
                            CategoryName = reader.GetString(reader.GetOrdinal("CategoryName"))
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally { _connection.Close(); }
            return categories;
        }

        public void InsertCategory(Category category)
        {
            _connection = new SqlConnection(ConnectionString);
            string SQL = "Insert categories values(@CategoryName)";
            _command = new SqlCommand(SQL, _connection);
            _command.Parameters.AddWithValue("CategoryName", category.CategoryName);// slide thieu cau nay
            try
            {
                _connection.Open();// mơ truy van
                _command.ExecuteNonQuery();// chay cau lenh insert
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void UpdateCategory(Category category)
        {
            _connection = new SqlConnection(ConnectionString);
            string SQL = "Update categories set CategoryName=@CategoryName where CategoryID=@CategoryID";
            _command = new SqlCommand(SQL, _connection);
            _command.Parameters.AddWithValue("categoryID", category.CategoryID);// truyen tham so vao truy van
            _command.Parameters.AddWithValue("CategoryName", category.CategoryName);
            try
            {
                _connection.Open();
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        public void DeleteCategory(Category category)
        {
            _connection = new SqlConnection(ConnectionString);
            string SQL = "Delete categories where CategoryID=@CategoryID";
            _command = new SqlCommand(SQL, _connection);
            _command.Parameters.AddWithValue("categoryID", category.CategoryID);// truyen tham so vao truy van
            try
            {
                _connection.Open();
                _command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}