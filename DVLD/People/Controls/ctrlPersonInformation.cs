using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People.Controls
{
    public partial class ctrlPersonInformation : UserControl
    {
        private int _PersonID = -1;
        private clsPerson _Person = null;

        public ctrlPersonInformation()
        {
            InitializeComponent();
            _ResetValues();
        }

        private void _ResetValues()
        {
            _PersonID = -1;
            _Person = null;

            lblPersonIDResult.Text = "N/A";
            lblNameResult.Text = "N/A";
            lblNationalNOResult.Text = "N/A";
            lblGenderResult.Text = "N/A";
            lblEmailResult.Text = "N/A";
            lblAddressResult.Text = "N/A";
            lblDateOfBirthResult.Text = "N/A";
            lblPhoneResult.Text = "N/A";
            lblCountryResult.Text = "N/A";

            pbPersonImage.ImageLocation = null;
            pbPersonImage.Image = Resources.male_image;
            pbGender.Image = Resources.gender_male;

            llblEditPersonInfo.Visible = false;
        }

        public void LoadPersonData(int PersonID)
        {
            _PersonID = PersonID;
            _Person = clsPerson.Find(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("Person with ID: " + _PersonID + " is not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ResetValues();
                llblEditPersonInfo.Visible = false;

                return;
            }
            else
            {
                lblPersonIDResult.Text = _PersonID.ToString();
                lblNameResult.Text = _Person.FullName;
                lblNationalNOResult.Text = _Person.NationalNO;
                lblGenderResult.Text = (_Person.Gender == 1 ? "Male" : "Female");
                lblEmailResult.Text = _Person.Email;
                lblAddressResult.Text = _Person.Address;
                lblDateOfBirthResult.Text = _Person.DateOfBirth.ToShortDateString();
                lblPhoneResult.Text = _Person.Phone;
                lblCountryResult.Text = _Person.CountryInfo.Name;

                if (_Person.ImagePath != "")
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                }
                else
                {
                    pbPersonImage.ImageLocation = null;
                    pbPersonImage.Image = (_Person.Gender == 1 ? Resources.male_image : Resources.female_image);
                }

                pbGender.Image = (_Person.Gender == 1 ? Resources.gender_male : Resources.gender_female);
                llblEditPersonInfo.Visible = true;

            }

        }
        private void ctrlPersonInformation_Load(object sender, EventArgs e)
        {
        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();

            LoadPersonData(_PersonID);
        }

   
    }
}
