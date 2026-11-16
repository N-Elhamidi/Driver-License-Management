using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private clsCountry(int ID,string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public static clsCountry GetCountryInfo(int ID)
        {
            string cName = "";
            if (clsCountryData.GetCountryInfoByID(ID,ref cName))
                {
                return new clsCountry(ID, cName);
                }
            return null;
        }

        public static clsCountry GetCountryInfo(string CountryName)
        {
            int cID = -1;

            if (clsCountryData.GetCountryInfoByName(ref cID,CountryName))
            {
                return new clsCountry(cID, CountryName);
            }
            return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
