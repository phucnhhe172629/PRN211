using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // False: Insert - True: Update
        public MemberObject MemberInfo { get; set; }
        public Boolean isAdmin { get; set; }

        // Load Form
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                txtEmail.Enabled = false;
                txtPassword.Enabled = false;
            }
            txtID.Enabled = !InsertOrUpdate;
            // Update mode
            if (InsertOrUpdate == true)
            {
                // Show member to perform updating
                txtID.Text = MemberInfo.ID.ToString();
                txtName.Text = MemberInfo.Name;
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
                var member = new MemberObject()
                {
                    ID = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Email = mailAddress.ToString(),
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
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