using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;
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
             When Gender= 1 Then 'Male'
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

        public static bool DeletePerson (int ID)
        {
            int RowsAffected = 0;

            string query = "DELETE People WHERE PersonID =@ID ";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                RowsAffected = cmd.ExecuteNonQuery();
              
            }catch(Exception ex) 
            {
                //
            }
            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool IsPersonExist(int ID)
        {
            bool IsFound = false;

            string query = "SELECT 1 FROM People WHERE PersonID = @ID";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);


            try
            {
                connection.Open();
                IsFound = (command.ExecuteScalar()!=null);
            }
            catch(Exception ex)
            {

            }
             finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool IsPersonExist(string NationalNO)
        {
            bool IsFound = false;

            string query = "SELECT 1 FROM People WHERE NationalNO = @NationalNO";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);


            try
            {
                connection.Open();
                IsFound = (command.ExecuteScalar() != null);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }


        public static bool GetPersonInfoByID(int ID, ref string FirstName, ref string NationalNo,
         ref string SecondName, ref string ThirdName, ref string LastName, ref byte Gender,
         ref DateTime DateOfBirth, ref string Address, ref string Phone, ref string Email,
         ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            string query = "SELECT * FROM People WHERE PersonID = @ID";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    
                    NationalNo = Convert.ToString(reader["NationalNo"]);
                    FirstName = Convert.ToString(reader["FirstName"]);
                    SecondName = Convert.ToString(reader["SecondName"]);
                    LastName = Convert.ToString(reader["LastName"]);
                    Gender = Convert.ToByte(reader["Gender"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    Address = Convert.ToString(reader["Address"]);
                    Phone = Convert.ToString(reader["Phone"]);
                    CountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = Convert.ToString(reader["ThirdName"]);
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = Convert.ToString(reader["Email"]);
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = Convert.ToString(reader["ImagePath"]);
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    IsFound = true;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
               //
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static bool GetPersonInfoByNationalNO(string NationalNO, ref int ID, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName, ref byte Gender,
            ref DateTime DateOfBirth, ref string Address, ref string Phone, ref string Email,
            ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            string query = "SELECT * FROM People WHERE NationalNO = @NationalNO";
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    ID = Convert.ToInt32(reader["PersonID"]);
                    FirstName = Convert.ToString(reader["FirstName"]);
                    SecondName = Convert.ToString(reader["SecondName"]);
                    LastName = Convert.ToString(reader["LastName"]);
                    Gender = Convert.ToByte(reader["Gender"]);
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                    Address = Convert.ToString(reader["Address"]);
                    Phone = Convert.ToString(reader["Phone"]);
                    CountryID = Convert.ToInt32(reader["NationalityCountryID"]);

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = Convert.ToString(reader["ThirdName"]);
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = Convert.ToString(reader["Email"]);
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = Convert.ToString(reader["ImagePath"]);
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    
                    IsFound = true;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
               
                System.Diagnostics.Debug.WriteLine("Error Details: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddNewPerson(string NationalNO, string FirstName,
            string SecondName, string LastName, byte Gender,
            DateTime DateOfBirth, string Address, string Phone,
            int CountryID, string ThirdName = "", string Email = "", string ImagePath = "")
        {
            int ID = -1;

            string query = @"INSERT INTO People (FirstName, SecondName, ThirdName, LastName, NationalNo,
                                         DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
                     VALUES (@FirstName, @SecondName, @ThirdName, @LastName, @NationalNO,
                             @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath);
                     SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (ThirdName != "")
            {
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            }
            else
            {
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            }

            if (Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            }

            if (ImagePath != "")
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int AutoID))
                {
                    ID = AutoID;
                }
            }
            catch (Exception ex)
            {
                // will be implemented later
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }

        public static bool UpdatePerson(int ID, string NationalNO, string FirstName,
         string SecondName, string LastName, byte Gender,
         DateTime DateOfBirth, string Address, string Phone,
         int CountryID, string ThirdName = "", string Email = "", string ImagePath = "")
        {
            string query = @"UPDATE People  
                     SET FirstName = @FirstName,
                         SecondName = @SecondName,
                         ThirdName = @ThirdName,
                         LastName = @LastName, 
                         NationalNO = @NationalNO,
                         DateOfBirth = @DateOfBirth,
                         Gender = @Gender,
                         Address = @Address,  
                         Phone = @Phone,
                         Email = @Email, 
                         NationalityCountryID = @NationalityCountryID,
                         ImagePath = @ImagePath
                     WHERE PersonID = @ID;";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNO", NationalNO);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@NationalityCountryID", CountryID);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            int RowsAffected=0;
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                connection.Close();
            }

            return (RowsAffected>0);
        }



    }
}
