using System;

namespace lb3
{
    public abstract class Figure
    {
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
        public abstract string GetInfo();
        public abstract void Draw();
    }

    public class Circle : Figure
    {
        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area => Math.PI * radius * radius;

        public override double Perimeter => 2 * Math.PI * radius;

        public override string GetInfo()
        {
            return $"Це коло. Радіус: {radius}";
        }

        public override void Draw()
        {
            Console.WriteLine($"Малюю коло з радіусом {radius}:");
            Console.WriteLine("      * * * *");
            Console.WriteLine("    *         *");
            Console.WriteLine("   *           *");
            Console.WriteLine("  *             *");
            Console.WriteLine("   *           *");
            Console.WriteLine("    *         *");
            Console.WriteLine("      * * * *");
        }
    }

    public class Cylinder : Circle
    {
        private double height;

        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }

        public override double Area => 2 * Math.PI * radius * (radius + height);

        public override double Perimeter => 2 * Math.PI * radius;

        public override string GetInfo()
        {
            return $"Це циліндр. Радіус: {radius}, Висота: {height}";
        }

        public override void Draw()
        {
            Console.WriteLine($"Малюю циліндр з радіусом {radius} і висотою {height}:");
            Console.WriteLine(new string(' ', (int)radius) + new string('#', (int)(radius * 2)));
            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine(new string(' ', (int)radius) + "#" + new string(' ', (int)(radius * 2 - 2)) + "#");
            }
            Console.WriteLine(new string(' ', (int)radius) + new string('#', (int)(radius * 2)));
        }
    }

    public class Torus : Circle
    {
        private double innerRadius;

        public Torus(double radius, double innerRadius) : base(radius)
        {
            this.innerRadius = innerRadius;
        }

        public override double Area => 4 * Math.PI * innerRadius * radius;

        public override double Perimeter => 2 * Math.PI * (innerRadius + radius);

        public override string GetInfo()
        {
            return $"Це тор. Радіус: {radius}, Внутрішній радіус: {innerRadius}";
        }

        public override void Draw()
        {
            Console.WriteLine($"Малюю тор з радіусом {radius} і внутрішнім радіусом {innerRadius}:");
            Console.WriteLine("                    ");
            Console.WriteLine("    ############    ");
            Console.WriteLine("  ##    #####    ##  ");
            Console.WriteLine("##    #       #   ##");
            Console.WriteLine("#   #           #   #");
            Console.WriteLine("#   #           #   #");
            Console.WriteLine("##    #       #   ##");
            Console.WriteLine("  ##    #####    ##  ");
            Console.WriteLine("    ############    ");
            Console.WriteLine("                    ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[3];
            figures[0] = new Circle(5);
            figures[1] = new Cylinder(3, 7);
            figures[2] = new Torus(10, 4);

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.GetInfo());
                Console.WriteLine("Площа: " + figure.Area);
                Console.WriteLine("Периметр: " + figure.Perimeter);
                Console.WriteLine("Малюю фігуру:");
                figure.Draw();
                Console.WriteLine();
            }
        }
    }
}
