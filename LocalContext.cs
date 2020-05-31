using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_Models;
namespace EF_Migration
{
    public class LocalContext : DbContext
    {
        public virtual DbSet<Student> student { get; set; }
        public virtual DbSet<Standard> standard { get; set; }
        public LocalContext() : base(ConfigurationSettings.AppSettings.Get("DatabaseLink").ToString())
        // public LocalContext() : base("name=SchoolDBConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LocalContext, DBMigration>());
        } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
