using BusinessObject;
using DataAccess.Repository;
using System;
using System.Net.Mail;
using System.Windows.Forms;
using DataAccess.DAO;

namespace SalesWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // False: Insert - True: Update
        public Member MemberInfo { get; set; }
        public Boolean isAdmin { get; set; }

        // Load Form
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (isAdmin)
            {
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
            }
            // Update mode
            if (InsertOrUpdate == true)
            {
                // Show member to perform updating
                txtID.Text = MemberInfo.MemberId.ToString();
                txtCompanyName.Text = MemberInfo.CompanyName;
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;
            }

        }

        // Save function
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(txtEmail.Text);
                if (InsertOrUpdate == false)
                {
                    var member = new Member()
                    {
                        CompanyName = txtCompanyName.Text,
                        Email = mailAddress.ToString(),
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                    };
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    var member = new Member()
                    {
                        MemberId = Int32.Parse(txtID.Text),
                        CompanyName = txtCompanyName.Text,
                        Email = mailAddress.ToString(),
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                    };
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel function
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}