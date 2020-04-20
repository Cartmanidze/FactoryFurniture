using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FactoryFurniture.Core.Storage
{
    /// <summary>
    /// Реализация интерфейса IDesignTimeDbContextFactory для иниицализации миграции 
    /// </summary>
    public class FurnitureContextFactory : IDesignTimeDbContextFactory<FurnitureContext>
    {
        private readonly string _connectionString;

        public FurnitureContextFactory()
        {
        }

        public FurnitureContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public FurnitureContext CreateDbContext(string[] args)
        {
            string connString = _connectionString;

            if (args.Length > 0 && !string.IsNullOrEmpty(args[0]))
            {
                connString = args[0];
            }

            var builder = new DbContextOptionsBuilder<FurnitureContext>();
            builder.UseSqlServer(connString);
            return new FurnitureContext(builder.Options);
        }
    }
}
