using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp_EF_HW_3.Models
{
    public class Cat
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Weight { get; set; }
    }
}