using Core.Entities;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User> GetUserAsync(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
    }
}
