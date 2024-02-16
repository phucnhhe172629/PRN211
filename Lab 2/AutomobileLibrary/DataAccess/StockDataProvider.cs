﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Data.SqlClient;

namespace AutomobileLibrary.DataAccess
{
    public class StockDataProvider
    {
        public StockDataProvider() { }

        private string ConnectionString { get; set; }

        public StockDataProvider(string connectionString) => ConnectionString = connectionString;

        public void CloseConnection(SqlConnection connection) => connection.Close();

        public SqlParameter CreateParameter(string name, int size, object value, DbType dbType,
            ParameterDirection direction = ParameterDirection.Input)
        {
            return new SqlParameter
            {
                DbType = dbType,
                ParameterName = name,
                Size = size,
                Value = value,
                Direction = direction
            };
        }

        public IDataReader GetDataReader(string commandText, CommandType commandType,
            out SqlConnection connection, params SqlParameter[] parameters)
        {
            IDataReader reader = null;
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                var command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return reader;
        }
        public void Delete(string commandText, CommandType commandType, out SqlConnection connection, params SqlParameter[] parameters)
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Data Provider: Delete method", ex.InnerException);
            }
        }
        public void Insert(string commandText, CommandType commandType, out SqlConnection connection, params SqlParameter[] parameters)
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Data Provider: Insert method", ex.InnerException);
            }
        }
        public void Update(string commandText, CommandType commandType, out SqlConnection connection, params SqlParameter[] parameters)
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(commandText, connection);
                command.CommandType = commandType;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                }
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Data Provider: Update method", ex.InnerException);
            }
        }
    }
}
