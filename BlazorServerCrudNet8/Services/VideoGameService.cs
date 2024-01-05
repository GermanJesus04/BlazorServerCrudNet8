using BlazorServerCrudNet8.Data;
using BlazorServerCrudNet8.Models;
using BlazorServerCrudNet8.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BlazorServerCrudNet8.Services
{
    public class VideoGameService : IVideoGameService
    {
        private readonly DataContext _dataContext;
        public VideoGameService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<VideoGame>> GetAllVideoGames()
        {
            var result = await _dataContext.videoGames.ToListAsync();
            return result;
        }

       
        public async Task<VideoGame> GetVideoGameByIdAsync(int id)
        {
            var resul = await _dataContext.videoGames.FindAsync(id);
            return resul;
        }

        public async Task AddGameAsync(VideoGame videoGame)
        {
            _dataContext.Add(videoGame);
            await _dataContext.SaveChangesAsync();
        }

        public async Task UpdateGameAsync(VideoGame videoGame, int id)
        {
            var dbgame = await _dataContext.videoGames.FindAsync(id);
            if (dbgame != null)
            {
                dbgame.Title = videoGame.Title;
                dbgame.Publisher = videoGame.Publisher;
                dbgame.ReleaseYear = videoGame.ReleaseYear;
                _dataContext.Update(dbgame);
                await _dataContext.SaveChangesAsync();
            }
        }
        public async Task DeleteGameAsync(int id)
        {
            var game = await _dataContext.videoGames.FindAsync(id);
            if (game != null)
            {
                _dataContext.videoGames.Remove(game);
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
