namespace FactoryFurniture.Data
{
    /// <summary>
    ///  Объект мебели
    /// </summary>
    public interface IFurniture : IBaseObject
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        string Price { get; set; }
    }
}
