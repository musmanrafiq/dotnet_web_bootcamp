using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Database=StudentDB;";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select * from Student", connection);
            connection.Open();

            //SqlDataReader reader = cmd.ExecuteReader();
            /*while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }*/

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            sqlDataAdapter.TableMappings.Add("Student", "Teacher");

            DataSet dataSetForStudent = new DataSet();
            sqlDataAdapter.Fill(dataSetForStudent, "Teacher");
            //connection.Close();

            // get no of records in data set's table no 1
            int noOfRecords = dataSetForStudent.Tables[0].Rows.Count;
            Console.WriteLine(noOfRecords);

            var enumirator = dataSetForStudent.Tables["Teacher"].Rows;
            foreach (DataRow row in enumirator)
            {
                Console.WriteLine(row["Name"]);
            }

            //dataSetForStudent.Tables["Student"].Rows[0]["Name"] = "Toyota";
            //dataSetForStudent.Tables["Student"].Rows[0]["Name"] = "MAN";

            //sqlDataAdapter.Update(dataSetForStudent,"Student");
            sqlDataAdapter.Dispose();
            

            connection.Close();

        }
    }
}