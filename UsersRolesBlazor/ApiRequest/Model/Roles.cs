using System.ComponentModel.DataAnnotations;

namespace UsersRolesBlazor.ApiRequest.Model
{
    public class Roles
    {
        [Key]
        public int id_Role { get; set; }
        public string Tittle { get; set; }
    }
}
