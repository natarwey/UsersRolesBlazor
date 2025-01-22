namespace UsersRolesBlazor.ApiRequest.Services
{
    public class UserService
    {
        public User CurrentUser { get; private set; }

        public async Task LoadUserAsync()
        {
            CurrentUser = await GetUserFromApiAsync();
        }

        private async Task<User> GetUserFromApiAsync()
        {
            await Task.Delay(1000);
            return new User
            {
                Id = 1,
                Name = "John Doe",
                Role = "Admin"
            };
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}
