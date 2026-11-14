using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }
    }
}
