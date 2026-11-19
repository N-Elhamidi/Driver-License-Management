
using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People
{
    public partial class frmAddEditPerson : Form
    {
        public frmAddEditPerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }

        public frmAddEditPerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Edit;
            _PersonID = PersonID;
        }

        public enum enMode { AddNew = 0, Edit }
        private enMode _Mode;

        private int _PersonID = -1;

        private clsPerson _Person;


        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

        }

        private void _ResetValues()
        {
            _FillCountriesInComboBox();

            llblRemoveImage.Visible = false;


            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Turkey");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNO.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

            rbMale.Checked = true;
            pbPersonImage.Image = Resources.male_image;

        }

        private void _LoadData()
        {

            _Person = clsPerson.Find(_PersonID);


            if (_Person != null)
            {
                lblPersonID_result.Text = _PersonID.ToString();
                txtFirstName.Text = _Person.FirstName;
                txtSecondName.Text = _Person.SecondName;
                txtThirdName.Text = _Person.ThirdName;
                txtLastName.Text = _Person.LastName;
                txtNationalNO.Text = _Person.NationalNO;
                dtDateOfBirth.Value = _Person.DateOfBirth;
                txtAddress.Text = _Person.Address;
                txtPhone.Text = _Person.Phone;
                txtEmail.Text = _Person.Email;
                cbCountry.SelectedIndex = cbCountry.FindString(_Person.CountryInfo.Name);

                
                if (_Person.Gender == 1)
                {
                    rbMale.Checked = true;
                }
                else
                    rbFemale.Checked = true;

                if (_Person.ImagePath != "")
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;

                }
                else
                {
                    if (rbMale.Checked)
                    {
                        pbPersonImage.Image = Resources.male_image;

                    }
                    else { pbPersonImage.Image = Resources.female_image; }
                }
                llblRemoveImage.Visible = ((pbPersonImage.ImageLocation != null));
            }
            else
            {
                MessageBox.Show("Person Not Found!","Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetValues();

            if (_Mode == enMode.Edit)
            {
                lblAddEditHeader.Text = "Edit Person ";
                _LoadData();
            }
            else
            {
                _Person = new clsPerson();
            }

        }


        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
            {
                pbPersonImage.Image = Resources.male_image;
            }
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == null)
            {
                pbPersonImage.Image = Resources.female_image;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Person.NationalNO = txtNationalNO.Text.Trim();
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Gender = ((rbMale.Checked) ? (byte)1 : (byte)0);
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.CountryID = clsCountry.GetCountryInfo(cbCountry.Text).ID;
            _Person.DateOfBirth = dtDateOfBirth.Value;
            _Person.ImagePath = "";//implemented later

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(Temp, null);
            }

        }

        private void ValidateNationalNO(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txt, null);
            }

            if (txt.Text.Trim() != _Person.NationalNO && clsPerson.IsPersonExist(txt.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt, "National Number is used for another person!");
            }
            else
            {
                errorProvider1.SetError(txt, null);
            }
        }

        
    }
}
