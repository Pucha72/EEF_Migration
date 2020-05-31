using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Migration
{
    internal sealed class DBMigration : DbMigrationsConfiguration<LocalContext>
    {

        public DBMigration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "LocalContext";
            AutomaticMigrationDataLossAllowed = true;
        }
        protected override void Seed(LocalContext context)
        {

        }
    }
}
