namespace DbSeeder.Models;

public class Employee
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Position { get; set; } = null!;

    public decimal Salary { get; set; }

    public int CompanyId { get; set; }

    public Company Company { get; set; } = null!;
}