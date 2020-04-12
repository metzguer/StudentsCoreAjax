using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAjax.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options):base(options) 
        {
        
        }

        public DbSet<Category> Categories { get; set; }
    }
}
