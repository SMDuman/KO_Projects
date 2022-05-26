using KO_Projects.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace KO_Projects.Core.ViewModels
{
    public class EditUserViewModel
    {
        public User User { get; set; }

        public IList<SelectListItem> Roles { get; set; }
    }
}
