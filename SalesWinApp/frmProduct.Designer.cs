namespace SalesWinApp
{
    partial class frmProduct
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
            tbName = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            tbID = new TextBox();
            tbWeight = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbCategory = new ComboBox();
            tbUnitPrice = new TextBox();
            tbUnitInStock = new TextBox();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(194, 80);
            tbName.Name = "tbName";
            tbName.Size = new Size(228, 27);
            tbName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 36);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "ProductID";
            // 
            // button1
            // 
            button1.Location = new Point(82, 393);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 393);
            button2.Name = "button2";
            button2.Size = new Size(110, 39);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(194, 29);
            tbID.Name = "tbID";
            tbID.Size = new Size(228, 27);
            tbID.TabIndex = 5;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(194, 192);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(228, 27);
            tbWeight.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 87);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 9;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 143);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 199);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 11;
            label4.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 252);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 12;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 312);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 13;
            label6.Text = "Units In Stock";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "1", "2", "3" });
            cbCategory.Location = new Point(194, 135);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(228, 28);
            cbCategory.TabIndex = 14;
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Location = new Point(194, 245);
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(228, 27);
            tbUnitPrice.TabIndex = 16;
            // 
            // tbUnitInStock
            // 
            tbUnitInStock.Location = new Point(194, 305);
            tbUnitInStock.Name = "tbUnitInStock";
            tbUnitInStock.Size = new Size(228, 27);
            tbUnitInStock.TabIndex = 17;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 468);
            Controls.Add(tbUnitInStock);
            Controls.Add(tbUnitPrice);
            Controls.Add(cbCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbWeight);
            Controls.Add(tbID);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tbName);
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduct";
            Load += frmProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox tbID;
        private TextBox tbWeight;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbCategory;
        private TextBox tbUnitPrice;
        private TextBox tbUnitInStock;
    }
}