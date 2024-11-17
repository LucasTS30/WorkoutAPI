using Microsoft.EntityFrameworkCore;
using WorkoutAPI.Models;

namespace WorkoutAPI.Data.Contexts;

public class WorkoutDbContext : DbContext {
    
    public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options) : base(options)
    {}

    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Training> Trainings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exercise>().ToTable("Exercise");
        modelBuilder.Entity<Training>().ToTable("Training");
    }

}
