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
    public partial class frmProduct : Form
    {
        public bool InsertOrUpdate { get; set; } //true: insert, false: update
        public IProductRepository productRepository = new ProductRepository();
        public ProductObject ProductObject { get; set; }
        public frmProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                tbID.Enabled = false;
                var product = new ProductObject()
                {
                    ProductId = int.Parse(tbID.Text),
                    ProductName = tbName.Text,
                    CategoryId = int.Parse(cbCategory.SelectedItem.ToString()),
                    QuantityPerUnit = int.Parse(tbWeight.Text),
                    UnitPrice = decimal.Parse(tbUnitPrice.Text),
                    UnitsInStock = int.Parse(tbUnitInStock.Text)
                };
                
                productRepository.AddProduct(product);
                MessageBox.Show("Add product successfully");
                Close();
            }
            else if (InsertOrUpdate == false)
            {
                tbID.Enabled = false;

                ProductObject.ProductId = int.Parse(tbID.Text);
                ProductObject.ProductName = tbName.Text;
                ProductObject.CategoryId = int.Parse(cbCategory.SelectedItem.ToString());
                ProductObject.QuantityPerUnit = int.Parse(tbWeight.Text);
                ProductObject.UnitPrice = decimal.Parse(tbUnitPrice.Text);
                ProductObject.UnitsInStock = int.Parse(tbUnitInStock.Text);

                productRepository.UpdateProduct(ProductObject);

                MessageBox.Show("Update product successfully");
                Close();
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            try
            {
                if (!InsertOrUpdate)
                {
                    tbID.Text = ProductObject.ProductId.ToString();
                    tbName.Text = ProductObject.ProductName;
                    cbCategory.Text = ProductObject.CategoryId.ToString();
                    tbWeight.Text = ProductObject.QuantityPerUnit.ToString();
                    tbUnitPrice.Text = ProductObject.UnitPrice.ToString();
                    tbUnitInStock.Text = ProductObject.UnitsInStock.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
