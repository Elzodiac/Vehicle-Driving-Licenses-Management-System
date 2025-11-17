using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsLDLAppData
    {
        public static bool GetLDLAppInfoByID(int ID, ref int AppID, ref int LicClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LDL_AppID = @LDL_AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_AppID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    AppID = (int)reader["ApplicationID"];
                    LicClassID = (int)reader["LicenseClassID"];

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

        public static bool GetLDLAppInfoByAppID(ref int ID, int AppID, ref int LicClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", AppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ID = (int)reader["LDL_AppID"];
                    LicClassID = (int)reader["LicenseClassID"];

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
        public static bool GetvwLDLAppInfoByID(int ID, ref string DrivingClass, ref string FullName, ref DateTime AppDate, ref int TestPassed, ref string StatusName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select DrivingClass, FullName, ApplicationDate, TestPassed, StatusName
                           FROM vw_LocalDrivingLicenseApplicationsFull WHERE LDL_AppID = @LDL_AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_AppID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    DrivingClass = (string)reader["DrivingClass"];
                    FullName = (string)reader["FullName"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    TestPassed = (int)reader["TestPassed"];
                    StatusName = (string)reader["StatusName"];

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

        public static int AddNewLDLApp(int AppID, int LicClassID)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int LocDriLiAppID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)
                             VALUES (@AppID, @LicClassID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@LicClassID", LicClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocDriLiAppID = insertedID;
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


            return LocDriLiAppID;
        }

        public static bool UpdateLDLApp(int ID, int AppID, int LicClassID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  LocalDrivingLicenseApplications  
                            set ApplicationID = @AppID,
                                LicenseClassID = @LicClassID
                                where LDL_AppID = @LDL_AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@LicClassID", LicClassID);
            command.Parameters.AddWithValue("@LDL_AppID", ID);

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

        public static DataTable GetAllLDLApp()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from vw_LocalDrivingLicenseApplicationsFull";

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

        public static bool DeleteLDLApp(int ID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete LocalDrivingLicenseApplications  
                                where LDL_AppID = @LDL_AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_AppID", ID);

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

        public static bool IsLDLAppExists(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM LocalDrivingLicenseApplications WHERE LDL_AppID = @LDL_AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDL_AppID", ID);

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
