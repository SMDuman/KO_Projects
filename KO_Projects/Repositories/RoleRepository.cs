using KO_Projects.Areas.Identity.Data;
using KO_Projects.Core.Repositories;
using Microsoft.AspNetCore.Identity;

namespace KO_Projects.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly KO_ProjectsContext _context;

        public RoleRepository(KO_ProjectsContext context)
        {
            _context = context;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
