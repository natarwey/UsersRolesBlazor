using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UsersRolesBlazor.ApiRequest.Services;

namespace UsersRolesBlazor.ApiRequest.Model
{
    public class Emails
    {
        [Key]
        public int id_Email { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [Required]
        [ForeignKey("User")]
        public int User_id { get; set; }
        public User Users { get; set; }
    }
}
