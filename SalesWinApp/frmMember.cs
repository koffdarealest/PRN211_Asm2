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
    public partial class frmMember : Form
    {
        public MemberObject MemberObject { get; set; }
        public IMemberRepository memberRepository = new MemberRepository();
        internal IMemberRepository MemberRepository;
        public bool InsertOrUpdate { get; set; } //true: update - false: insert
        public bool isAdmin { get; set; }
        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            try
            {
                if (isAdmin)
                {
                    txtPassword.Enabled = false;
                    txtEmail.Enabled = false;
                    btnView.Enabled = false;
                    txtMemberID.Enabled = false;
                }
                if (InsertOrUpdate)
                {
                    txtMemberID.Enabled = false;
                    txtMemberID.Text = MemberObject.MemberId.ToString();
                    txtEmail.Text = MemberObject.MemberEmail;
                    txtPassword.Text = MemberObject.MemberPassword;
                    txtCity.Text = MemberObject.MemberCity;
                    txtCountry.Text = MemberObject.MemberCountry;
                    txtCompanyName.Text = MemberObject.CompanyName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate)
                {
                    MemberObject.MemberId = int.Parse(txtMemberID.Text);
                    MemberObject.MemberEmail = txtEmail.Text;
                    MemberObject.MemberPassword = txtPassword.Text;
                    MemberObject.MemberCountry = txtCountry.Text;
                    MemberObject.MemberCity = txtCity.Text;
                    MemberObject.CompanyName = txtCompanyName.Text;

                    memberRepository.UpdateMember(MemberObject);
                    MessageBox.Show("Update member successfully");
                    Close();
                }
                else
                {
                    MemberObject = new MemberObject()
                    {
                        MemberId = int.Parse(txtMemberID.Text),
                        MemberEmail = txtEmail.Text,
                        MemberPassword = txtPassword.Text,
                        MemberCountry = txtCountry.Text,
                        MemberCity = txtCity.Text,
                        CompanyName = txtCompanyName.Text
                    };
                    memberRepository.InsertMember(MemberObject);
                    MessageBox.Show("Insert member successfully");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmCart frmViewOrder = new frmCart()
            {
                memberObject = MemberObject
            };
            this.Hide();
            frmViewOrder.ShowDialog();
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
