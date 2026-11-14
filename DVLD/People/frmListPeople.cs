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
    public partial class frmListPeople : Form
    {
        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {
            dgvListPeople.DataSource = clsPerson.GetAllPeople();

            dgvListPeople.Columns["Address"].Visible = false;
            dgvListPeople.Columns["ImagePath"].Visible = false;

            dgvListPeople.Columns["Gender"].Width = 60;

            dgvListPeople.Columns["PersonID"].Width = 90;
            dgvListPeople.Columns["PersonID"].HeaderText = "Person ID";


            dgvListPeople.Columns["NationalNO"].HeaderText = "National No";
            dgvListPeople.Columns["FirstName"].HeaderText = "First Name";

            dgvListPeople.Columns["SecondName"].Width = 120;
           dgvListPeople.Columns["SecondName"].HeaderText = "Second Name";


            dgvListPeople.Columns["ThirdName"].HeaderText = "Third Name";
            dgvListPeople.Columns["LastName"].HeaderText = "Last Name";

            dgvListPeople.Columns["DateOfBirth"].Width = 130;
          dgvListPeople.Columns["DateOfBirth"].HeaderText = "Date of Birth";

            
            lblTotalRecordsResult.Text = dgvListPeople.RowCount.ToString();


        }
    }
}
