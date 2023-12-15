using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect = new SqlConnection(connectionString);
        private SqlCommand sqlCommand;
        private SqlDataReader sqlReader;
        private SqlDataAdapter sqlAdapter;
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Suarez.253740\\source\\repos\\FrmClubRegistration\\FrmClubRegistration\\ClubDB.mdf;Integrated Security=True";

        public DataTable dataTable;
        public BindingSource bindingSource;
        public String _FirstName, _LastName, _MiddleName, _Gender, _Program;
        public int _Age;

        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dTable = new DataTable();
        BindingSource bindingS = new BindingSource();

        public ClubRegistrationQuery()
        {
            
        }

        public bool DisplayList()
        {
            String ViewClubMembers = ("Select ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program FROM ClubMembers");
            dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(ViewClubMembers, connection);
            bindingSource = new BindingSource();
            dataAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            return true;
        }

        public bool RegisterStudent(int ID, long StudentID, string FirstName, string MiddleName, string LastName, int Age, string Gender, string Program)
        {
            try
            {
                sqlConnect.Open();
                using (sqlCommand = new SqlCommand("INSERT INTO ClubMembers(ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program) VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect))
                {
                    sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    sqlCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = StudentID;
                    sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                    sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
                    sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                    sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                    sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
                    sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;

                    
                    sqlCommand.ExecuteNonQuery();
                   
                    
                }
                return true;

            } catch (Exception e)
            {
                MessageBox.Show("There's error in registering student "+e.Message);
                return false;
            } finally { sqlConnect.Close(); }

            
        }

    }

}
