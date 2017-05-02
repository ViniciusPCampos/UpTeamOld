using System;
using Microsoft.AspNet.Identity.EntityFramework;
using UPTEAM.Infra.CrossCutting.Identity.Model;

namespace UPTEAM.Infra.CrossCutting.Identity.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDisposable
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}