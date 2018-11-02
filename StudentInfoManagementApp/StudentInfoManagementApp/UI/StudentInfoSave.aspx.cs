using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInfoManagementApp.UI
{
    public partial class StudentInfoSave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
           // Student student = new Student();
           // string name = firstNameTextBox.Text + " " + lastNameTextBox.Text;
           // string email = emailTextBox.Text;
           // string regNo = regNoTextBox.Text;
           // string deptName = deptNameTextBox.Text;
           // string address = addressTextBox.Text;
           // string phone = phoneTextBox.Text;
           // string fatherName = fatherNameTextBox.Text;
           // string motherName = motherNameTextBox.Text;
           // string gender = genderTextBox0.Text;
           // string dateOfBirth = 
           //string connectionString =@"Data Source=DESKTOP-SA6CNVM\MSSQLSERVER1;Initial Catalog=DB;Integrated Security=true;";
           //    SqlConnection connection = new SqlConnection(connectionString);
           // string query = "Insert Into Student_T Values ()";

        }

        protected void saveButton_Click1(object sender, EventArgs e)
        {
            string name = firstNameTextBox.Text + " " + lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string regNo = regNoTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;
            Student student = new Student(name, email, regNo, address, phone);

            string connactionString = @"Data Source=DESKTOP-SA6CNVM\MSSQLSERVER1;Initial Catalog=Example;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connactionString);
            string query = "INSERT INTO Info VALUES ('" + student.Name + "','" + student.Email + "','" + student.RegNo + "','" + student.Address + "','" + student.Phone + "','','')";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                messageLable.Text = "Save Successfully.";
            }
            else
            {
                messageLable.Text = "Save Failed";
            }

        }
    }
}