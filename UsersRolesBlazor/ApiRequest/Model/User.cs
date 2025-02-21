using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UsersRolesBlazor.ApiRequest.Model
{
    public class UserDataShort
    {
        public int id_User { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int role_id { get; set; }
        public object roles { get; set; }
        public object emails { get; set; }
    }

    public class UserData
    {
        public bool status { get; set; }
        public List<UserDataShort> data { get; set; }
    }

    public class UserDataContainer
    {
        public List<UserDataShort> users { get; set; }
    }

    public class ReqDataUser
    {
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }

    public class UserAddData
    {
        public bool status { get; set; }
    }

    public class UserUpdateData
    {
        public bool status { get; set; }
        public string message { get; set; }
    }

    public class UserDeleteData
    {
        public bool status { get; set; }
        public string message { get; set; }
    }
}
