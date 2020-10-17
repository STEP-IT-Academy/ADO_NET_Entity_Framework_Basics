using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp_EF_HW_3.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
