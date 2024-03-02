using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        List<ProductObject> GetProductObject();
        ProductObject GetProductById(int productId);
        void AddProduct(ProductObject product);
        void UpdateProduct(ProductObject product);
        void DeleteProduct(int productId);
        List<ProductObject> SearchByID(int productId);
        List<ProductObject> SearchByName(string productName);
        List<ProductObject> SearchByUnitPrice(int from, int to);
        List<ProductObject> SearchByUnitsInStock(int from, int to);
    }
}
