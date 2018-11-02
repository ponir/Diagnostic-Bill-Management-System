using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInfoManagementApp
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }
        public string DeptName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public string NID { get; set; }

        public Student(string name, string email, string regNo,  string address, string phone)
            //string deptName,string fatherName, string motherName, string gender, string dateOfBirth, string religion,
            //string nationality, string nid)
        {
            Name = name;
            Email = email;
            RegNo = regNo;
            //DeptName = deptName;
            Address = address;
            Phone = phone;
            //FatherName = fatherName;
            //MotherName = motherName;
            //Gender = gender;
            //DateOfBirth = dateOfBirth;
            //Religion = religion;
            //Nationality = nationality;
            //NID = nid;
        }

    }
}