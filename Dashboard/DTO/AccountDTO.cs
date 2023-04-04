using Dashboard.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.DTO
{
    public class AccountDTO
    {
        public int emloyeeID { get; set; }
        public string fullName { get; set; }
        public string sex { get; set; }
        public DateTime dateOfBirth { get; set; }
        public byte[] employeeImage { get; set; }
        public string formatName { get; set; }
        public string address { get; set; }
        public string citizenID { get; set; }
        public int age { get; set; }
        public string statusJob { get; set; }
        public string role { get; set; }

        public AccountDTO(int emloyeeID, string fullName, string sex, DateTime dateOfBirth, byte[] employeeImage, string formatName, string address, string citizenID, int age, string statusJob, string role)
        {
            this.emloyeeID = emloyeeID;
            this.fullName = fullName;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.employeeImage = employeeImage;
            this.formatName = formatName;
            this.address = address;
            this.citizenID = citizenID;
            this.age = age;
            this.statusJob = statusJob;
            this.role = role;
        }
    }
}
