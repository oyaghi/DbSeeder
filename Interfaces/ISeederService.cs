using Microsoft.EntityFrameworkCore;

namespace DbSeeder.Interfaces;

public interface ISeederService
{
    Task Seed(DbContext dbContext, CancellationToken cancellationToken = default);
}