using Microsoft.EntityFrameworkCore;
using App = API.Entities;

namespace API.Data;
public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>()
            ?? throw new InvalidOperationException("Could not get AppDbContext service.");

        SeedData(context);
    }

    private static void SeedData(AppDbContext context)
    {
        context.Database.Migrate();

        if (context.Tasks.Any()) return;

        var tasks = new List<App.Task>
        {
            new() {
                Description = "Task 1 Description",
                IsComplete = false,
                CreateDate = DateTime.Now,
                CompleteDate = null
            },
            new() {
                Description = "Task 2 Description",
                IsComplete = false,
                CreateDate = DateTime.Now,
                CompleteDate = null
            }
        };

        context.Tasks.AddRange(tasks);
        context.SaveChanges();
    }
}