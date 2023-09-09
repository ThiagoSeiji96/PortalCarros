using Core.Entities;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Repository.Persistence;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private PortalCarrosDbContext _dbContext;
        public UserRepository(PortalCarrosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(User user)
        {

            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(p => p.Email == email && p.Password == passwordHash);
        }
    }
}
