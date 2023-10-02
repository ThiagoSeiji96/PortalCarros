using Application.InputModels;
using Application.Services.Interface;
using Application.ViewModels;
using Core.Entities;
using Core.Repositories;

namespace Application.Services
{
    public class UserService : IUserApplication
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task CreateAsync(CreateUserInputModel model)
        {
            var user = new User(model.Id, model.Name, model.Email, model.Password);

            await _userRepository.CreateAsync(user);
        }

        public async Task<UserViewModel> GetUserAsync(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
            var userViewModel = new UserViewModel(user.Name, user.Email, user.BirthDate);

            return userViewModel;
        }

        public Task<User> GetUserByEmailAndPasswordAsync(string email, string passwordHash)
        {
            throw new NotImplementedException();
        }
    }
}
