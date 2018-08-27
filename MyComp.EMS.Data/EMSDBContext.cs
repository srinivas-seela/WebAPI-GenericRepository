using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyComp.EMS.Data.Entities;

namespace MyComp.EMS.Data
{
    public class EMSDBContext : DbContext
    {
        public EMSDBContext()
        {

        }
        public virtual DbSet<Vertical> Verticals { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("VarChar"));
            modelBuilder.Properties<Int16>()
                .Configure(p => p.HasColumnType("smallint"));
        }
    }
}
