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
    public partial class frmLogin : Form
    {
        public IMemberRepository MemberRepository = new MemberRepository();
        public Member MemberInfo { get; set; } = null;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            MemberInfo = MemberRepository.GetAccount(email, password);
            if (MemberInfo != null && email.Equals("admin@fstore.com"))
            {
                frmMain frmMain = new frmMain()
                {
                    isAdmin = true,
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else if (MemberInfo != null)
            {
                frmMain frmMain = new frmMain()
                {
                    isAdmin = false,
                    MemberInfo = MemberInfo,
                    MemberRepository = MemberRepository
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
