using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyMvcApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
    }
}
