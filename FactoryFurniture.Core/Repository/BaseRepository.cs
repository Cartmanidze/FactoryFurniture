using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryFurniture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FactoryFurniture.Core.Repository
{
    /// <summary>
    /// Реализация репозитория для контекста FurnitureContext
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности</typeparam>
    /// <typeparam name="TContext">Тип контекста</typeparam>
    /// <typeparam name="TContextFactory">Тип фабрики контекста</typeparam>
    public abstract class BaseRepository<TEntity, TContext, TContextFactory> : IRepository<TEntity>
        where TEntity : BaseObject
        where TContext : DbContext
        where TContextFactory : IDesignTimeDbContextFactory<TContext>
    {
        private readonly TContextFactory _factoryContext;
        protected BaseRepository(TContextFactory factoryContext)
        {
            _factoryContext = factoryContext;
        }
        public void Add(TEntity item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var context = CreateContext();
            context.Set<TEntity>().Add(item);
            context.SaveChanges();
        }

        public void Add(ICollection<TEntity> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            using var context = CreateContext();
            context.Set<TEntity>().AddRange(items);
            context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var context = CreateContext();
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Update(ICollection<TEntity> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            using var context = CreateContext();
            foreach (var item in items)
            {
                context.Entry(item).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void Delete(TEntity item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var context = CreateContext();
            context.Set<TEntity>().Remove(item);
            context.SaveChanges();
        }

        public void Delete(ICollection<TEntity> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            using var context = CreateContext();
            context.Set<TEntity>().RemoveRange(items);
            context.SaveChanges();
        }

        public TEntity FindById(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            if (!Guid.TryParse(id, out Guid result))
                throw new ArgumentException("Был передан некорректный идентификатор");
            using var context = CreateContext();
            return context.Set<TEntity>().Find(result);
        }

        public IEnumerable<TEntity> Get()
        {
            using var context = CreateContext();
            return context.Set<TEntity>().ToList();
        }

        public async Task<TEntity> AddAsync(TEntity item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var context = CreateContext();
            context.Set<TEntity>().Add(item);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return item;
        }

        public async Task<ICollection<TEntity>> AddAsync(ICollection<TEntity> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            using var context = CreateContext();
            context.Set<TEntity>().AddRange(items);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return items;
        }

        public async Task<TEntity> UpdateAsync(TEntity item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var context = CreateContext();
            context.Entry(item).State = EntityState.Modified;
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return item;
        }

        public async Task<ICollection<TEntity>> UpdateAsync(ICollection<TEntity> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            using var context = CreateContext();
            foreach (var item in items)
            {
                context.Entry(item).State = EntityState.Modified;
            }
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return items;
        }

        public async Task<TEntity> DeleteAsync(TEntity item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            using var context = CreateContext();
            context.Set<TEntity>().Remove(item);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return item;
        }

        public async Task<ICollection<TEntity>> DeleteAsync(ICollection<TEntity> items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            using var context = CreateContext();
            context.Set<TEntity>().RemoveRange(items);
            await context.SaveChangesAsync()
                .ConfigureAwait(false);
            return items;
        }

        public async Task<TEntity> FindByIdAsync(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            if (!Guid.TryParse(id, out Guid result))
                throw new ArgumentException("Был передан некорректный идентификатор");
            using var context = CreateContext();
            return await context.Set<TEntity>().FindAsync(result)
                .ConfigureAwait(false);
        }

        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            using var context = CreateContext();
            return await context.Set<TEntity>()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        private TContext CreateContext()
        {
            return _factoryContext.CreateDbContext(new[] {string.Empty});
        }

    }
}
