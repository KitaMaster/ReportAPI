using GraphQL.Types;

namespace ReportAPI.Models
{
    public record Employee(int Id, string Name, int Age, int DeptId);
    public record Department(int Id, string Name);

    public class EmployeeDetails
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? DeptName { get; set; }
    }

    public class EmployeeDetailsType : ObjectGraphType<EmployeeDetails>
    {
        // EmployeeDetails is the model for API response but GraphQL
        // can’t understand this hence we need to create a mapping and as a result,
        // we create EmployeeDetailsType Field mapping class.
        public EmployeeDetailsType()
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Age);
            Field(x => x.DeptName);
        }
    }
}
