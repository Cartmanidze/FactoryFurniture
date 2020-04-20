namespace FactoryFurniture.Data
{
    /// <summary>
    /// Реализация объекта мебели
    /// </summary>
    public class Furniture : BaseObject, IFurniture
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
