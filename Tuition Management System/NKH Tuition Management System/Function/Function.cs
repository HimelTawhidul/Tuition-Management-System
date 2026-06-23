using System.Data;
using Microsoft.Data.SqlClient;

namespace NKH_Tution.Function
{
    public class Functions
    {
        // =====================================================================
        // CONNECTION STRING
        // Update the AttachDbFilename path to match your .mdf file location.
        // The path below uses a relative path so the project works on any PC.
        // =====================================================================
        private readonly string ConStr =
    "Data Source=(LocalDB)\\MSSQLLocalDB;" +
    "AttachDbFilename=\"C:\\Users\\Himel Tawhidul\\Downloads\\NKH_FinalZipf\\DBNKH.mdf\";" +
    "Integrated Security=True;" +
    "Connect Timeout=30;" +
    "Encrypt=True;";



        public DataTable GetData(string query, SqlParameter[]? parameters = null)
        {
            using SqlConnection con = new SqlConnection(ConStr);
            using SqlCommand cmd = new SqlCommand(query, con);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            using SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            using SqlConnection con = new SqlConnection(ConStr);
            using SqlCommand cmd = new SqlCommand(query, con);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            con.Open();
            return cmd.ExecuteNonQuery();
        }

        public bool TestConnection()
        {
            try
            {
                using SqlConnection con = new SqlConnection(ConStr);
                con.Open();
                return true;
            }
            catch { return false; }
        }
    }
}
