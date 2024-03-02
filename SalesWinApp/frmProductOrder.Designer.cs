namespace SalesWinApp
{
    partial class frmProductOrder
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbID = new TextBox();
            tbUnitPrice = new NumericUpDown();
            btAdd = new Button();
            tbName = new TextBox();
            tbWeight = new TextBox();
            tbQuantity = new NumericUpDown();
            btCancel = new Button();
            tbCategory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tbUnitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 50);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "ProductID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 100);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 152);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 206);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 259);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Unit Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 317);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 5;
            label6.Text = "Quantity in Order";
            // 
            // tbID
            // 
            tbID.Location = new Point(202, 43);
            tbID.Name = "tbID";
            tbID.Size = new Size(192, 27);
            tbID.TabIndex = 6;
            // 
            // tbUnitPrice
            // 
            tbUnitPrice.Location = new Point(202, 252);
            tbUnitPrice.Name = "tbUnitPrice";
            tbUnitPrice.Size = new Size(192, 27);
            tbUnitPrice.TabIndex = 8;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(80, 396);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(107, 43);
            btAdd.TabIndex = 9;
            btAdd.Text = "Add to cart";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(199, 93);
            tbName.Name = "tbName";
            tbName.Size = new Size(192, 27);
            tbName.TabIndex = 10;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(199, 199);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(195, 27);
            tbWeight.TabIndex = 12;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(199, 310);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(195, 27);
            tbQuantity.TabIndex = 13;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(236, 396);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(107, 43);
            btCancel.TabIndex = 14;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // tbCategory
            // 
            tbCategory.Location = new Point(202, 145);
            tbCategory.Name = "tbCategory";
            tbCategory.Size = new Size(192, 27);
            tbCategory.TabIndex = 15;
            // 
            // frmProductOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 490);
            Controls.Add(tbCategory);
            Controls.Add(btCancel);
            Controls.Add(tbQuantity);
            Controls.Add(tbWeight);
            Controls.Add(tbName);
            Controls.Add(btAdd);
            Controls.Add(tbUnitPrice);
            Controls.Add(tbID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductOrder";
            Load += frmProductOrder_Load;
            ((System.ComponentModel.ISupportInitialize)tbUnitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbID;
        private NumericUpDown tbUnitPrice;
        private Button btAdd;
        private TextBox tbName;
        private TextBox tbWeight;
        private NumericUpDown tbQuantity;
        private Button btCancel;
        private TextBox tbCategory;
    }
}