
namespace HayatEveSigar.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<ActionResult> CreateUserOperation(User user)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> DeleteUserOperation(User user)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<UserDTO>>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<UserDTO>> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<UserDTO>> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<UserDTO>> GetUserByTc(string tc)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<UserDTO>> UpdateUserOperation(User User)
        {
            throw new NotImplementedException();
        }
    }
}