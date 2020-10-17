using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp_EF_HW_2.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Birthday { get; set; }

        [Required]
        public string Phone { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}