namespace MvcSample.Queries.Dtos {
    public class EmployeeDto {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastrName { get; set; }

        public string Name { get {return LastrName + FirstName; }}

        public int Salary { get; set; }
    }
}