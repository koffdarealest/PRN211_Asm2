namespace SalesWinApp
{
    partial class frmMyOrder
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
            button1 = new Button();
            tbProductName = new TextBox();
            label1 = new Label();
            dgvMyOrder = new DataGridView();
            label2 = new Label();
            tbQuantity = new TextBox();
            label3 = new Label();
            tbPrice = new TextBox();
            label4 = new Label();
            tbTotal = new TextBox();
            button2 = new Button();
            label5 = new Label();
            tbTotalOrder = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMyOrder).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(531, 193);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbProductName
            // 
            tbProductName.Location = new Point(155, 33);
            tbProductName.Name = "tbProductName";
            tbProductName.Size = new Size(161, 27);
            tbProductName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Product Name";
            // 
            // dgvMyOrder
            // 
            dgvMyOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMyOrder.Location = new Point(28, 241);
            dgvMyOrder.Name = "dgvMyOrder";
            dgvMyOrder.RowHeadersWidth = 51;
            dgvMyOrder.RowTemplate.Height = 29;
            dgvMyOrder.Size = new Size(597, 188);
            dgvMyOrder.TabIndex = 3;
            dgvMyOrder.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 105);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(155, 98);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(161, 27);
            tbQuantity.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 40);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(431, 33);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(162, 27);
            tbPrice.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 105);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 9;
            label4.Text = "Total";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(431, 98);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(162, 27);
            tbTotal.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(413, 193);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 193);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 11;
            label5.Text = "Total Order";
            // 
            // tbTotalOrder
            // 
            tbTotalOrder.Location = new Point(155, 186);
            tbTotalOrder.Name = "tbTotalOrder";
            tbTotalOrder.Size = new Size(161, 27);
            tbTotalOrder.TabIndex = 12;
            // 
            // frmMyOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(tbTotalOrder);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(tbTotal);
            Controls.Add(label3);
            Controls.Add(tbPrice);
            Controls.Add(label2);
            Controls.Add(tbQuantity);
            Controls.Add(dgvMyOrder);
            Controls.Add(label1);
            Controls.Add(tbProductName);
            Controls.Add(button1);
            Name = "frmMyOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMyOrder";
            Load += frmMyOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMyOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbProductName;
        private Label label1;
        private DataGridView dgvMyOrder;
        private Label label2;
        private TextBox tbQuantity;
        private Label label3;
        private TextBox tbPrice;
        private Label label4;
        private TextBox tbTotal;
        private Button button2;
        private Label label5;
        private TextBox tbTotalOrder;
    }
}