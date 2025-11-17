using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace DVLDDataAccessLayer
{
    public class clsTestAppointmentsData
    {
        public static bool GetTestAppointments(int ID, ref int TestTypeID, ref int LDL_AppID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreByUserID, ref bool IsLocked, ref int Trial, ref int RetakeTestAppID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments
                             where TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LDL_AppID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    Trial = (int)reader["Trial"];

                    if (reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestAppID = (int)reader["RetakeTestApplicationID"];
                    }
                    else
                    {
                        RetakeTestAppID = -1;
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

        public static bool GetTestAppointmentsByLDL_App(int LDL_AppID, int TestTypeID, ref int ID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreByUserID, bool IsLocked, ref int Trial, ref int RetakeTestAppID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TOP 1 * from TestAppointments
                             where LocalDrivingLicenseApplicationID = @LDL_AppID
                             AND TestTypeID = @TestTypeID 
                             AND IsLocked = @IsLocked
                             ORDER BY Trial DESC";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDL_AppID", LDL_AppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ID = (int)reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreByUserID = (int)reader["CreatedByUserID"];
                    IsLocked = (bool)reader["IsLocked"];
                    Trial = (int)reader["Trial"];

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

        public static int AddNewTestAppointment(int TestTypeID, int LDL_AppID, DateTime AppointmentDate, decimal PaidFees, int CreByUserID, bool IsLocked, int Trial, int RetakeTestAppID)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int TestAppoiID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, Trial, RetakeTestApplicationID)
                             VALUES (@TestTypeID, @LDL_AppID, @AppointmentDate, @PaidFees, @CreByUserID, @IsLocked, @Trial, @RetakeTestAppID)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDL_AppID", LDL_AppID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreByUserID", CreByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@Trial", Trial);

            if (RetakeTestAppID != -1)
                command.Parameters.AddWithValue("@RetakeTestAppID", RetakeTestAppID);
            else
                command.Parameters.AddWithValue("@RetakeTestAppID", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertID))
                {
                    TestAppoiID = insertID;
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


            return TestAppoiID;
        }

        public static bool UpdateTestAppointment(int ID, DateTime AppointmentDate, bool IsLocked)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  TestAppointments  
                            set AppointmentDate = @AppointmentDate,
                                IsLocked = @IsLocked
                            WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", ID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

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

        public static DataTable GetAllTestsAppointments(int TestType)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments
                           where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestType);

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

        public static DataTable GetAllPrvTestsAppointments(int LDL_AppID, int TestTypeID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments
                           where LocalDrivingLicenseApplicationID = @LDL_AppID
                           and TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDL_AppID", LDL_AppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

    }
}
