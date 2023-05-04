using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UnfoundedOptimism.Models;

namespace UnfoundedOptimism.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UnfoundedOptimism.Models.Wine> Wine { get; set; } = default!;
    }
}