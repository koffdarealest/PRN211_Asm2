namespace SalesWinApp
{
    partial class frmCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProduct = new DataGridView();
            btSort = new Button();
            gbFilter = new GroupBox();
            btFilter = new Button();
            rbUnitsInStock = new RadioButton();
            rbUnitPrice = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            tbTo = new TextBox();
            tbFrom = new TextBox();
            gbSearch = new GroupBox();
            tbSearch = new TextBox();
            cbSearch = new ComboBox();
            btLoad = new Button();
            btViewCart = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            gbFilter.SuspendLayout();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(12, 280);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 29;
            dgvProduct.Size = new Size(775, 307);
            dgvProduct.TabIndex = 0;
            // 
            // btSort
            // 
            btSort.Location = new Point(611, 207);
            btSort.Name = "btSort";
            btSort.Size = new Size(101, 42);
            btSort.TabIndex = 41;
            btSort.Text = "DESC";
            btSort.UseVisualStyleBackColor = true;
            btSort.Click += btSort_Click;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btFilter);
            gbFilter.Controls.Add(rbUnitsInStock);
            gbFilter.Controls.Add(rbUnitPrice);
            gbFilter.Controls.Add(label7);
            gbFilter.Controls.Add(label8);
            gbFilter.Controls.Add(tbTo);
            gbFilter.Controls.Add(tbFrom);
            gbFilter.Location = new Point(326, 33);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(454, 117);
            gbFilter.TabIndex = 40;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // btFilter
            // 
            btFilter.Location = new Point(323, 74);
            btFilter.Name = "btFilter";
            btFilter.Size = new Size(100, 37);
            btFilter.TabIndex = 40;
            btFilter.Text = "Filter";
            btFilter.UseVisualStyleBackColor = true;
            btFilter.Click += btFilter_Click;
            // 
            // rbUnitsInStock
            // 
            rbUnitsInStock.AutoSize = true;
            rbUnitsInStock.Location = new Point(154, 74);
            rbUnitsInStock.Name = "rbUnitsInStock";
            rbUnitsInStock.Size = new Size(119, 24);
            rbUnitsInStock.TabIndex = 43;
            rbUnitsInStock.TabStop = true;
            rbUnitsInStock.Text = "Units in Stock";
            rbUnitsInStock.UseVisualStyleBackColor = true;
            // 
            // rbUnitPrice
            // 
            rbUnitPrice.AutoSize = true;
            rbUnitPrice.Location = new Point(32, 74);
            rbUnitPrice.Name = "rbUnitPrice";
            rbUnitPrice.Size = new Size(93, 24);
            rbUnitPrice.TabIndex = 42;
            rbUnitPrice.TabStop = true;
            rbUnitPrice.Text = "Unit Price";
            rbUnitPrice.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 33);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 40;
            label7.Text = "From";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(238, 33);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 41;
            label8.Text = "To";
            // 
            // tbTo
            // 
            tbTo.Location = new Point(271, 26);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(152, 27);
            tbTo.TabIndex = 1;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(74, 27);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(144, 27);
            tbFrom.TabIndex = 0;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(tbSearch);
            gbSearch.Controls.Add(cbSearch);
            gbSearch.Location = new Point(12, 33);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(290, 93);
            gbSearch.TabIndex = 39;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(108, 35);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(154, 27);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "ID", "Email" });
            cbSearch.Location = new Point(17, 35);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(70, 28);
            cbSearch.TabIndex = 0;
            // 
            // btLoad
            // 
            btLoad.Location = new Point(120, 207);
            btLoad.Name = "btLoad";
            btLoad.Size = new Size(101, 42);
            btLoad.TabIndex = 42;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            // 
            // btViewCart
            // 
            btViewCart.Location = new Point(367, 207);
            btViewCart.Name = "btViewCart";
            btViewCart.Size = new Size(101, 42);
            btViewCart.TabIndex = 43;
            btViewCart.Text = "View Cart";
            btViewCart.UseVisualStyleBackColor = true;
            btViewCart.Click += btViewCart_Click;
            // 
            // frmCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 590);
            Controls.Add(btViewCart);
            Controls.Add(btLoad);
            Controls.Add(btSort);
            Controls.Add(gbFilter);
            Controls.Add(gbSearch);
            Controls.Add(dgvProduct);
            Name = "frmCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCart";
            Load += frmCart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProduct;
        private Button btSort;
        private GroupBox gbFilter;
        private Button btFilter;
        private RadioButton rbUnitsInStock;
        private RadioButton rbUnitPrice;
        private Label label7;
        private Label label8;
        private TextBox tbTo;
        private TextBox tbFrom;
        private GroupBox gbSearch;
        private TextBox tbSearch;
        private ComboBox cbSearch;
        private Button btLoad;
        private Button btViewCart;
    }
}