using Microsoft.EntityFrameworkCore;
using Webtest.Models;

namespace Webtest.Context
{
    public class MVCContext: DbContext
    {
        public MVCContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
