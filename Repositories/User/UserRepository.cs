namespace TodoApi.Repositories.User
{
    public class UserRepository()
    {

        public long Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public List<UserRepository> MapFromModel(List<Models.User> users)
        {
            if (users == null)
            {
                return [];
            }

            List<UserRepository> usersRepo = [];
            foreach (Models.User user in users)
            {
                usersRepo.Add(new UserRepository()
                {
                    Id = user.Id,
                    FirstName = user.FirstName ?? "",
                    LastName = user.LastName ?? "",
                    Email = user.Email
                });
            }

            return usersRepo;
        }
    }
}