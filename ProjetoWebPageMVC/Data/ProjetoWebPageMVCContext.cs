using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWebPageMVC.Models;

namespace ProjetoWebPageMVC.Data
{
    public class ProjetoWebPageMVCContext : DbContext
    {
        public ProjetoWebPageMVCContext(DbContextOptions<ProjetoWebPageMVCContext> options)
            : base(options)
        {

        }

        public DbSet<ProjetoWebPageMVC.Models.Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
