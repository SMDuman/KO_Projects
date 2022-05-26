using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using KO_Projects.Areas.Identity.Data;

namespace KO_Projects.Core.Repositories
{
    public interface IRoleRepository
    {
        ICollection<IdentityRole> GetRoles();
    }
}
