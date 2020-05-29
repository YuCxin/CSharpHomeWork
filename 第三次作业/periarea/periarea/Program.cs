using System;

namespace periarea
{
    public interface IArea
    {
        double Area();
    }
    public class Rectangle : IArea
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Rectangle(double x,double y)
        {
            X = x;
            Y = y;
        }      
        public double Area()
        {            
                return X * Y;
        }
    }
    public class Square : IArea
    {
        public double X { get; set; }
        public Square(double x)
        {
            X = x;            
        }
        public double Area()
        {
            return X * X;
        }
    }
    public class Triangle : IArea
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Triangle(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public double Area()
        {
            if(X+Y>Z&&Y+Z>X&&X+Z>Y)
            { 
                double p = (X + Y + Z) / 2;
            return Math.Sqrt(p*(p - X)*(p-Y)*(p-Z));
            }
            else
            {
                Console.WriteLine("不合法的三角形。");
                return 0;
            }
        }
    }
    class Program
    {
        public static double FromArea(IArea re)
        {
            return re.Area();
        }
        static void Main()
        {            
            Console.WriteLine("请输入正方形的边长：");
            double r = double.Parse(Console.ReadLine());
            Square s = new Square(r);
            Console.WriteLine("边长为{0}的正方形面积为：{1}", s.X, FromArea(s));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("请输入长方形的边长1：");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入长方形的边长2：");
            double w = double.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(a, w);
            Console.WriteLine("边长为{0}和{1}的矩形面积为：{2}", rec.X, rec.Y, FromArea(rec));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("请输入三角形边长1：");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入三角形边长2：");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入三角形边长3：");
            double z = double.Parse(Console.ReadLine());
            Triangle t = new Triangle(x,y,z);
            Console.WriteLine("边长为{0},{1},{2}的三角形形面积为：{3}", t.X, t.Y,t.Z, FromArea(t));
            Console.ReadKey();

        }
    }
}
