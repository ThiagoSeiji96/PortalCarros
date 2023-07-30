using Application.InputModels;
using Application.ViewModels;
using Core.Entities;

namespace Application.Services.Interface
{
    public interface IUserApplication
    {
        Task CreateAsync(CreateUserInputModel user);
        Task<UserViewModel> GetUserAsync(int id);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash);
    }
}
