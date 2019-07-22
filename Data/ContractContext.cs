using ContractingApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace ContractingApp.Data
{
    public class ContractContext : DbContext
    {
        public ContractContext(DbContextOptions<ContractContext> options) : base(options)
        {

        }

        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Provider> Providers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>().ToTable("Contract");
            modelBuilder.Entity<Provider>().ToTable("Provider");
        }
    }
}
