using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Task_Analyzer
{
    public static class TestConnection
    {
        public static void VerifyConnection(string connectionString) // Changed to void, throws on error
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // If Open() succeeds, connection is considered verified.
                }
            }
            catch (SqlException ex)
            {
                // Wrap SqlException to provide more context
                throw new InvalidOperationException($"SQL connection failed. Review connection string and SQL Server accessibility. Connection string: \"{connectionString}\"", ex);
            }
            catch (Exception ex) // Catch other potential exceptions (e.g., ArgumentException for bad connection string format)
            {
                throw new InvalidOperationException($"An unexpected error occurred while attempting to verify the database connection. Connection string: \"{connectionString}\"", ex);
            }
        }
    }
}