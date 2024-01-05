using BlazorServerCrudNet8.Models;

namespace BlazorServerCrudNet8.Services.Interfaces
{
    public interface IVideoGameService
    {
        Task<List<VideoGame>> GetAllVideoGames();
        Task<VideoGame> GetVideoGameByIdAsync(int id);
        Task AddGameAsync(VideoGame videoGame);
        Task UpdateGameAsync(VideoGame videoGame, int id);
        Task DeleteGameAsync(int id);
    }
}
