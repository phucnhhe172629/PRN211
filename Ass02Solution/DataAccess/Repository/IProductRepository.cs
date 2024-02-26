using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int Id);
        void InsertProduct(Product Product);
        void DeleteProduct(int Id);
        void UpdateProduct(Product Product);
        IEnumerable<Product> GetProductListByName(string Name);
        IEnumerable<Product> GetProductListById(string Id);
        IEnumerable<Product> GetProductListByUnitPrice(int Price);
        IEnumerable<Product> GetProductListByUnitInStock(int Number);
        public int GetProductIdByName(string Name);
    }
}
