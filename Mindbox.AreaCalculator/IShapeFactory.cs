using System.Collections.Generic;

namespace Mindbox.AreaCalculator
{ 
    /* возможно, какие методы и не нужны */
    /* не зная, для чего пишется код, сложно реализовать его "как надо"  */
    /// <summary>
    /// Интерфейс фабрики для создания геометрических фигур.
    /// </summary>
    public interface IShapeFactory
    {
        /// <summary>
        /// Создаёт произвольную геометрическую фигуру.
        /// </summary>
        /// <param name="shapeType">Тип фигуры.</param>
        /// <param name="arguments"></param>
        /// <returns>Готовая фигура.</returns>
        public abstract Shape Create(ShapeType shapeType, IEnumerable<double> arguments);

        /// <summary>
        /// Создаёт круг.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Готовый круг.</returns>
        public abstract Circle CreateCircle(double radius);

        /// <summary>
        /// Создаёт многогранник.
        /// </summary>
        /// <param name="edges">Длины сторон многогранника.</param>
        /// <returns>Готовый многогранник</returns>
        public abstract Polygon CreatePolygon(IEnumerable<double> edges);
    }
}
