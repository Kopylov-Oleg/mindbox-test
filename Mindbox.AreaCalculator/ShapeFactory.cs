using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.AreaCalculator
{
    /// <summary>
    /// Фабрики для создания геометрических фигур.
    /// </summary>
    public class ShapeFactory : IShapeFactory
    {
        /// <inheritdoc/>
        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <inheritdoc/>
        public Polygon CreatePolygon(IEnumerable<double> edges)
        {
            var tmp = new Polygon(edges);

            if(Triangle.IsTriangle(tmp.Edges))
            {
                return new Triangle(edges);
            }

            return tmp;
        }

        /// <inheritdoc/>
        public Shape Create(ShapeType shapeType, IEnumerable<double> arguments)
        {
            return shapeType switch
            {
                ShapeType.Circle => new Circle(arguments.First()), // возможно, нужна обработка числа параметров != 1                    
                ShapeType.Polygon => new Polygon(arguments),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
