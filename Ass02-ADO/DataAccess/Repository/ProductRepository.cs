using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int Id) => ProductDAO.Instance.Remove(Id);

        public Product GetProductByID(int Id) => ProductDAO.Instance.GetProductByID(Id);

        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();

        public void InsertProduct(Product Product) => ProductDAO.Instance.AddNew(Product);

        public void UpdateProduct(Product Product) => ProductDAO.Instance.Update(Product);


        public IEnumerable<Product> GetProductListById(string Id) => ProductDAO.Instance.GetProductListById(Id);

        public IEnumerable<Product> GetProductListByName(string Name) => ProductDAO.Instance.GetProductListByName(Name);

        public IEnumerable<Product> GetProductListByUnitInStock(int Number) => ProductDAO.Instance.GetProductListByUnitInStock(Number);

        public IEnumerable<Product> GetProductListByUnitPrice(int Price) => ProductDAO.Instance.GetProductListByUnitPrice(Price);

        public int GetProductIdByName(string Name) => ProductDAO.Instance.GetProductIdByName(Name);

        public void BuyProduct(string Name, int Quantity) => ProductDAO.Instance.BuyProduct(Name, Quantity);
    }
}
