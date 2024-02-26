using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class ProductDAO : FStoreContext
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
            using FStoreContext context = new FStoreContext();
            return context.Products.ToList();
        }
        public Product GetProductByID(int id)
        {
            using FStoreContext context = new FStoreContext();
            return context.Products.SingleOrDefault(m => m.ProductId == id);
        } 
        public void AddNew(Product product)
        {
            using FStoreContext context = new FStoreContext();
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            using FStoreContext context = new FStoreContext();
            Products.Update(product);
            SaveChanges();
        }

        public void Remove(int id)
        {
            using FStoreContext context = new FStoreContext();
            Products.Remove(GetProductByID(id));
            SaveChanges();
        }

        public IEnumerable<Product> GetProductListById(string Id)
        {

            using FStoreContext context = new FStoreContext();
            return context.Products.ToList().FindAll(p => p.ProductId.ToString().Contains(Id));
        }

        public IEnumerable<Product> GetProductListByName(string Name)
        {
            using FStoreContext context = new FStoreContext();
            return context.Products.ToList().FindAll(p => p.ProductName.ToLower().Contains(Name.ToLower()));
        }

        public IEnumerable<Product> GetProductListByUnitInStock(int Number)
        {
            using FStoreContext context = new FStoreContext();
            return context.Products.ToList().FindAll(p => p.UnitsInStock <= Number);
        }

        public IEnumerable<Product> GetProductListByUnitPrice(int Price)
        {
            using FStoreContext context = new FStoreContext();
            return context.Products.ToList().FindAll(p => p.UnitPrice <= Price);
        }

        public int GetProductIdByName(string Name)
        {
            using FStoreContext context = new FStoreContext();
            return context.Products.FirstOrDefault(p => p.ProductName.Equals(Name)).ProductId;
        }

        public void BuyProduct(string Name, int Quantity)
        {
            using FStoreContext context = new FStoreContext();
            context.Products.FirstOrDefault(p => p.ProductName.Equals(Name)).UnitsInStock -= Quantity;
            SaveChanges();
        }
    }
}
