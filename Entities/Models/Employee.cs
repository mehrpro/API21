namespace Entities.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public byte Age { get; set; }
        public int CompanyID_FK { get; set; }
        public Company Company { get; set; }





    }
}