

using System.Data.SqlClient;

namespace cmd
{
    internal class Data
    {
        static string connectionString
        = "Data Source =DESKTOP-M4OSVQ7; Initial Catalog = Dafalla; Integrated Security = True;"; //Local Connection
        //= "Server=tcp:4.193.106.92,1433;Database=PUPHubPoints;User Id=sa;Password=PUPHUB123!;"; //Server Connection
        static SqlConnection sqlConnection;


        public Data()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Student> GetStudents()
        {
            var selectStatement = "SELECT * FROM dafa";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            var students = new List<Student>();

            while (reader.Read())
            {
                students.Add(new Student
                {
                    Name = reader["Name"].ToString(),
                    Course = reader["Course"].ToString(),
                    Id = Convert.ToInt32(reader["ID"].ToString()),
                    Year = Convert.ToInt32(reader["Year"].ToString()),
                    Grades = Convert.ToSingle(reader["Grades"].ToString())
                });
            }

            sqlConnection.Close();
            return students;
        }
    }
}

