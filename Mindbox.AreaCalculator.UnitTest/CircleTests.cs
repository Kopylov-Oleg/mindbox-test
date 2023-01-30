using System;
using System.Collections.Generic;
using Xunit;

namespace Mindbox.AreaCalculator.UnitTest
{
    public class CircleTests
    {
        [Fact]
        public void Area_NormalCircleThroughCreateCircle_ReturnsArea()
        {
            double radius = 50;
            var circle = new ShapeFactory().CreateCircle(radius);

            double area = circle.Area;

            Assert.Equal(Math.PI * radius * radius, area);
        }

        [Fact]
        public void Area_ZeroCircleThroughCreateCircle_Throws()
        {
            double radius = 0;
            var shapeFactory = new ShapeFactory();

            Assert.Throws<ArgumentException>(() => shapeFactory.CreateCircle(radius));
        }

        [Fact]
        public void Area_NegativeCircleThroughCreateCircle_Throws()
        {
            double radius = -1;
            var shapeFactory = new ShapeFactory();

            Assert.Throws<ArgumentException>(() => shapeFactory.CreateCircle(radius));
        }

        [Fact]
        public void Area_NormalCircleThroughCreate_ReturnsArea()
        {
            double radius = 50;
            var circle = new ShapeFactory().Create(ShapeType.Circle, new List<double>() { radius });

            double area = circle.Area;

            Assert.Equal(Math.PI * radius * radius, area);
        }

        [Fact]
        public void Area_ZeroCircleThroughCreate_Throws()
        {
            double radius = 0;
            var circleArguments = new List<double>() { radius };
            var shapeFactory = new ShapeFactory();
            var circleShapeType = ShapeType.Circle;

            Assert.Throws<ArgumentException>(() => shapeFactory.Create(circleShapeType, circleArguments));
        }

        [Fact]
        public void Area_NegativeCircleThroughCreate_Throws()
        {
            double radius = -1;
            var circleArguments = new List<double>() { radius };
            var shapeFactory = new ShapeFactory();
            var circleShapeType = ShapeType.Circle;

            Assert.Throws<ArgumentException>(() => shapeFactory.Create(circleShapeType, circleArguments));
        }
    }
}