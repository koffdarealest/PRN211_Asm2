using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductOrder : Form
    {
        public IOrderDetailRepository OrderDetailRepository  = new OrderDetailRepository();
        public IProductRepository productRepository = new ProductRepository();
        public IOrderRepository OrderRepository = new OrderRepository();
        public ProductObject ProductObject { get; set; }
        public MemberObject memberObject { get; set; }
        public frmProductOrder()
        {
            InitializeComponent();
        }

        private void frmProductOrder_Load(object sender, EventArgs e)
        {
            tbID.Enabled = false;
            tbCategory.Enabled = false;
            tbUnitPrice.Enabled = false;
            tbWeight.Enabled = false;
            tbName.Enabled = false;

           LoadProduct();
        }

        private void LoadProduct()
        {
            tbID.Text = ProductObject.ProductId.ToString();
            tbName.Text = ProductObject.ProductName;
            tbCategory.Text = ProductObject.CategoryId.ToString();
            tbUnitPrice.Text = ProductObject.UnitPrice.ToString();
            tbWeight.Text = ProductObject.QuantityPerUnit.ToString();
            tbQuantity.Text = "0";
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbQuantity.Text) <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0");
                return;
            }

            OrderObject orderObject = new OrderObject
            {
                MemberId = memberObject.MemberId,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                Freight = 0
            };
            OrderRepository.Insert(orderObject);
            
            int orderId = 0;
            //code to get the orderId last inserted
            List<OrderObject> orders = OrderRepository.GetOrders();
            if (orders.Count > 0)
            {
                orderId = orders[orders.Count - 1].OrderId;
            }
            else
            {
                orderId = 0;
            }

            if (orderId == 0)
            {
                MessageBox.Show("Failed to add order");
                return;
            }
            OrderDetailObject orderDetailObject = new OrderDetailObject
            {
                OrderId = orderId, // Use the retrieved OrderId here
                ProductId = ProductObject.ProductId,
                UnitPrice = ProductObject.UnitPrice,
                Quantity = int.Parse(tbQuantity.Text),
                Discount = 0
            };

            OrderDetailRepository.Insert(orderDetailObject);
            //change quantity of product in stock
            ProductObject.QuantityPerUnit = ProductObject.QuantityPerUnit - int.Parse(tbQuantity.Text);
            if (ProductObject.QuantityPerUnit < int.Parse(tbQuantity.Text))
            {
                MessageBox.Show("Quantity of product in stock is not enough");
                return;
            }
            productRepository.UpdateProduct(ProductObject);
            MessageBox.Show("Add product to order successfully");
            LoadProduct();

            this.Close();
        }

    }
}
