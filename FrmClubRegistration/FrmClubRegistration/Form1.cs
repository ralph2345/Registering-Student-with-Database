using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, Age, count;
        private String FirstName, MiddleName, LastName, Gender, Program;

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateMember = new FrmUpdateMember();
            updateMember.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private long StudentId;

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (long.TryParse(studentIdTb.Text, out long stdntId) && int.TryParse(ageTb.Text, out int age))
            {
                StudentId = stdntId;
                LastName = lastNameTb.Text;
                FirstName = firstNameTb.Text;   
                MiddleName = middleNameTb.Text;
                Age = age;
                Gender = cbGender.Text;
                Program = cbProgram.Text;
                ID = RegistrationID();
                clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
                RefreshListOfClubMembers();
                clearText();
                    
               
            } else
            {
                MessageBox.Show("Error input on Student ID / Age");
            }
           
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            RefreshListOfClubMembers();
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }

        public int RegistrationID()
        {
            count++;
            return count;
        } 

        void clearText()
        {
            firstNameTb.Text = "";
            middleNameTb.Text = "";
            lastNameTb.Text = "";
            ageTb.Text = "";
            cbGender.Text = "";
            cbProgram.Text = "";
            studentIdTb.Text = "";
        }
    }
}
