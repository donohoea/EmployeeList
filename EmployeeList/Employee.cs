using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeList
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public string GivenName { get; set; }
        public string MiddleIntial { get; set; }
        public string Surname { get; set; }
        public string Ciy { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime Birthday { get; set; }   
    }
}