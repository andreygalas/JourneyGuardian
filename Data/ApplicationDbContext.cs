using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASP.NET_CRUD_APP.Models;

namespace ASP.NET_CRUD_APP.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASP.NET_CRUD_APP.Models.Trip> Trip { get; set; } = default!;
        public DbSet<ASP.NET_CRUD_APP.Models.DotAudit> DotAudit { get; set; } = default!;
    }
}