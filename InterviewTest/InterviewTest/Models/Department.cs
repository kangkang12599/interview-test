using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewTest.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Designation { get; set; }

        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public Employee Employee { get; set; }
    }
}
