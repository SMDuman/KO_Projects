using KO_Projects.Areas.Identity.Data;
using KO_Projects.Core.Repositories;

namespace KO_Projects.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly KO_ProjectsContext _context;

        public UserRepository(KO_ProjectsContext context)
        {
            _context = context;
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUser(string id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public User UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();

            return user;
        }
    }
}
