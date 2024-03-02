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
    public partial class frmProductManagement : Form
    {
        public IProductRepository productRepository = new ProductRepository();
        private List<ProductObject> productsList;
        private List<ProductObject> productsListSearch;
        BindingSource bindingSource;

        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
            LoadProductList();
            dgvProduct.CellDoubleClick += DgvProduct_CellDoubleClick;
        }

        private void LoadProductList()
        {
            try
            {
                var productList = productRepository.GetProductObject();

                if (productList != null && productList.Count > 0)
                {
                    this.productsList = productList;

                    bindingSource = new BindingSource();
                    bindingSource.DataSource = productsList;

                    tbID.DataBindings.Clear();
                    tbName.DataBindings.Clear();
                    tbCategory.DataBindings.Clear();
                    tbUnitsInStock.DataBindings.Clear();
                    tbQuanPerUnit.DataBindings.Clear();
                    tbUnitPrice.DataBindings.Clear();

                    tbID.DataBindings.Add("Text", bindingSource, "ProductId");
                    tbName.DataBindings.Add("Text", bindingSource, "ProductName");
                    tbCategory.DataBindings.Add("Text", bindingSource, "CategoryId");
                    tbUnitsInStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");
                    tbQuanPerUnit.DataBindings.Add("Text", bindingSource, "QuantityPerUnit");
                    tbUnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");

                    dgvProduct.DataSource = null;
                    dgvProduct.DataSource = bindingSource;

                    btNew.Enabled = true;
                    btFilter.Enabled = true;
                    btDelete.Enabled = true;
                }
                else
                {
                    // If productList is null or empty
                    ClearText();
                    btDelete.Enabled = false;
                    btFilter.Enabled = false;
                    btNew.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error when load list");
            }
        }


        private void ClearText()
        {
            tbCategory.Text = "";
            tbID.Text = "";
            tbName.Text = "";
            tbUnitPrice.Text = "";
            tbUnitsInStock.Text = "";
            tbQuanPerUnit.Text = "";
        }

        private void DgvProduct_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmProduct frmProduct = new frmProduct()
            {
                Text = "Update Product",
                productRepository = productRepository,
                InsertOrUpdate = false,
                ProductObject = productsList[e.RowIndex]
            };
            if (frmProduct.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct()
            {
                Text = "Add Product",
                productRepository = productRepository,
                InsertOrUpdate = true
            };
            if (frmProduct.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                productRepository.DeleteProduct(product.ProductId);
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error when delete product");
            }
        }

        private ProductObject GetProductObject()
        {
            ProductObject product = null;
            try
            {
                product = new ProductObject
                {
                    CategoryId = int.Parse(tbCategory.Text),
                    ProductId = int.Parse(tbID.Text),
                    ProductName = tbName.Text,
                    QuantityPerUnit = int.Parse(tbQuanPerUnit.Text),
                    UnitPrice = decimal.Parse(tbUnitPrice.Text),
                    UnitsInStock = int.Parse(tbUnitsInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error when get product object");
            }
            return product;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textSearch = tbSearch.Text;
                if (cbSearch.SelectedIndex == 0)
                {
                    if (string.IsNullOrWhiteSpace(textSearch))
                    {
                        productsListSearch = productRepository.GetProductObject();
                        LoadProductListSearch(productsListSearch);
                    }
                    else
                    {
                        productsListSearch = productRepository.SearchByID(int.Parse(textSearch));
                        LoadProductListSearch(productsListSearch);
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textSearch))
                    {
                        productsListSearch = productRepository.GetProductObject();
                        LoadProductListSearch(productsListSearch);
                    }
                    else
                    {
                        productsListSearch = productRepository.SearchByName(textSearch);
                        LoadProductListSearch(productsListSearch);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error when search product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductListSearch(List<ProductObject> productsListSearch)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = productsListSearch;

            tbID.DataBindings.Clear();
            tbName.DataBindings.Clear();
            tbCategory.DataBindings.Clear();
            tbUnitsInStock.DataBindings.Clear();
            tbQuanPerUnit.DataBindings.Clear();
            tbUnitPrice.DataBindings.Clear();

            tbID.DataBindings.Add("Text", bindingSource, "ProductId");
            tbName.DataBindings.Add("Text", bindingSource, "ProductName");
            tbCategory.DataBindings.Add("Text", bindingSource, "CategoryId");
            tbUnitsInStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");
            tbQuanPerUnit.DataBindings.Add("Text", bindingSource, "QuantityPerUnit");
            tbUnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = bindingSource;

            if (productsListSearch != null && productsListSearch.Count > 0)
            {
                btNew.Enabled = true;
                btFilter.Enabled = true;
                btDelete.Enabled = true;
            }
            else
            {
                // If productList is null or empty
                ClearText();
                btDelete.Enabled = false;
                btFilter.Enabled = false;
                btNew.Enabled = false;
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            int from = int.Parse(tbFrom.Text);
            int to = int.Parse(tbTo.Text);

            if (rbUnitPrice.Checked)
            {
                productsListSearch = productRepository.SearchByUnitPrice(from, to);
                LoadProductListSearch(productsListSearch);
            }
            else if (rbUnitsInStock.Checked)
            {
                productsListSearch = productRepository.SearchByUnitsInStock(from, to);
                LoadProductListSearch(productsListSearch);
            }

        }

        private void btSort_Click(object sender, EventArgs e)
        {
            List<ProductObject> listProductSort = null;
            if (productsListSearch == null)
            {
                listProductSort = productRepository.GetProductObject();
            }
            else
            {
                listProductSort = productsListSearch;
            }

            if (btSort.Text.Trim().Equals("DESC"))
            {
                LoadProductListSearch(listProductSort.OrderByDescending(x => x.ProductId).ToList());
                btSort.Text = "ASC";
            }
            else if (btSort.Text.Trim().Equals("ASC"))
            {
                LoadProductListSearch(listProductSort.OrderBy(x => x.ProductId).ToList());
                btSort.Text = "DESC";
            }
        }
    }
}
