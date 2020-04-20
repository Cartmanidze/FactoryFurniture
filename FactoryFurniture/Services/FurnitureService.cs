using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FactoryFurniture.Core.Repository.FurnitureRepository;
using FactoryFurniture.Data;
using Microsoft.Extensions.Logging;

namespace FactoryFurniture.Services
{
    public class FurnitureService
    {
        private readonly FurnitureRepository _repository;

        private readonly ILogger _logger;
        public FurnitureService(FurnitureRepository repository, ILogger<FurnitureService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        /// <summary>
        /// Получает всю мебель
        /// </summary>
        /// <returns>Коллекция мебели</returns>
        public async Task<IEnumerable<Furniture>> GetAll()
        {
            try
            {
                return await _repository.GetAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }

        /// <summary>
        /// Создание новой мебели
        /// </summary>
        /// <param name="furniture">Мебель</param>
        /// <returns>Мебель</returns>
        public async Task<Furniture> CreateFurniture(Furniture furniture)
        {
            try
            {
                return await _repository.AddAsync(furniture);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }

        /// <summary>
        /// Обновление мебели
        /// </summary>
        /// <param name="furniture">Мебель</param>
        /// <returns>Мебель</returns>
        public async Task<Furniture> Update(Furniture furniture)
        {
            try
            {
                return await _repository.UpdateAsync(furniture);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
            
        }

        /// <summary>
        /// Получить мебель по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Мебель</returns>
        public async Task<Furniture> GetById(string id)
        {
            try
            {
                return await _repository.FindByIdAsync(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }

        /// <summary>
        /// Удаление мебели
        /// </summary>
        /// <param name="furniture">Мебель</param>
        /// <returns>Мебель</returns>
        public void Delete(Furniture furniture)
        {
            try
            { 
                _repository.Delete(furniture);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }
    }
}
