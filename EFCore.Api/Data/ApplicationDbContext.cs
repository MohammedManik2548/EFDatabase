using EFCore.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Person> Persons { get; set; }
}