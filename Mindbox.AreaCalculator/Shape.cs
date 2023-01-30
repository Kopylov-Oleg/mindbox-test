namespace Mindbox.AreaCalculator
{
    /* Предполагаем, что фигуры во течение их жизни изменять не надо - имеет смысл фигуры делать record */
    /* Обычно в таких заданиях фигруы имеют координаты, но об их необходимости не заявлено. */
    /// <summary>
    /// Представляет собой произвольную геометрическую фигуру.
    /// </summary>
    public abstract record Shape
    {
        /// <summary>
        /// Площадь фигуры.
        /// </summary>
        public double Area => CalculateArea();

        protected abstract double CalculateArea();
    }
}
