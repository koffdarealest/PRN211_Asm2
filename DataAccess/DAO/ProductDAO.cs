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
    public class ProductDAO
    {
        private static ProductDAO instance;
        private static readonly object instanceLock = new object();
        public ProductDAO() { }

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

        public List<ProductObject> GetProductObject()
        {
            string sql = "select * from Product";
            var productList = new List<ProductObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                ProductObject product = new ProductObject
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    QuantityPerUnit = int.Parse(dr["QuantityPerUnit"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public ProductObject GetProductById(int productId)
        {
            string sql = "select * from Product where ProductId = @ProductId";
            DataRow dr = DBContext.GetDataBySQL(sql, new SqlParameter("@ProductId", productId)).Rows[0];
            ProductObject product = new ProductObject
            {
                ProductId = int.Parse(dr["ProductId"].ToString()),
                ProductName = dr["ProductName"].ToString(),
                CategoryId = int.Parse(dr["CategoryId"].ToString()),
                QuantityPerUnit = int.Parse(dr["QuantityPerUnit"].ToString()),
                UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
            };
            return product;
        }

        public void AddProduct(ProductObject product)
        {
            string sql = "insert into Product(ProductName, CategoryId, QuantityPerUnit, UnitPrice, UnitsInStock) values(@ProductName, @CategoryId, @QuantityPerUnit, @UnitPrice, @UnitsInStock)";
            DBContext.ExcuteSql(sql, new SqlParameter("@ProductName", product.ProductName), new SqlParameter("@CategoryId", product.CategoryId), new SqlParameter("@QuantityPerUnit", product.QuantityPerUnit), new SqlParameter("@UnitPrice", product.UnitPrice), new SqlParameter("@UnitsInStock", product.UnitsInStock));
        }
        public void UpdateProduct(ProductObject product)
        {
            string sql = "update Product set ProductName = @ProductName, CategoryId = @CategoryId, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock where ProductId = @ProductId";
            DBContext.ExcuteSql(sql, new SqlParameter("@ProductName", product.ProductName), new SqlParameter("@CategoryId", product.CategoryId), new SqlParameter("@QuantityPerUnit", product.QuantityPerUnit), new SqlParameter("@UnitPrice", product.UnitPrice), new SqlParameter("@UnitsInStock", product.UnitsInStock), new SqlParameter("@ProductId", product.ProductId));
        }
        public void DeleteProduct(int productId)
        {
            string sql = "delete from Product where ProductId = @ProductId";
            DBContext.ExcuteSql(sql, new SqlParameter("@ProductId", productId));
        }

        public List<ProductObject> SeachByID(int Id)
        {
            string sql = "select * from Product where ProductId = @ProductId";
            var productList = new List<ProductObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@ProductId", Id)).Rows)
            {
                ProductObject product = new ProductObject
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    QuantityPerUnit = int.Parse(dr["QuantityPerUnit"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public List<ProductObject> SeachByName(string Name)
        {
            string sql = "select * from Product where ProductName = @ProductName";
            var productList = new List<ProductObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@ProductName", Name)).Rows)
            {
                ProductObject product = new ProductObject
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    QuantityPerUnit = int.Parse(dr["QuantityPerUnit"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public List<ProductObject> FilterUnitPrice(int From, int To)
        {
            string sql = "select * from Product where UnitPrice between @from and @to";
            var productList = new List<ProductObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@from", From), new SqlParameter("@to", To)).Rows)
            {
                ProductObject product = new ProductObject
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    QuantityPerUnit = int.Parse(dr["QuantityPerUnit"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }

        public List<ProductObject> FilterUnitsInStock(int From, int To)
        {
            string sql = "select * from Product where UnitsInStock between @from and @to";
            var productList = new List<ProductObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@from", From), new SqlParameter("@to", To)).Rows)
            {
                ProductObject product = new ProductObject
                {
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    ProductName = dr["ProductName"].ToString(),
                    CategoryId = int.Parse(dr["CategoryId"].ToString()),
                    QuantityPerUnit = int.Parse(dr["QuantityPerUnit"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    UnitsInStock = int.Parse(dr["UnitsInStock"].ToString())
                };
                productList.Add(product);
            }
            return productList;
        }
    }
}
