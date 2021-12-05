using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCRUD.Models
{
    public class WebApplicationCRUDContext : DbContext
    {
        public WebApplicationCRUDContext (DbContextOptions<WebApplicationCRUDContext> options)
            : base(options)
        {
        }

             

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
