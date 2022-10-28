using System;
using System.Collections.Generic;

namespace Web.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Performer { get; set; }

        public Person Employee { get; set; }
        public Person ProjectManager { get; set; }
        public List<Person> ProjectExecutors { get; set; }

        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Priority { get; set; }
    }
}
