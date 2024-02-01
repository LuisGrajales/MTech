using System.ComponentModel.DataAnnotations;

namespace MTech.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [StringLength(14)]
        [RegularExpression(@"^[A-Za-z]{3,4}[0-9]{6}[0-9A-Za-z]{3}$")]
        public string RFC { get; set; }
        [DataType(DataType.Date)]
        public DateTime BornDate { get; set; }
        public int EmployeeStatus { get; set; }
    }
}
