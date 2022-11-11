using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Customer { get; set; }
        [Required]
        public string Performer { get; set; }

        [Required]
        public Person Employee { get; set; }
        [Required]
        public Person ProjectManager { get; set; }
        [Required]
        public ICollection<Person> ProjectExecutors { get; set; }

        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int Priority { get; set; }
    }
}
