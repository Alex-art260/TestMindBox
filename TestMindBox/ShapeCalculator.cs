using System;

namespace ShapeLibrary
{
    //1 задание
    public class ShapeCalculator
    {
        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        //проверка, является ли треугольник прямоугольным
        public bool IsRightTriangle(double side1, double side2, double side3)
        {
            double hypotenuse = Math.Max(side1, Math.Max(side2, side3));
            double sumOfSquares = 0;

            foreach (double side in new double[] { side1, side2, side3 })
            {
                if (side != hypotenuse)
                {
                    sumOfSquares += side * side;
                }
            }

            return (hypotenuse * hypotenuse == sumOfSquares);
        }
    }
}

   // 2 задание

    /*SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName,
    c.CategoryName;*/
}