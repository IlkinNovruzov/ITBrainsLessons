namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task2
        //Square square = new Square(10);
        //Rectangle rec = new Rectangle(10, 20);
        //Triangle tri = new Triangle(8, 6, 11);
        //Circle circle = new Circle(5);
        //Console.WriteLine("Square area:" + square.CalculateArea());
        //Console.WriteLine("Square perimet:" + square.CalculatePerimetr());
        //Console.WriteLine("Rectangle perimetr:" + rec.CalculatePerimetr());
        //Console.WriteLine("Rectangle area:" + rec.CalculateArea());
        //Console.WriteLine("Triangle area:" + tri.CalculateArea());
        //Console.WriteLine("Triangle perimetr:" + tri.CalculatePerimetr());
        //Console.WriteLine("Circle perimetr:" + circle.CalculatePerimetr());
        //Console.WriteLine("Circle area:" + circle.CalculateArea()); 
        #endregion
        Calculator calculator = new Calculator();
        double sum = calculator.Difference(10, 5);
        Console.WriteLine(sum);
        }
       


        
    public class Student
    {
        public string name { get; }
        public string surname { get; }
        public int age { get; }
        private static int counter = 0;


        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            counter++;

        }
        public static int Count()
        {
            return counter;
        }

    }
    interface ISum
    {
        double Sum(params double[] numbers);
    }
    interface IMultiply
    {
        double Multiply(params double[] numbers);
    }
    interface IDifference
    {
        double Difference(params double[] numbers);
    }
    interface IDivide
    {
        double Divide(params double[] numbers);
    }
    public class Calculator : ISum, IMultiply, IDivide, IDifference
    {


        public double Sum(params double[] numbers)
        {
            double sum = 0;
            foreach (double item in numbers)
            {
                sum += item;
            }
            return sum;
        }
        public double Multiply(params double[] numbers)
        {
            double multiplied = 1;
            foreach (double item in numbers)
            {
                multiplied *= item;
            }
            return multiplied;
        }
        public double Divide(params double[] numbers)
        {
            double divide = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    divide /= numbers[i];
                }
            }
            return divide;
        }
        public double Difference(params double[] numbers)
        {
            double dif = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    dif -= numbers[i];
                }
            }
            return dif;
        }
    }
    interface IFigure
    {
        double CalculateArea();
        double CalculatePerimetr();
    }
    public class Rectangle : IFigure
    {
        public double a { get; set; }
        public double b { get; set; }

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double CalculateArea()
        {
            double area = a * b;
            return area;
        }
        public double CalculatePerimetr()
        {
            double perimetr = 2 * (a + b);
            return perimetr;
        }
    }
    public class Circle : IFigure
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            double area = Math.Round((radius * radius * Math.PI), 3);
            return area;
        }
        public double CalculatePerimetr()
        {
            double length = Math.Round((2 * radius * Math.PI), 3);
            return length;
        }
    }
    public class Square : IFigure
    {
        public double a { get; set; }

        public Square(double a)
        {
            this.a = a;
        }

        public double CalculateArea()
        {
            double area = a * a;
            return area;
        }
        public double CalculatePerimetr()
        {
            double perimetr = 4 * a;
            return perimetr;
        }
    }
    public class Triangle : IFigure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double CalculateArea()
        {
            double h = CalculatePerimetr() / 2;
            double area = Math.Sqrt(h * (h - a) * (h - b) * (h - c));
            return area;
        }
        public double CalculatePerimetr()
        {
            double perimetr = a + b + c;
            return perimetr;
        }
    }
}
}