using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryFurniture.Data
{
    /// <summary>
    /// Реализация базового объекта
    /// </summary>
    public class BaseObject : IBaseObject
    {
        protected BaseObject()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}
