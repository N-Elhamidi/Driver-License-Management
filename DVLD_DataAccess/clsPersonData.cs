using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;



namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static DataTable GetAllPeople()
        {
            DataTable PeopleList = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT PersonID,NationalNO,FirstName,SecondName,ThirdName,LastName,
             CASE 
             When Gender='m'Or Gender ='M' Then 'Male'
             ELSE 'Female' 
             END as Gender,
             DateOfBirth,Address,Email,Phone, Countries.CountryName as Country,ImagePath
             From People  
             Inner Join Countries ON People.NationalityCountryID= Countries.CountryID;
              ";

            SqlCommand Command = new SqlCommand(query,connection);

            try
            {
                connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    PeopleList.Load(Reader);
                }

                Reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return PeopleList;
        }


    }
}
