using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int ID, ref string NationalNo, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor,
            ref string Address, ref string Phone, ref string Email,
            ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    NationalNo = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //allows null in database so we should handle null

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = (string)reader["SecondName"];
                    }
                    else
                    {
                        SecondName = "";
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    } else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
               

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            { 
                connection.Close(); 
            }

            return isFound;
        }

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int ID, ref string FirstName, ref string SecondName,
    ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor,
    ref string Address, ref string Phone, ref string Email,
    ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //allows null in database so we should handle null

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = (string)reader["SecondName"];
                    }
                    else
                    {
                        SecondName = "";
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor,
            string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People (NationalNo, FirstName, SecondName,
                            ThirdName, LastName, DateOfBirth, Gendor, Address,
                            Phone, Email, NationalityCountryID, ImagePath)
                             VALUES (@NationalNo, @FirstName, @SecondName, @ThirdName,
                               @LastName, @DateOfBirth, @Gendor, @Address, @Phone,
                               @Email, @NationalityCountryID, @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (SecondName != "" && SecondName != null)
                command.Parameters.AddWithValue("@SecondName", SecondName);
            else
                command.Parameters.AddWithValue("@SecondName", System.DBNull.Value);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath!="" && ImagePath!=null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
             else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value );

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
            

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
               
            }

            finally 
            { 
                connection.Close(); 
            }


            return PersonID;
        }

        public static bool UpdatePerson(int ID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor,
            string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {

            int rowsAffected=0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                            set NationalNo = @NationalNo,
                                FirstName = @FirstName, 
                                SecondName = @SecondName,
                                ThirdName = @ThirdName,
                                LastName = @LastName,  
                                DateOfBirth = @DateOfBirth,
                                Gendor = @Gendor,
                                Address = @Address, 
                                Phone = @Phone, 
                                Email = @Email,
                                NationalityCountryID = @NationalityCountryID,
                                ImagePath = @ImagePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName",FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address",  Address);
            command.Parameters.AddWithValue("@Phone",    Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (SecondName != "" && SecondName != null)
                command.Parameters.AddWithValue("@SecondName", SecondName);
            else
                command.Parameters.AddWithValue("@SecondName", System.DBNull.Value);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "" && ImagePath!=null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally 
             { 
                connection.Close(); 
             } 

            return (rowsAffected > 0);
        }

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();
               

            }

            catch (Exception ex)
            {
               Console.WriteLine("Error: " + ex.Message);
            }
            finally 
            { 
                connection.Close(); 
            }

            return dt;

        }

        public  static bool DeletePerson(int PersonID)
        {

            int rowsAffected=0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete People 
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                 rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
               Console.WriteLine("Error: " + ex.Message);
            }
            finally 
            { 
                
                connection.Close(); 
            
            }

            return (rowsAffected > 0);

        }

        public static bool IsPersonExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsPersonExistsByNationalNo(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
