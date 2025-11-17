using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsTestsData
    {
     public static int AddNewTest(int TestAppoiID, bool TestRes, string Notes, int CreaByUserID)
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                             VALUES (@TestAppoiID, @TestRes, @Notes, @CreaByUserID)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppoiID", TestAppoiID);
            command.Parameters.AddWithValue("@TestRes", TestRes);
            command.Parameters.AddWithValue("@CreaByUserID", CreaByUserID);

            if (Notes != "" && Notes != null)
                command.Parameters.AddWithValue("@Notes", Notes);
            else
                command.Parameters.AddWithValue("@Notes", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
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


            return TestID;
        }
    }
}
