using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp_EF_HW_2.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Person> People { get; set; }

        public Country() => People = new List<Person>();
    }
}
