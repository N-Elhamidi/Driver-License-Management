using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DVLD_Business;

namespace DVLD.People
{
    public partial class frmManagePeople : Form
    {
        private DataTable _dtPeople;

        public frmManagePeople()
        {
            InitializeComponent();
        }
        private void _SetDataView()
        {
            _dtPeople = clsPerson.GetAllPeople();
            dgvListPeople.DataSource = _dtPeople;

            dgvListPeople.Columns["Address"].Visible = false;
            dgvListPeople.Columns["ImagePath"].Visible = false;

            dgvListPeople.Columns["Gender"].Width = 60;

            dgvListPeople.Columns["PersonID"].Width = 90;
            dgvListPeople.Columns["PersonID"].HeaderText = "Person ID";

            dgvListPeople.Columns["DateOfBirth"].Width = 130;
            dgvListPeople.Columns["DateOfBirth"].HeaderText = "Date of Birth";



            dgvListPeople.Columns["SecondName"].Width = 120;
            dgvListPeople.Columns["SecondName"].HeaderText = "Second Name";


            dgvListPeople.Columns["NationalNO"].HeaderText = "National No";
            dgvListPeople.Columns["FirstName"].HeaderText = "First Name";
            dgvListPeople.Columns["ThirdName"].HeaderText = "Third Name";
            dgvListPeople.Columns["LastName"].HeaderText = "Last Name";

            dgvListPeople.AllowUserToResizeRows = false;
            dgvListPeople.AllowUserToResizeColumns = false;


            lblTotalRecordsResult.Text = dgvListPeople.RowCount.ToString();

            cbFilter.SelectedIndex = 0;
        }

        private void _RefreshDataView()
        {
            _dtPeople = clsPerson.GetAllPeople();
            dgvListPeople.DataSource = _dtPeople;
            lblTotalRecordsResult.Text = dgvListPeople.RowCount.ToString();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            _SetDataView();

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson FrmAddEdit = new frmAddEditPerson();
            FrmAddEdit.ShowDialog();

            _RefreshDataView();

        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (dgvListPeople.CurrentRow != null)
            {

                int PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells["PersonID"].Value);

                frmAddEditPerson FrmAddEdit = new frmAddEditPerson(PersonID);
                FrmAddEdit.ShowDialog();
                _RefreshDataView();
            }
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson();
            frm.ShowDialog();

            _RefreshDataView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (dgvListPeople.CurrentRow != null)
            {
                int PersonID = Convert.ToInt32(dgvListPeople.CurrentRow.Cells["PersonID"].Value);

                if (MessageBox.Show("Are you sure you want to delete person with ID: " + PersonID, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (clsPerson.DeletePerson(PersonID))
                    {
                        MessageBox.Show("Person Deleted Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshDataView();
                    }
                    else
                    {
                        MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = (cbFilter.SelectedIndex != 0);
            txtFilterBy.Text = "";

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Focus();
            }

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterByCondition = "";

            switch (cbFilter.Text)
            {
                case "Person ID":
                    {
                        FilterByCondition = "PersonID";
                        break;
                    }
                case "National NO.":
                    {
                        FilterByCondition = "NationalNO";
                        break;
                    }
                case "First Name":
                    {
                        FilterByCondition = "FirstName";
                        break;
                    }
                case "Second Name":
                    {
                        FilterByCondition = "SecondName";
                        break;
                    }
                case "Third Name":
                    {
                        FilterByCondition = "ThirdName";
                        break;
                    }
                case "Last Name":
                    {
                        FilterByCondition = "LastName";
                        break;
                    }
                case "Country":
                    {
                        FilterByCondition = "Country";
                        break;
                    }
                case "Gender":
                    {
                        FilterByCondition = "Gender";
                        break;
                    }
                case "Email":
                    {
                        FilterByCondition = "Email";
                        break;
                    }
                case "Phone":
                    {
                        FilterByCondition = "Phone";
                        break;
                    }
                default:
                    {
                        FilterByCondition = "None";
                        break;
                    }

            }

            if (string.IsNullOrWhiteSpace(txtFilterBy.Text) || FilterByCondition == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblTotalRecordsResult.Text = dgvListPeople.Rows.Count.ToString();
                return;
            }

            if (FilterByCondition == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}]={1}", FilterByCondition, txtFilterBy.Text.Trim());
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterByCondition, txtFilterBy.Text.Trim());
            }
            lblTotalRecordsResult.Text = (dgvListPeople.RowCount).ToString();

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Person ID")
            {
                e.Handled = !(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar));
            }
        }
    }
}
