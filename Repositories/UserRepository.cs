
namespace HayatEveSigar.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HayatEveSigarContext _context;
        public UserRepository(HayatEveSigarContext context)
        {
            _context = context;
        }

        public Task CreateUserOperation(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserOperation(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByTc(string tc)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserOperation(User User)
        {
            throw new NotImplementedException();
        }
    }
}