using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    public class GeometricShapeExample
    {
        public static void Use()
        {
            ShapesFactory shapesFactory = new ShapesFactory();

            shapesFactory.AddShape(new CircleFactory().CreateShape());
            shapesFactory.AddShape(new SquareFactory().CreateShape());
            shapesFactory.AddShape(new RecangleFactory().CreateShape());
        }
    }

    abstract class Shape 
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Square : Shape
    {
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

    class Circle : Shape
    {
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }

    interface IShapeFactory
    {
        Shape CreateShape();
    }

    class RecangleFactory : IShapeFactory
    {
        public Shape CreateShape()
        {
            throw new NotImplementedException();
        }
    }

    class CircleFactory : IShapeFactory
    {
        public Shape CreateShape()
        {
            throw new NotImplementedException();
        }
    }
    class SquareFactory : IShapeFactory
    {
        public Shape CreateShape()
        {
            throw new NotImplementedException();
        }
    }

    class ShapesFactory
    {
        private List<Shape> _shapes;

        public ShapesFactory()
        {
            _shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
        }

    }

}
