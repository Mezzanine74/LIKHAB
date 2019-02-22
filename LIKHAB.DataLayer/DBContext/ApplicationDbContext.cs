using LIKHAB.DataLayer.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LIKHAB.DataLayer.DBContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ApplicationServices", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}