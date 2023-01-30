using System;
using System.Collections.Generic;
using Xunit;

namespace Mindbox.AreaCalculator.UnitTest
{
    public class TriangleTests
    {
        [Fact]
        public void Area_NormalTriangleThroughCreatePolygon_ReturnsArea()
        {
            var edges = new List<double>() { 5, 5, 6 };
            var triangle = new ShapeFactory().CreatePolygon(edges);

            double area = triangle.Area;

            Assert.Equal(12, area);
        }

        [Fact]
        public void Area_IncorrectTriangleThroughCreatePolygon_Throws()
        {
            var edges = new List<double>() { 5, 5, 10 };
            var shapeFactory = new ShapeFactory();

            Assert.Throws<ArgumentException>(() => shapeFactory.CreatePolygon(edges));
        }

        [Fact]
        public void Area_ZeroTriangleThroughCreatePolygon_Throws()
        {
            var edges = new List<double>() { 5, 0, 6 };
            var shapeFactory = new ShapeFactory();

            Assert.Throws<ArgumentException>(() => shapeFactory.CreatePolygon(edges));
        }

        [Fact]
        public void Area_NegativeTriangleThroughCreatePolygon_Throws()
        {
            var edges = new List<double>() { -1, 5, 6 };
            var shapeFactory = new ShapeFactory();

            Assert.Throws<ArgumentException>(() => shapeFactory.CreatePolygon(edges));
        }

        [Fact]
        public void Area_RightAngledTriangleThroughCreate_ReturnsArea()
        {
            var edges = new List<double>() { 3, 4, 5 };
            var triangle = new ShapeFactory().Create(ShapeType.Polygon, edges);

            double area = triangle.Area;

            Assert.Equal(6, area);
        }

        [Fact]
        public void Area_IncorrectTriangleThroughCreate_Throws()
        {
            var edges = new List<double>() { 3, 4, 7 };
            var shapeFactory = new ShapeFactory();
            var triangleShapeType = ShapeType.Polygon;

            Assert.Throws<ArgumentException>(() => shapeFactory.Create(triangleShapeType, edges));
        }

        [Fact]
        public void Area_ZeroTriangleThroughCreate_Throws()
        {
            var edges = new List<double>() { 3, 0, 5 };
            var shapeFactory = new ShapeFactory();
            var triangleShapeType = ShapeType.Polygon;

            Assert.Throws<ArgumentException>(() => shapeFactory.Create(triangleShapeType, edges));
        }

        [Fact]
        public void Area_NegativeTriangleThroughCreate_Throws()
        {
            var edges = new List<double>() { -1, 4, 5 };
            var shapeFactory = new ShapeFactory();
            var triangleShapeType = ShapeType.Polygon;

            Assert.Throws<ArgumentException>(() => shapeFactory.Create(triangleShapeType, edges));
        }
    }
}
