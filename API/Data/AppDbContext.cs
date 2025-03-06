using Microsoft.EntityFrameworkCore;
using App = API.Entities;

namespace API.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<App.Task> Tasks { get; set; }
}