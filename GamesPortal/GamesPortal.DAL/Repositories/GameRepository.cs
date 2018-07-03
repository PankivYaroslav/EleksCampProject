using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamesPortal.DAL.Context;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.DAL.Repositories
{
    public class GameRepository : IRepository<Game>
    {
        private readonly ApplicationContext _context;

        public GameRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            return await _context.Games.ToListAsync();
        }

        public async Task<Game> Get(int id)
        {
            return await _context.Games.FindAsync(id);
        }

        public async Task<Game> Create(Game entity)
        {
            var game = await _context.Games.AddAsync(entity);
            await _context.SaveChangesAsync();
            return game.Entity;
        }

        public async Task<Game> Update(Game entity)
        {
            var game = _context.Games.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task Delete(Game entity)
        {
            _context.Games.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
