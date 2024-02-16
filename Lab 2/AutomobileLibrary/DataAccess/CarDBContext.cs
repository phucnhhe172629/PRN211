using AutomobileLibrary.BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext : BaseDAL
    {
        // Using Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Car> GetCarList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select CarID, CarName, Manufacturer, Price, ReleasedYear from Cars";
            var cars = new List<Car>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {   
                    var car = new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    };
                    cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return cars;
        }

        public Car GetCarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select CarID, CarName, Manufacturer, Price, ReleasedYear " +
                "from Cars where CarID = @CarID";
            try
            {
                var param = dataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    car = new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufacturer = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return car;
        }

        // Add new a car
        public void AddNew(Car car)
        {
            try
            {
                Car pro = GetCarByID(car.CarID);
                if (pro == null)
                {
                    string SQLInsert = "Insert Cars values(@CarID,@CarName,@Manufacturer,@Price,@ReleasedYear)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@ReleasedYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, out connection, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Update a car
        public void Update(Car car)
        {
            try
            {
                Car c = GetCarByID(car.CarID);
                if (c != null)
                {
                    string SQLUpdate = "Update Cars set CarName = @CarName, Manufacturer = @Manufacturer," +
                        " Price = @Price, ReleasedYear = @ReleasedYear where CarID = @CarID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Manufacturer", 50, car.Manufacturer, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@ReleasedYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, out connection, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Remove a car
        public void Remove(int CarID)
        {
            try
            {
                Car car = GetCarByID(CarID);
                if (car != null)
                {
                    string SQLUpdate = "Delete Cars where CarID = @CarID";
                    var param = dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32);
                    dataProvider.Delete(SQLUpdate, CommandType.Text, out connection, param);
                }
                else
                {
                    throw new Exception("the car does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
