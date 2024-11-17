using WorkoutAPI.Models;

namespace WorkoutAPI.Repositories;

public interface ITrainingRepository
{
    Task AddTrainingAsync(Training training);
    Task DeleteTrainingAsync(int id);
    Task<Training> GetByIdAsync(int id);
    Task UpdateTrainingAsync(Training training);
    Task<IEnumerable<Training>> GetAllTrainingsAsync();
}