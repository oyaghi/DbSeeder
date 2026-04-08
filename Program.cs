using DbSeeder.Data;
using DbSeeder.Interfaces;
using DbSeeder.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ISeederService, SeederService>();

using var host = builder.Build();
var lifetime = host.Services.GetRequiredService<IHostApplicationLifetime>();

using var scope = host.Services.CreateScope();
var seederService = scope.ServiceProvider.GetRequiredService<ISeederService>();
await seederService.Seed(scope.ServiceProvider.GetRequiredService<ApplicationDbContext>(), lifetime.ApplicationStopping);

host.Run();