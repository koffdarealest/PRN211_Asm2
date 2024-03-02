using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public IMemberRepository memberRepository = new MemberRepository();
        public MemberObject member { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                if (AdminAccount.IsAdmin(username, password))
                {
                    frmChoose frmChoose = new frmChoose();
                    this.Hide();
                    frmChoose.ShowDialog();
                    this.Close();
                }
                member = memberRepository.getMemberByEmailPass(username, password);
                if (member != null)
                {
                    frmMember frmMember = new frmMember()
                    {
                        MemberObject = member,
                        InsertOrUpdate = true
                    };
                    this.Hide();
                    frmMember.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
