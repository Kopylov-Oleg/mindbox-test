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
            if(!IsCorrectCircle(radius))
            {
                throw new ArgumentException(String.Format("{0} does not make a circle", nameof(radius)),
                                      nameof(radius));
            }
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

        protected static bool IsCorrectCircle(double radius) 
            => radius > 0;
    }
}
