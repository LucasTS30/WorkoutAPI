namespace WorkoutAPI.Models;
public class Training
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required IEnumerable<Exercise> Exercises { get; set; }
}