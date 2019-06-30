using System.Collections.Generic;

namespace Planta.Models
{
    public class UserModel : ModelBase
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; }

        public List<UserGroupModel> UserGroup { get; set; }
    }
}