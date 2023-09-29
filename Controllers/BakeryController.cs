using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using ReportAPI.Models;

namespace ReportAPI.Controllers
{
    public class BakeryController : GraphController
    {

        [QueryRoot("donut")]
        public Donut RetrieveDonut()
        {
            return new Donut()
            {
                Id = 1,
                Name = "Snow Villa",
                Flavor = "Vanilla"
            };
        }
    }
}

public class Donut
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Flavor { get; set; }
}
