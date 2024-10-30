namespace WorkoutAPI.Models;
public class Exercise
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Reps { get; set; }
    public string? Note { get; set; }
}