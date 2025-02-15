using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UsersRolesBlazor.ApiRequest.Model;

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
                id_User = 1,
                Name = "John Doe",
                
            };
        }
    }

    public class User
    {
        [Key]
        public int id_User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [ForeignKey("Roles")]
        public int Role_id { get; set; }
        public Roles Roles { get; set; }
        public ICollection<Emails> Emails { get; set; }
    }
}
