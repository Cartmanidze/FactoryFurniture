using System.Linq;
using FactoryFurniture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryFurniture.Core.Storage
{
    /// <summary>
    /// Контекст данных мебели
    /// </summary>
    public class FurnitureContext : DbContext
    {
        public FurnitureContext() { }
        public FurnitureContext(DbContextOptions<FurnitureContext> options) : base(options) { }

        /// <summary>
        /// Мебель
        /// </summary>
        public DbSet<Furniture> Furniture { get; set; }


        public void MigrateDb(string migrationName = null)
        {
            var migrate = Database.GetInfrastructure().GetRequiredService<IMigrator>();
            if (!AllowMigrate()) return;
            switch (string.IsNullOrEmpty(migrationName))
            {
                case true:
                    migrate.Migrate();
                    break;
                case false:
                    migrate.Migrate(migrationName);
                    break;
            }
        }

        private bool AllowMigrate()
        {
            return Database.GetMigrations().Count() != Database.GetAppliedMigrations().Count();
        }
    }
}
