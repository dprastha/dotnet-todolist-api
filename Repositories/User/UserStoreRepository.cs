using Microsoft.EntityFrameworkCore;

namespace TodoApi.Repositories.User
{
    public class UserStoreRepository
    {
        readonly Models.Context context;
        private UserRepository userRepository;

        public UserStoreRepository()
        {
            context = new Models.Context();
            userRepository = new UserRepository();
        }

        public async void Create(UserRepository userRepository)
        {
            Models.User newUser = new()
            {
                FirstName = userRepository.FirstName,
                LastName = userRepository.LastName,
                Email = userRepository.Email,
                Password = userRepository.Password
            };

            await context.Users.AddAsync(newUser);
        }
    }
}