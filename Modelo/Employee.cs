using System.ComponentModel.DataAnnotations;

namespace TP_Final.Modelo

{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string   Title { get; set; } = string.Empty;
        public string   Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }



    }
}
