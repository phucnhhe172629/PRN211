using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class ProductDAO : DBContext
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> GetProductList()
        {
            string sql = "select * from Product";
            var productList = new List<Product>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                Product product = new Product
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    Weight = dr["Weight"].ToString(),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }
        public Product GetProductByID(int id)
        {
            string sql = "select * from Product where ProductId = @ProductId";
            DataRow dr = DBContext.GetDataBySQL(sql, new SqlParameter("@ProductId", id)).Rows[0];
            Product product = new Product
            {
                ProductId = int.Parse(dr["ProductId"].ToString()),
                ProductName = dr["ProductName"].ToString(),
                CategoryId = int.Parse(dr["CategoryId"].ToString()),
                Weight = dr["Weight"].ToString(),
                UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
            };
            return product;
        }
        public void AddNew(Product product)
        {
            string sql = "insert into Product(ProductName, CategoryId, Weight, UnitPrice, UnitsInStock) values(@ProductName, @CategoryId, @Weight, @UnitPrice, @UnitsInStock)";
            DBContext.ExcuteSql(sql, new SqlParameter("@ProductName", product.ProductName), 
                new SqlParameter("@CategoryId", product.CategoryId), 
                new SqlParameter("@Weight", product.Weight), 
                new SqlParameter("@UnitPrice", product.UnitPrice), 
                new SqlParameter("@UnitsInStock", product.UnitsInStock));
        }

        public void Update(Product product)
        {
            string sql = "update Product set ProductName = @ProductName, CategoryId = @CategoryId, Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock where ProductId = @ProductId";
            DBContext.ExcuteSql(sql, new SqlParameter("@ProductName", product.ProductName), 
                new SqlParameter("@CategoryId", product.CategoryId), 
                new SqlParameter("@Weight", product.Weight), 
                new SqlParameter("@UnitPrice", product.UnitPrice), 
                new SqlParameter("@UnitsInStock", product.UnitsInStock), 
                new SqlParameter("@ProductId", product.ProductId));
        }

        public void Remove(int Id)
        {
            string sql = "delete from Product where ProductId = @ProductId";
            DBContext.ExcuteSql(sql, new SqlParameter("@ProductId", Id));
        }

        public IEnumerable<Product> GetProductListById(string Id)
        {
            string sql = "select * from Product where ProductId like @ProductId";
            var productList = new List<Product>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@ProductId", Id)).Rows)
            {
                Product product = new Product
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    Weight = dr["Weight"].ToString(),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public IEnumerable<Product> GetProductListByName(string Name)
        {
            string sql = "select * from Product where ProductName like @ProductName";
            var productList = new List<Product>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@ProductName", Name)).Rows)
            {
                Product product = new Product
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    Weight = dr["Weight"].ToString(),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public IEnumerable<Product> GetProductListByUnitInStock(int Number)
        {
            string sql = "select * from Product where UnitsInStock < @Number";
            var productList = new List<Product>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@Number", Number)).Rows)
            {
                Product product = new Product
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    Weight = dr["Weight"].ToString(),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public IEnumerable<Product> GetProductListByUnitPrice(int Price)
        {
            string sql = "select * from Product where UnitPrice < @Price";
            var productList = new List<Product>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@Price", Price)).Rows)
            {
                Product product = new Product
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    Weight = dr["Weight"].ToString(),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public int GetProductIdByName(string ProductName)
        {
            string sql = "select ProductId from Product where ProductName = @ProductName";
            DataRow dr = DBContext.GetDataBySQL(sql, new SqlParameter("@ProductName", ProductName)).Rows[0];
            int ProductId = int.Parse(dr["ProductId"].ToString());
            return ProductId;
        }

        public void BuyProduct(string ProductName, int Quantity)
        {
            string sql = "update Product set UnitsInStock = UnitsInStock - @Quantity where ProductName = @ProductName";
            DBContext.ExcuteSql(sql, new SqlParameter("@ProductName", ProductName),
                 new SqlParameter("@Quantity", Quantity));
        }
    }
}
