using BusinessObject;
using DataAccess.Repository;
using SalesWinApp;
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
    public partial class frmMain : Form
    {
        public IMemberRepository MemberRepository = new MemberRepository();
        public Boolean isAdmin { get; set; }
        public Member MemberInfo { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmMember_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                this.Hide();
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.ShowDialog();
                this.Show();
            }
            else
            {
                this.Hide();
                frmMemberDetail frmMemberDetails = new frmMemberDetail()
                {
                    Text = "Update member",
                    InsertOrUpdate = true,
                    MemberInfo = MemberInfo,
                    MemberRepository = MemberRepository
                };
                frmMemberDetails.ShowDialog();
                this.Show();
            }
        }

        private void tsmOrder_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                this.Hide();
                frmOrderManagement frmOrderManagement = new frmOrderManagement();
                frmOrderManagement.ShowDialog();
                this.Show();
            }
            else
            {
                this.Hide();
                frmOrderManagement frmOrderManagement = new frmOrderManagement()
                {
                    isAdmin = false,
                    MemberInfo = MemberInfo,
                    MemberRepository = MemberRepository
                };
                frmOrderManagement.ShowDialog();
                this.Show();
            }
        }

        private void tsmProduct_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                this.Hide();
                frmProductManagement frmProductManagement = new frmProductManagement();
                frmProductManagement.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You do not have sufficient access permissions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) => Close();
    }
}
