using Microsoft.EntityFrameworkCore;

namespace TodoApi.Repositories.User
{
    public class UserQueryRepository
    {
        readonly Models.Context context;
        private UserRepository userRepository;

        public UserQueryRepository()
        {
            context = new Models.Context();
            userRepository = new UserRepository();
        }

        public async Task<UserRepository> FindById(long id = 0)
        {
            Models.User user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return new UserRepository();
            }

            userRepository.Id = user.Id;
            userRepository.FirstName = user.FirstName;
            userRepository.LastName = user.LastName;
            userRepository.Email = user.Email;

            return userRepository;
        }

        // Find by email
        public async Task<UserRepository> FindByEmail(string email = "")
        {
            Models.User user = await context.Users.Where(user => user.Email == user.Email).FirstOrDefaultAsync();
            if (user == null)
            {
                return new UserRepository();
            }

            userRepository.Id = user.Id;
            userRepository.FirstName = user.FirstName;
            userRepository.LastName = user.LastName;
            userRepository.Email = user.Email;

            return userRepository;
        }
    }
}