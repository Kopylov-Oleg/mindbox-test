using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.AreaCalculator
{
    /// <summary>
    /// Представляет собой треуголник.
    /// </summary>
    public record Triangle : Polygon
    {
        const int numberOfEdges = 3;
        // Edges для треугольника хранятся отсортированными по возрастанию

        // другие конструкторы по необходимости
        internal Triangle(IEnumerable<double> edges)
            : base(edges
                    .OrderBy(x => x)
                    .ToList())
        {
            if (!IsTriangle(edges))
            {
                throw new ArgumentException(String.Format("{0} do not make a triangle", nameof(edges)),
                                      nameof(edges));
            }
        }

        internal static bool IsTriangle(IEnumerable<double> edges)
        {
            if (edges == null)
            {
                throw new ArgumentNullException(nameof(edges));
            }

            return edges.Count() == numberOfEdges;
        }

        internal bool IsRightAngled()
        {
            // a^2 + b^2 = c^2 where c>a, c>b
            // (c-a)(c+a) = b^2

            return (Edges[2] - Edges[0])
                * (Edges[2] + Edges[0])
                == Edges[1] * Edges[1];
        }

        protected override double CalculateArea()
        {
            if (IsRightAngled())
            {
                return Edges[0] * Edges[1] / 2;
            }

            // это можно сделать циклами, но ухудшается читаемость, не видно формулу
            var semiPerimeter = (Edges[0] + Edges[1] + Edges[2]) / 2;
            var area = Math.Sqrt(semiPerimeter
                * (semiPerimeter - Edges[0])
                * (semiPerimeter - Edges[1])
                * (semiPerimeter - Edges[2]));

            return area;
        }
    }
}
