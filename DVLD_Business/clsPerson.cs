using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Text;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew= 0,Update };
        public enMode Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string NationalNO { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int CountryID { set; get; }
        public string ImagePath { set; get; }

        public clsCountry CountryInfo;

        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.NationalNO = "";
            this.Gender = 0;
            this.DateOfBirth = DateTime.Now;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.CountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string FirstName, string SecondName, 
            string LastName, string NationalNO, DateTime DateOfBirth, byte Gender,
             string Address, string Phone, int CountryID,
             string ImagePath =" ", string ThirdName="", string Email="")

        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNO = NationalNO;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.GetCountryInfo(CountryID);

            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.NationalNO, this.FirstName,this.SecondName, this.LastName,
              this.Gender,this.DateOfBirth, this.Address,this.Phone,
              this.CountryID,this.ThirdName,this.Email,this.ImagePath);

            return (this.PersonID !=-1);
        }

        public static bool DeletePerson(int ID)
        {
            return clsPersonData.DeletePerson(ID);
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                {
                        if (this._AddNewPerson())
                        {
                            this.Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                case enMode.Update:
                {
                  return false;
                }
            }
            return false;
        }

        public static clsPerson Find(int PersonID)
        {

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNO = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            byte Gender = 0;

            bool IsFound = (clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref NationalNO, ref SecondName, ref ThirdName, ref LastName, ref Gender, ref DateOfBirth, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath));
            if(IsFound)
            {
                return new clsPerson(PersonID, FirstName, SecondName, LastName, NationalNO, DateOfBirth, Gender, Address, Phone, NationalityCountryID, ImagePath, ThirdName, Email);
            }
            
            return null;
        }

        public static clsPerson Find(string NationalNO)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int NationalityCountryID = -1;
            int PersonID = -1; 
            byte Gender = 0;

           
            bool IsFound = (clsPersonData.GetPersonInfoByNationalNO(NationalNO, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Gender, ref DateOfBirth, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath));

            if (IsFound)
            {
                return new clsPerson(PersonID, FirstName, SecondName, LastName, NationalNO, DateOfBirth, Gender, Address, Phone, NationalityCountryID, ImagePath, ThirdName, Email);
            }

            return null;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

    }
}
