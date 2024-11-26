namespace FullStackTechTestDotNet.DataAccessLayer.Entities;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AddressLine1 { get; set; }
    public string Town { get; set; }
    public string Postcode { get; set; }

    public List<Order> Orders { get; } = new();
}