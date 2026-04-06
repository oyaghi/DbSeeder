namespace DbSeeder.Models;

public class Company
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Location { get; set; }

    public List<Employee> Employees { get; set; } = [];
}