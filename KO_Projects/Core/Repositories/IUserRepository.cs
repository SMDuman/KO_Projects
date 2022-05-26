using Microsoft.AspNetCore.Mvc;
using KO_Projects.Areas.Identity.Data;

namespace KO_Projects.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();

        User GetUser(string id);

        User UpdateUser(User user);
    }
}
