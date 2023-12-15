using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void comboStudentId_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ClubMembers Where StudentId = @ID";
            sqlConnection.ConnectionString = SqlConnection;

            using (sqlConnection)
            {
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                using (SqlCommand comm = new SqlCommand(query, sqlConnection))
                {

                    comm.Parameters.AddWithValue("@ID", Convert.ToInt64(comboStudentId.SelectedItem));
                    SqlDataReader dataReader = comm.ExecuteReader();

                    if (dataReader.Read())
                    {

                        StudentId = dataReader.GetInt64(1);
                        FirstName = dataReader.GetString(2);
                        MiddleName = dataReader.GetString(3);
                        LastName = dataReader.GetString(4);
                        Age = dataReader.GetInt32(5);
                        Gender = dataReader.GetString(6);
                        Program = dataReader.GetString(7);

                        FillData();
                        dataReader.Close();
                    }
                }
                sqlConnection.Close();
            }
        }
        void FillData()
        {
            comboStudentId.Text = StudentId.ToString();
            firstNameTextB.Text = FirstName;
            middleNameTextB.Text = MiddleName;
            lastNameTextB.Text = LastName;
            ageTextB.Text = Age.ToString();
            comboGender.Text = Gender;
            comboProgram.Text = Program;
        }

        private long StudentId;
        SqlConnection sqlConnection;
        string SqlConnection;

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string UpdateQue = "UPDATE ClubMembers SET FirstName = @firstName, MiddleName = @middleName, LastName = @lastName, Age = @age, Gender = @gender, Program = @program WHERE StudentId = @ID";

            sqlConnection.ConnectionString = SqlConnection;
            using (sqlConnection)
            {
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(UpdateQue, sqlConnection))
                {
                    command.Parameters.AddWithValue("@ID", StudentId);
                    command.Parameters.AddWithValue("@firstName", firstNameTextB.Text);
                    command.Parameters.AddWithValue("@middleName", middleNameTextB.Text);
                    command.Parameters.AddWithValue("@lastName", lastNameTextB.Text);
                    command.Parameters.AddWithValue("@age", Convert.ToInt32(ageTextB.Text));
                    command.Parameters.AddWithValue("@gender", comboGender.Text);
                    command.Parameters.AddWithValue("@program", comboProgram.Text);

                    command.ExecuteNonQuery();

                }
                sqlConnection.Close();
            }

            MessageBox.Show("Successfully updated");
            this.Close();
        }
        

        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            SqlConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Suarez.253740\\source\\repos\\FrmClubRegistration\\FrmClubRegistration\\ClubDB.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(SqlConnection);
            string query = "SELECT  * FROM ClubMembers";
            sqlConnection.ConnectionString = SqlConnection;
            using (sqlConnection)
            {
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@ID", Convert.ToInt64(comboStudentId.SelectedItem));

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboStudentId.Items.Add(reader.GetInt64(1));
                    }
                    reader.Close();
                }
                sqlConnection.Close();
            }

        }
    }
}
