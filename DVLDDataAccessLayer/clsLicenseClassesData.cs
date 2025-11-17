using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsLicenseClassesData
    {
        public static bool GetLicenseClassInfoByID(int ID, ref string ClassName, ref string ClassDes, ref byte MinAllowedAge, ref byte DefValidLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LicenseClasses
                            where LicenseClassID = @LicClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicClassID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDes = (string)reader["ClassDescription"];
                    MinAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefValidLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

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

        public static bool GetLicenseClassInfoByName(string ClassName, ref int ID, ref string ClassDes, ref byte MinAllowedAge, ref byte DefValidLength, ref decimal ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LicenseClasses
                            where ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ID = (int)reader["LicenseClassID"];
                    ClassDes = (string)reader["ClassDescription"];
                    MinAllowedAge = (byte)reader["MinimumAllowedAge"];
                    DefValidLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];

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
    }
}
