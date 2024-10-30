using Microsoft.EntityFrameworkCore;
using WorkoutAPI.Models;

namespace WorkoutAPI.Data.Contexts;

public class WorkoutDbContext : DbContext {
    
    public WorkoutDbContext(DbContextOptions<WorkoutDbContext> options) : base(options)
    {}

    public DbSet<Exercise> Exercises { get; set; }
    public DbSet<Training> Trainings { get; set; }

}
