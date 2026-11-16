using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries";

            SqlCommand cmd = new SqlCommand(query,connection);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }catch(Exception ex)
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool GetCountryInfoByID(int CountryID,ref string CountryName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    IsFound = true;
                }

                reader.Close();

            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetCountryInfoByName(ref int CountryID,  string CountryName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT CountryID FROM Countries WHERE CountryName = @CountryName";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    CountryID = (int)reader["CountryID"];
                    IsFound = true;
                }

                reader.Close();

            }
            catch
            {
                //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

    }
}
