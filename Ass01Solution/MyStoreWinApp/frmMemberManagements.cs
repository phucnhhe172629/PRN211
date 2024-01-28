using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagements : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        //create data source
        BindingSource source;
        public frmMemberManagements()
        {
            InitializeComponent();
        }

        private void frmMemberManagements_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            //Register this event to open the frmMemberDetails form that performs updating
            dgvMemberList.CellDoubleClick += dgvMember_CellDoubleClick;
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update member",
                InsertOrUpdate = true,
                isAdmin = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(memberRepository.GetMembers());
                //set focus member updated
                source.Position = GetMemberObject().ID - 1;
            }
        }

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    ID = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void LoadMemberList(IEnumerable<MemberObject> memberList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = memberList;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "ID");
                txtName.DataBindings.Add("Text", source, "Name");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                dgvMemberList.Columns["Password"].Visible = false;

                if (memberList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e) => LoadMemberList(memberRepository.GetMembers().OrderBy(m => m.ID));

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(memberRepository.GetMembers());
                //Set focus member inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.ID);
                LoadMemberList(memberRepository.GetMembers());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                isAdmin = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(memberRepository.GetMembers());
                //set focus member updated
                source.Position = source.Position ;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.Equals("Name"))
            {
                LoadMemberList(memberRepository.GetMemberListByName(txtSearch.Text));
            }
            else
            {
                LoadMemberList(memberRepository.GetMemberListById(txtSearch.Text));
            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> filterList = null;
            if (cbFilterBy.Text.Equals("City"))
            {
                filterList = memberRepository.GetCityList();
            }
            else
            {
                filterList = memberRepository.GetCountryList();
            }
            cbFilter.Items.Clear();
            cbFilter.Items.AddRange(filterList.ToArray());
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text.Equals("City"))
            {
                LoadMemberList(memberRepository.FilterByCity(cbFilter.Text));
            }
            else
            {
                LoadMemberList(memberRepository.FilterByCountry(cbFilter.Text));
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (btnSort.Text.Equals("DESC"))
            {
                LoadMemberList(memberRepository.GetMembers().OrderBy(m => m.Name));
                btnSort.Text = "ASC";
            }
            else
            {
                LoadMemberList(memberRepository.GetMembers().OrderByDescending(m => m.Name));
                btnSort.Text = "DESC";
            }
        }
    }
}
