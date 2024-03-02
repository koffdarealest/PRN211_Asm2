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
    public partial class frmMemberManagement : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        private List<MemberObject> membersList;
        private List<MemberObject> searchList;
        BindingSource binding;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            //cbSearch.SelectedIndex = 0;
            //cbFilter.SelectedIndex = 0;
            LoadMemberList();
            dgvMember.CellDoubleClick += DgvMember_CellDoubleClick;
        }

        private void LoadMemberList()
        {
            var member = memberRepository.GetMembers();
            this.membersList = member;
            try
            {
                binding = new BindingSource();
                binding.DataSource = membersList;

                txtMemberID.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", binding, "MemberID");
                txtCity.DataBindings.Add("Text", binding, "MemberCity");
                txtEmail.DataBindings.Add("Text", binding, "MemberEmail");
                txtCompanyName.DataBindings.Add("Text", binding, "CompanyName");
                txtCountry.DataBindings.Add("Text", binding, "MemberCountry");
                txtPassword.DataBindings.Add("Text", binding, "MemberPassword");

                dgvMember.DataSource = binding;

                if (membersList == null)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnNew.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnNew.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearText()
        {
            txtMemberID.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
            txtCompanyName.Text = "";
            txtCountry.Text = "";
            txtPassword.Text = "";
        }

        private void DgvMember_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                isAdmin = true,
                memberRepository = memberRepository,
                MemberObject = membersList[dgvMember.CurrentRow.Index]
            };
            if (frmMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                binding.Position = binding.Count - 1;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMember frmMember = new frmMember()
            {
                Text = "Insert Member",
                InsertOrUpdate = false,
                memberRepository = memberRepository
            };
            if (frmMember.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                binding.Position = binding.Count - 1;
            }
            LoadMemberList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberId);
                LoadMemberList();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }

        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject()
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    MemberEmail = txtEmail.Text,
                    MemberPassword = txtPassword.Text,
                    MemberCountry = txtCountry.Text,
                    MemberCity = txtCity.Text,
                    CompanyName = txtCompanyName.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return member;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string textSearch = txtSearch.Text;
                if (cbSearch.SelectedIndex == 0)
                {
                    if (string.IsNullOrEmpty(textSearch))
                    {
                        LoadMemberList();
                    }
                    else
                    {
                        searchList = membersList.Where(x => x.MemberId.ToString().Contains(textSearch)).ToList();
                        LoadSearchMember(searchList);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(textSearch))
                    {
                        LoadMemberList();
                    }
                    else
                    {
                        searchList = membersList.Where(x => x.MemberEmail.Contains(textSearch)).ToList();
                        LoadSearchMember(searchList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadSearchMember(List<MemberObject> searchList)
        {
            binding = new BindingSource();
            binding.DataSource = searchList;

            txtMemberID.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCountry.DataBindings.Clear();
            txtCity.DataBindings.Clear();
            txtCompanyName.DataBindings.Clear();
            txtPassword.DataBindings.Clear();

            txtMemberID.DataBindings.Add("Text", binding, "MemberID");
            txtEmail.DataBindings.Add("Text", binding, "MemberEmail");
            txtCountry.DataBindings.Add("Text", binding, "MemberCountry");
            txtCity.DataBindings.Add("Text", binding, "MemberCity");
            txtCompanyName.DataBindings.Add("Text", binding, "CompanyName");
            txtPassword.DataBindings.Add("Text", binding, "MemberPassword");

            binding.DataSource = searchList;
            dgvMember.DataSource = binding;

            if (searchList == null)
            {
                ClearText();
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
                btnNew.Enabled = true;
                btnLoad.Enabled = true;
            }
        }

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchList = memberRepository.GetMembers();

            if (cbFilter.SelectedIndex == 0)
            {
                searchList = memberRepository.FilterByCity(cbFilterList.SelectedItem.ToString());
                LoadSearchMember(searchList);
            }
            else
            {
                searchList = memberRepository.FilterByCountry(cbFilterList.SelectedItem.ToString());
                LoadSearchMember(searchList);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    strings = GetListCity();
                    break;
                case 1:
                    strings = GetListCountry();
                    break;
            }
            cbFilterList.Items.Clear();
            if (strings != null)
            {
                cbFilterList.Items.AddRange(strings.ToArray());
            }
            cbFilterList.SelectedIndex = 0;
        }

        private List<string> GetListCountry()
        {
            return memberRepository.GetMembers().Select(x => x.MemberCountry).Distinct().ToList();
        }

        private List<string> GetListCity()
        {
            return memberRepository.GetMembers().Select(x => x.MemberCity).Distinct().ToList();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<MemberObject> memberObjects = new List<MemberObject>();
            if (searchList == null)
            {
                memberObjects = memberRepository.GetMembers();
            }
            else
            {
                memberObjects = searchList;
            }
            if (btnSort.Text.Trim().Equals("Sort"))
            {
                memberObjects = memberObjects.OrderByDescending(x => x.MemberId).ToList();
                LoadSearchMember(memberObjects);
                btnSort.Text = "ASC";
            }
            else
            {
                memberObjects = memberObjects.OrderBy(x => x.MemberId).ToList();
                LoadSearchMember(memberObjects);
                btnSort.Text = "DESC";
            }
        }
    }
}
