using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FactoryFurniture.Core.Storage
{
    /// <summary>
    /// Реализацтя интерфейса IDesignTimeDbContextFactory для иниицализации миграции 
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
            string connString;

            if (!string.IsNullOrEmpty(_connectionString))
            {
                connString = _connectionString;
            }

            else if (args.Length > 0 && !string.IsNullOrEmpty(args[0]))
            {
                connString = args[0];
            }

            else
            {
                connString = "Integrated Security=SSPI;Pooling=false;Data Source=DESKTOP-AMECNM0\\SQLEXPRESS;Initial Catalog=FurnitureFactory";
                // дефолтная строка подключения для инициализации миграции в Core
            }

            var builder = new DbContextOptionsBuilder<FurnitureContext>();
            builder.UseSqlServer(connString);
            return new FurnitureContext(builder.Options);
        }
    }
}
