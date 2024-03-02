namespace SalesWinApp
{
    partial class frmChoose
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
            btnMember = new Button();
            btnProduct = new Button();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // btnMember
            // 
            btnMember.Location = new Point(32, 31);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(138, 33);
            btnMember.TabIndex = 0;
            btnMember.Text = "Member Management";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(32, 93);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(138, 33);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "Product Management";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(32, 156);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(138, 33);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order Management";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // frmChoose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 226);
            Controls.Add(btnOrder);
            Controls.Add(btnProduct);
            Controls.Add(btnMember);
            Name = "frmChoose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChoose";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMember;
        private Button btnProduct;
        private Button btnOrder;
    }
}