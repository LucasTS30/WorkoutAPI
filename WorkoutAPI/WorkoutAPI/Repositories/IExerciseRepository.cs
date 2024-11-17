using WorkoutAPI.Models;

namespace WorkoutAPI.Repositories;

public interface IExerciseRepository
{
    Task AddExerciseAsync(Exercise exercise);
    Task DeleteExerciseAsync(int id);
    Task<Exercise> GetByIdAsync(int id);
    Task UpdateExerciseAsync(Exercise exercise);
    Task<IEnumerable<Exercise>> GetAllExercisesAsync();
}