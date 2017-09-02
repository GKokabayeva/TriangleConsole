using System;

namespace S12_04
{
    class Triangle
    {
        private decimal sideA;
        private decimal sideB;
        private decimal sideC;

        public Triangle()
        {
            TriangleSide triangle = new TriangleSide();

            Console.Write("\nPlease, enter a side 'a' of the triangle: ");
            triangle.EnterSide(2);
            this.sideA = triangle.Side > 0 ? triangle.Side : triangle.Side * -1;

            Console.Write("Please, enter a side 'b' of the triangle: ");
            triangle.EnterSide(2);
            this.sideB = triangle.Side > 0 ? triangle.Side : triangle.Side * -1;

            Console.Write("Please, enter a side 'c' of the triangle: ");
            triangle.EnterSide(2);
            this.sideC = triangle.Side > 0 ? triangle.Side : triangle.Side * -1;
        }

        public void CheckForTriangularity()
        {
            if (sideA < sideB + sideC && sideB < sideC + sideA && sideC < sideA + sideB)
            {
                decimal area = GetArea();
                Console.WriteLine($"\nThe AREA of the triangle is S = {area}");

                decimal perimeter = GetPerimeter();
                Console.WriteLine($"The PERIMETER of the triangle is P = {perimeter}");
            }
            else
            {
                Console.WriteLine("\nSorry, it is not a triangle");
            }
        }

        private decimal GetPerimeter()
        {
            return decimal.Round(sideA + sideB + sideC, 4);
        }

        private decimal GetArea()
        {
            decimal halfP = GetPerimeter() / 2;
            return decimal.Round((decimal)Math.Sqrt((double)(halfP * (halfP - sideA) * (halfP - sideB) * (halfP - sideC))), 4);
        }
    }
}
