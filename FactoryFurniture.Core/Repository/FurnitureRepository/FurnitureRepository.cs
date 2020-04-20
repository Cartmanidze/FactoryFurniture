using FactoryFurniture.Core.Storage;
using FactoryFurniture.Data;

namespace FactoryFurniture.Core.Repository.FurnitureRepository
{
    /// <summary>
    /// Реализация репозитория для таблицы Furniture 
    /// </summary>
    public class FurnitureRepository : BaseRepository<Furniture, FurnitureContext, FurnitureContextFactory>
    {
        public FurnitureRepository(FurnitureContextFactory factoryContext) : base(factoryContext)
        {
        }
    }
}
