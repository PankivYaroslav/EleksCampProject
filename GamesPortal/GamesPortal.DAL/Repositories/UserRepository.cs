using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamesPortal.DAL.Context;
using GamesPortal.DAL.Entities;
using GamesPortal.DAL.Repositories.Interfaces;

namespace GamesPortal.DAL.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> Create(User entity)
        {
            var user = await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
            return user.Entity;
        }

        public async Task<User> Update(User entity)
        {
            var user = _context.Users.Update(entity).Entity;
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task Delete(User entity)
        {
            _context.Users.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
