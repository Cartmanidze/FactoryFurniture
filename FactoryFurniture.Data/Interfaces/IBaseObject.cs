using System;

namespace FactoryFurniture.Data
{
    /// <summary>
    /// Интерфейс базового объекта
    /// </summary>
    public interface IBaseObject
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        Guid Id { get; set; }
    }
}
