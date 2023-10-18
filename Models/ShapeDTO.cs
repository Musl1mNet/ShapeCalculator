using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeCalculator.Models
{
    public class ShapeDTO
    {
        public string Figure { get; set; } = default!;
        public double[] Params { get; set; } = default!;
    }
}