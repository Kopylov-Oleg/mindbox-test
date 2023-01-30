using System;
using System.Collections.Generic;
using Xunit;

namespace Mindbox.AreaCalculator.UnitTest
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void GetCircleAreaNormal()
        {
            double radius = 50;
            var circle = new ShapeFactory().CreateCircle(radius);

            double area = circle.Area;

            Assert.Equal(Math.PI * radius * radius, area);
        }

        [Fact]
        public void GetCircleAreaShape()
        {
            double radius = 50;
            var circle = new ShapeFactory().Create(ShapeType.Circle, new List<double>() { radius });

            double area = circle.Area;

            Assert.Equal(Math.PI * radius * radius, area);
        }

        [Fact]
        public void GetTriangleAreaNormal()
        {
            var edges = new List<double>() { 5, 5, 6 };
            var circle = new ShapeFactory().CreatePolygon(edges);

            double area = circle.Area;

            Assert.Equal(12, area);
        }

        [Fact]
        public void GetTriangleAreaShape()
        {
            var edges = new List<double>() { 5, 5, 6 };
            var circle = new ShapeFactory().Create(ShapeType.Polygon, edges);

            double area = circle.Area;

            Assert.Equal(12, area);
        }

        [Fact]
        public void GetRightTriangleAreaNormal()
        {
            var edges = new List<double>() { 3, 4, 5 };
            var circle = new ShapeFactory().CreatePolygon(edges);

            double area = circle.Area;

            Assert.Equal(6, area);
        }

        [Fact]
        public void GetRightTriangleAreaShape()
        {
            var edges = new List<double>() { 3, 4, 5 };
            var circle = new ShapeFactory().Create(ShapeType.Polygon, edges);

            double area = circle.Area;

            Assert.Equal(6, area);
        }
    }
}