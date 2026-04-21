
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{

public class Student
    {
        [Key]
       public int Id { get; set; }

        //[Required]
        public required string Name { get; set; }

       // [Required]
        public required string Course { get; set; }

        [Range(1,100)]
        public int Age { get; set; }

    }
}
