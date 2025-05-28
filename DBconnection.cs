namespace Travel_Ease
{
    public static class DbConnection
    {
        // Define the connection string as a static property
        public static string ConnectionString = "Data Source=AABIA\\SQLEXPRESS;Initial Catalog=TravelEase;Integrated Security=True;Encrypt=False";

        // Optional: Method to create and return a new SqlConnection
        public static Microsoft.Data.SqlClient.SqlConnection GetConnection()
        {
            return new Microsoft.Data.SqlClient.SqlConnection(ConnectionString);
        }
    }
}