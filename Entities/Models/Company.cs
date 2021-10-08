using System.Collections.Generic;

namespace Entities.Models
{
    public class Company
    {

        public Company()
        {
            Employees = new HashSet<Employee>();
        }

        public int CompanyID { get; set; }
        public string CompanyTitle { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}