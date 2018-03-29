using OderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OderingSystem.Context
{
    public class ShuNiuContext : DbContext
    {
        public ShuNiuContext() : base("name=ShuNiuContext")
        {
        }

        public DbSet<AccountEntry> Accounts { get; set; }
        public DbSet<RoleEntry> Roles { get; set; }
    }
}