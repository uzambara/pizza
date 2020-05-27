using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.User;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Repositories;
using Innoscripta.Pizza.Factories;
using Innoscripta.Pizza.Services.Interfaces;

namespace Innoscripta.Pizza.Services.Implementations
{
    public class UserService: IUserService
    {
        private BaseRepository<UserEntity> _userRepository;
        private UserEntityFactory _userEntityFactory;

        public UserService(BaseRepository<UserEntity> userRepository, UserEntityFactory userEntityFactory)
        {
            _userRepository = userRepository;
            _userEntityFactory = userEntityFactory;
        }

        public async Task<RegisterUserResponse> RegisterAsync(RegisterUserRequest request)
        {
            var user = _userEntityFactory.Create(
                request.Name,
                request.LastName,
                request.Phone,
                request.Password);

            _userRepository.Add(user);
            await _userRepository.SaveChangesAsync();
            return new RegisterUserResponse();
        }
    }
}