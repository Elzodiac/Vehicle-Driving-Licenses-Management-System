using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsApplicationsData
    {
        public static bool GetAppInfoByID(int ID, ref int AppPersonID, ref DateTime AppDate, ref int AppTypeID, ref byte AppStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreaByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Applications
                           WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    AppPersonID = (int)reader["ApplicantPersonID"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    AppTypeID = (int)reader["ApplicationTypeID"];
                    AppStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (Decimal)reader["PaidFees"];
                    CreaByUserID = (int)reader["CreatedByUserID"];

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

        public static int AddNewApp(int AppPersonID, DateTime AppDate, int AppTypeID, int AppStatus, DateTime LastStatusDate, decimal PaidFees, int CreaByUserID)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int AppID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                             VALUES (@AppPersonID, @AppDate, @AppTypeID, @AppStatus, @LastStatusDate, @PaidFees, @CreaByUserID)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreaByUserID", CreaByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    AppID = insertID;
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


            return AppID;
        }

        public static bool UpdateApp(int ID, int AppPersonID, DateTime AppDate, int AppTypeID, int AppStatus, DateTime LastStatusDate, Decimal PaidFees, int CreaByUserID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  Applications  
                            set ApplicantPersonID = @AppPersonID,
                                ApplicationDate = @AppDate,
                                ApplicationTypeID = @AppTypeID,
                                ApplicationStatus = @AppStatus,
                                LastStatusDate = @LastStatusDate,
                                PaidFees = @PaidFees,                     
                                CreatedByUserID = @CreaByUserID
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreaByUserID", CreaByUserID);
            command.Parameters.AddWithValue("@ApplicationID", ID);

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

        public static bool IsAppExistsByPersonID(int AppPersonID, int LicClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select Found = 1
                             from Applications
                             INNER JOIN LocalDrivingLicenseApplications
                             ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             where ApplicantPersonID = @AppPersonID and ApplicationTypeID = 1 and (ApplicationStatus = 1 or ApplicationStatus = 2) and LicenseClassID = @LicClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            command.Parameters.AddWithValue("@LicClassID", LicClassID);

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

        public static bool DeleteApplication(int AppliID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Applications 
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", AppliID);

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
    }
}

