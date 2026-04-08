using Bogus;
using DbSeeder.Interfaces;
using DbSeeder.Models;
using Microsoft.EntityFrameworkCore;

namespace DbSeeder.Services;

public class SeederService : ISeederService
{
    private readonly List<string> _positions =
    [
        // Management & Leadership
        "General Manager",
        "Department Head",
        "Regional Director",
        "Branch Manager",
        "Operations Manager",
        "Project Coordinator",
        "Team Supervisor",

        // Administrative & Support
        "Administrative Assistant",
        "Executive Secretary",
        "Office Administrator",
        "Data Entry Clerk",
        "Records Manager",
        "Receptionist",
        "Human Resources Generalist",

        // Financial & Analytical
        "Business Analyst",
        "Accountant",
        "Payroll Specialist",
        "Financial Advisor",
        "Auditor",
        "Budget Analyst",

        // Sales & Customer Relations
        "Sales Representative",
        "Account Executive",
        "Customer Service Associate",
        "Public Relations Specialist",
        "Marketing Coordinator",
        "Client Success Specialist",

        // Technical & Skilled Labor
        "Technical Support Specialist",
        "Inventory Controller",
        "Logistics Coordinator",
        "Quality Assurance Inspector",
        "Maintenance Supervisor",
        "Facility Manager",
        "Safety Officer",

        // Entry Level & General
        "Staff Assistant",
        "Trainee",
        "Junior Associate",
        "General Laborer"
    ];

    public async Task Seed(DbContext dbContext, CancellationToken cancellationToken)
    {
        const int batchSize = 500;

        var companyFaker = new Faker<Company>()
            .RuleFor(c => c.Name, f => f.Company.CompanyName())
            .RuleFor(c => c.Location, f => f.Address.City());

        var companies = companyFaker.Generate(batchSize / 2);

        var employeeFaker = new Faker<Employee>()
            .RuleFor(e => e.FullName, f => f.Person.FullName)
            .RuleFor(e => e.Company, f => f.PickRandom(companies))
            .RuleFor(e => e.Position, f => f.PickRandom(_positions))
            .RuleFor(e => e.Salary, f => f.Finance.Amount(10000, 100000));

        var employees = employeeFaker.Generate(batchSize * 2);

        dbContext.AddRange(companies);
        dbContext.AddRange(employees);

        await dbContext.SaveChangesAsync(cancellationToken);
    }
}