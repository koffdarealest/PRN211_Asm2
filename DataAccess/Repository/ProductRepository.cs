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
        public void AddProduct(ProductObject product)
        {
            ProductDAO.Instance.AddProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            ProductDAO.Instance.DeleteProduct(productId);
        }

        public ProductObject GetProductById(int productId)
        {
            return ProductDAO.Instance.GetProductById(productId);
        }

        public List<ProductObject> GetProductObject()
        {
            return ProductDAO.Instance.GetProductObject();
        }

        public List<ProductObject> SearchByID(int productId)
        {
            return ProductDAO.Instance.SeachByID(productId);
        }

        public List<ProductObject> SearchByName(string productName)
        {
            return ProductDAO.Instance.SeachByName(productName);
        }

        public List<ProductObject> SearchByUnitPrice(int from, int to)
        {
            return ProductDAO.Instance.FilterUnitPrice(from, to);
        }

        public List<ProductObject> SearchByUnitsInStock(int from, int to)
        {
            return ProductDAO.Instance.FilterUnitsInStock(from, to);
        }

        public void UpdateProduct(ProductObject product)
        {
            ProductDAO.Instance.UpdateProduct(product);
        }
    }
}
