using System;

namespace DemoMVP.Models
{
    public class CircleModel : ICircleModel
    {
        public double GetArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}