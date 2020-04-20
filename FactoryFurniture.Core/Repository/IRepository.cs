using System.Collections.Generic;
using System.Threading.Tasks;
using FactoryFurniture.Data;

namespace FactoryFurniture.Core.Repository
{
    /// <summary>
    /// Описание репозитория
    /// </summary>
    /// <typeparam name="TEntity">Тип сущностои репозитория</typeparam>
    public interface IRepository<TEntity>
        where TEntity : BaseObject
    {
        /// <summary>
        /// Добавление элемент в БД
        /// </summary>
        /// <param name="item">Элемент сущности</param>
        void Add(TEntity item);

        /// <summary>
        /// Добавление коллекции в БД
        /// </summary>
        /// <param name="items">Элемент сущности</param>
        void Add(ICollection<TEntity> items);

        /// <summary>
        /// Удаление из БД
        /// </summary>
        /// <param name="item">Сущность</param>
        void Delete(TEntity item);

        /// <summary>
        /// Удаление из БД коллекции
        /// </summary>
        /// <param name="items">Сущность</param>
        void Delete(ICollection<TEntity> items);

        /// <summary>
        /// Обновление в БД
        /// </summary>
        /// <param name="item">Сущность</param>
        void Update(TEntity item);

        /// <summary>
        /// Удаление из БД коллекции
        /// </summary>
        /// <param name="items">Сущность</param>
        void Update(ICollection<TEntity> items);

        /// <summary>
        /// Поиск по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Сущность</returns>
        TEntity FindById(string id);

        /// <summary>
        /// Получение сущностей
        /// </summary>
        /// <returns>Коллекция сущностей</returns>
        IEnumerable<TEntity> Get();

        /// <summary>
        /// Добавление элемент в БД
        /// </summary>
        /// <param name="item">Элемент сущности</param>
        Task<TEntity> AddAsync(TEntity item);

        /// <summary>
        /// Добавление коллекции в БД
        /// </summary>
        /// <param name="items">Элемент сущности</param>
        Task<ICollection<TEntity>> AddAsync(ICollection<TEntity> items);

        /// <summary>
        /// Удаление из БД
        /// </summary>
        /// <param name="item">Сущность</param>
        Task<TEntity> DeleteAsync(TEntity item);

        /// <summary>
        /// Удаление из БД коллекции
        /// </summary>
        /// <param name="items">Сущность</param>
        Task<ICollection<TEntity>> DeleteAsync(ICollection<TEntity> items);

        /// <summary>
        /// Обновление в БД
        /// </summary>
        /// <param name="item">Сущность</param>
        Task<TEntity> UpdateAsync(TEntity item);

        /// <summary>
        /// Удаление из БД коллекции
        /// </summary>
        /// <param name="items">Сущность</param>
        Task<ICollection<TEntity>> UpdateAsync(ICollection<TEntity> items);

        /// <summary>
        /// Поиск по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Сущность</returns>
        Task<TEntity> FindByIdAsync(string id);

        /// <summary>
        /// Получение сущностей
        /// </summary>
        /// <returns>Коллекция сущностей</returns>
        Task<IEnumerable<TEntity>> GetAsync();

    }
}
