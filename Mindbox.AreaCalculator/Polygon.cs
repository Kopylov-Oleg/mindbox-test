using System;
using System.Collections.Generic;
using System.Linq;

namespace Mindbox.AreaCalculator
{
    /// <summary>
    /// Представляет собой многогранник
    /// </summary>
    public record Polygon : Shape
    {
        //Нужен ли класс Polygon, или делать каким-то ещё из многих способов организации
        // структуры классов фигур? Спецификация не известна, предполагаю, что в произвольный
        // момент нужно будет добавить реализацию произвольных многоулгольных фигур,
        // но не произовольных овалов и прочего.

        internal Polygon(IEnumerable<double> edges)
        {
            if(!IsCorrectPolygon(edges))
            {
                throw new ArgumentException(String.Format("{0} do not make a polygon", nameof(edges)),
                                      nameof(edges));
            }

            Edges = edges.ToList();
        }

        // Если добавить в Edges set, то его нужно будет переопределить в Triangle для сортировки
        /// <summary>
        /// Грани многогранника.
        /// </summary>
        public virtual IList<double> Edges { get; }

        protected override double CalculateArea()
        {
            // Не требуется в тестовом задании, недостаточно знать только стороны,
            //  нужны углы (или, возможно, лучше координаты)
            throw new NotImplementedException();
        }

        protected static bool IsCorrectPolygon(IEnumerable<double> edges)
        {
            if(!edges.All(x => x > 0))
            {
                return false;
            }

            var edgesSum = edges.Sum(x => x);
            var maxEdge = edges.Max(x => x);

            // В многоугольнике длина наибольшей стороны должна быть меньше,
            //  чем сумма всех других сторон
            return (edgesSum - maxEdge) > maxEdge;
        }
    }
}
