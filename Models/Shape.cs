using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeCalculator.Models
{

    public interface Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}

