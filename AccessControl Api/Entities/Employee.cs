namespace AccessControl_Api.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DateBirthday { get; set; }
        public bool IsEnable { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
    }
}
