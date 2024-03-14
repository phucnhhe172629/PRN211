using BusinessObject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class ProductDAO : EStoreContext
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
            var products = new List<Product>();
            try
            {
                using var context = new EStoreContext();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }
        public Product GetProductByID(int id)
        {
            Product product = null;
            try
            {
                using var context = new EStoreContext();
                product = context.Products.SingleOrDefault(m => m.ProductId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        public void AddNew(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product == null)
                {
                    using var context = new EStoreContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product != null)
                {
                    using var context = new EStoreContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int id)
        {
            try
            {
                Product product = GetProductByID(id);
                if (product != null)
                {
                    using var context = new EStoreContext();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Product does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Product> GetProductListById(string Id)
        {
            var products = new List<Product>();
            try
            {
                using var context = new EStoreContext();
                products = context.Products.ToList().FindAll(p => p.ProductId.ToString().Contains(Id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public IEnumerable<Product> GetProductListByName(string Name)
        {
            var products = new List<Product>();
            try
            {
                using var context = new EStoreContext();
                products = context.Products.ToList().FindAll(p => p.ProductName.ToLower().Contains(Name.ToLower()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public IEnumerable<Product> GetProductListByUnitInStock(int Number)
        {
            var products = new List<Product>();
            try
            {
                using var context = new EStoreContext();
                products = context.Products.ToList().FindAll(p => p.UnitsInStock <= Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public IEnumerable<Product> GetProductListByUnitPrice(int Price)
        {
            var products = new List<Product>();
            try
            {
                using var context = new EStoreContext();
                products = context.Products.ToList().FindAll(p => p.UnitPrice <= Price);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public int GetProductIdByName(string Name)
        {
            int productId = new int();
            try
            {
                using var context = new EStoreContext();
                productId = context.Products.FirstOrDefault(p => p.ProductName.Equals(Name)).ProductId;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return productId;
        }

        public void BuyProduct(string Name, int Quantity)
        {
            try
            {
                using var context = new EStoreContext();
                context.Products.FirstOrDefault(p => p.ProductName.Equals(Name)).UnitsInStock -= Quantity;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
