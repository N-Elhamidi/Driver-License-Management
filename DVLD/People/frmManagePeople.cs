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
        public frmManagePeople()
        {
            InitializeComponent();
        }
        private void _SetDataView()
        {
            dgvListPeople.DataSource = clsPerson.GetAllPeople();

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
        }

        private void _RefreshDataView()
        {
            dgvListPeople.DataSource = clsPerson.GetAllPeople();
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

               if( MessageBox.Show("Are you sure you want to delete person with ID: " + PersonID, "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
                {
                    if(clsPerson.DeletePerson(PersonID))
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
    }
}
