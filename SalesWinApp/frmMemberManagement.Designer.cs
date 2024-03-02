namespace SalesWinApp
{
    partial class frmMemberManagement
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
            lbMemberId = new Label();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtCompanyName = new TextBox();
            lbCompanyName = new Label();
            txtCity = new TextBox();
            lbCity = new Label();
            txtCountry = new TextBox();
            lbCountry = new Label();
            btnLoad = new Button();
            grSreach = new GroupBox();
            cbSearch = new ComboBox();
            txtSearch = new TextBox();
            grFilter = new GroupBox();
            cbFilterList = new ComboBox();
            cbFilter = new ComboBox();
            btnNew = new Button();
            btnDelete = new Button();
            dgvMember = new DataGridView();
            btnSort = new Button();
            grSreach.SuspendLayout();
            grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(51, 62);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(63, 15);
            lbMemberId.TabIndex = 0;
            lbMemberId.Text = "MemberID";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(146, 59);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(175, 23);
            txtMemberID.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(146, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 23);
            txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(78, 113);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(146, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 23);
            txtPassword.TabIndex = 5;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(57, 163);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(538, 59);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(175, 23);
            txtCompanyName.TabIndex = 7;
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(414, 62);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(94, 15);
            lbCompanyName.TabIndex = 6;
            lbCompanyName.Text = "Company Name";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(538, 110);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(175, 23);
            txtCity.TabIndex = 9;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(480, 113);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 8;
            lbCity.Text = "City";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(538, 160);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(175, 23);
            txtCountry.TabIndex = 11;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(458, 163);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(146, 217);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(99, 39);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += frmMemberManagement_Load;
            // 
            // grSreach
            // 
            grSreach.Controls.Add(cbSearch);
            grSreach.Controls.Add(txtSearch);
            grSreach.Location = new Point(78, 276);
            grSreach.Name = "grSreach";
            grSreach.Size = new Size(268, 66);
            grSreach.TabIndex = 15;
            grSreach.TabStop = false;
            grSreach.Text = "Search";
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "ID", "Email" });
            cbSearch.Location = new Point(26, 27);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(62, 23);
            cbSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(105, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(146, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(cbFilterList);
            grFilter.Controls.Add(cbFilter);
            grFilter.Location = new Point(480, 276);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(249, 66);
            grFilter.TabIndex = 16;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // cbFilterList
            // 
            cbFilterList.FormattingEnabled = true;
            cbFilterList.Location = new Point(124, 27);
            cbFilterList.Name = "cbFilterList";
            cbFilterList.Size = new Size(119, 23);
            cbFilterList.TabIndex = 1;
            cbFilterList.SelectedIndexChanged += cbFilterList_SelectedIndexChanged;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(6, 27);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(88, 23);
            cbFilter.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(352, 217);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(99, 39);
            btnNew.TabIndex = 17;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(568, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 39);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 357);
            dgvMember.Name = "dgvMember";
            dgvMember.Size = new Size(777, 284);
            dgvMember.TabIndex = 19;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(364, 294);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(99, 39);
            btnSort.TabIndex = 20;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 659);
            Controls.Add(btnSort);
            Controls.Add(dgvMember);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(grFilter);
            Controls.Add(grSreach);
            Controls.Add(btnLoad);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtCompanyName);
            Controls.Add(lbCompanyName);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberId);
            Name = "frmMemberManagement";
            Text = "frmMember";
            Load += frmMemberManagement_Load;
            grSreach.ResumeLayout(false);
            grSreach.PerformLayout();
            grFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberId;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtCompanyName;
        private Label lbCompanyName;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtCountry;
        private Label lbCountry;
        private Button btnLoad;
        private GroupBox grSreach;
        private GroupBox grFilter;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvMember;
        private TextBox txtSearch;
        private ComboBox cbFilterList;
        private ComboBox cbFilter;
        private Button btnSort;
        private ComboBox cbSearch;
    }
}