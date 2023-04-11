﻿using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string FormatName { get; set; }
        public float Wage { get; set; }
        public byte[] EmployeeImage { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CitizenID { get; set; }
        public string CommissionRate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Age { get; set; }
        public string StatusJob { get; set; }
        public string AuthorName { get; set; }

        public EmployeeDTO() { }

        public EmployeeDTO(int employeeID, string password, string fullName, string sex, string formatName, float wage, byte[] employeeImage, string phoneNumber, string address, string citizenID, string commissionRate, DateTime dateOfBirth, string age, string statusJob, string authorName)
        {
            EmployeeID=employeeID;
            Password=password;
            FullName=fullName;
            Sex=sex;
            FormatName=formatName;
            Wage=wage;
            EmployeeImage=employeeImage;
            PhoneNumber=phoneNumber;
            Address=address;
            CitizenID=citizenID;
            CommissionRate=commissionRate;
            DateOfBirth=dateOfBirth;
            Age=age;
            StatusJob=statusJob;
            AuthorName=authorName;
        }

        public EmployeeDTO( string password, string fullName, string sex, string formatName, float wage, byte[] employeeImage, string phoneNumber, string address, string citizenID, string commissionRate, DateTime dateOfBirth, string age, string authorName)
        {
            Password=password;
            FullName=fullName;
            Sex=sex;
            FormatName=formatName;
            Wage=wage;
            EmployeeImage=employeeImage;
            PhoneNumber=phoneNumber;
            Address=address;
            CitizenID=citizenID;
            CommissionRate=commissionRate;
            DateOfBirth=dateOfBirth;
            Age=age;
            AuthorName=authorName;
        }

    }
}
