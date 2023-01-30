using System;

namespace Mindbox.AreaCalculator
{
    /// <summary>
    /// Представляет собой круг.
    /// </summary>
    public record Circle : Shape
    {
        internal Circle(double radius) 
        {
            Radius = radius;
        }

        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Диаметр круга.
        /// </summary>
        public double Diameter
        {
            get => 2 * Radius;
        }

        protected override double CalculateArea()
            => Math.PI * Radius * Radius;
    }
}
