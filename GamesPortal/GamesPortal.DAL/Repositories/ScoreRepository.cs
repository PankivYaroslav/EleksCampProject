using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamesPortal.DAL.Context;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.DAL.Repositories
{
    public class ScoreRepository : IRepository<Score>
    {
        private readonly ApplicationContext _context;

        public ScoreRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Score>> GetAll()
        {
            return await _context.Scores.ToListAsync();
        }

        public async Task<Score> Get(int id)
        {
            return await _context.Scores.FindAsync(id);
        }

        public async Task<Score> Create(Score entity)
        {
            var score = await _context.Scores.AddAsync(entity);
            await _context.SaveChangesAsync();
            return score.Entity;
        }

        public async Task<Score> Update(Score entity)
        {
            var score = _context.Scores.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return score;
        }

        public async Task Delete(Score entity)
        {
            _context.Scores.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
