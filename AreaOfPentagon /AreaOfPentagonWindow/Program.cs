using System;
using System.Globalization;

namespace AreaOfPentagonConsole
{
    class Program
    {
        static void Main()
        {
            // 문화권 상관없이 . 소수점 사용
            var ci = (CultureInfo)CultureInfo.InvariantCulture;

            Console.WriteLine("Area of Pentagon (by triangulation) — .NET 7 Console");
            Console.WriteLine("Enter coordinates for 5 points (x1..x5, y1..y5).");
            Console.WriteLine("Tip: Use decimal point '.' for decimals.\n");

            // 입력 받기
            var p1 = ReadPoint(1, ci);
            var p2 = ReadPoint(2, ci);
            var p3 = ReadPoint(3, ci);
            var p4 = ReadPoint(4, ci);
            var p5 = ReadPoint(5, ci);

            // WinForms 코드 로직을 그대로 반영 (세 개의 삼각형으로 분할)
            double a  = Distance2(p1, p2);
            double b  = Distance2(p1, p3);
            double c  = Distance2(p3, p2);
            double d  = Distance2(p3, p5);
            double f  = Distance2(p5, p2);
            double c2 = Distance2(p3, p2);
            double g  = Distance2(p2, p4);
            double h  = Distance2(p4, p5);
            double i  = Distance2(p5, p2);

            double t1 = AreaOfTriangle(a, b, c);
            double t2 = AreaOfTriangle(d, f, c2);
            double t3 = AreaOfTriangle(g, h, i);
            double area = t1 + t2 + t3;

            Console.WriteLine($"\nArea = {area:0.00}");
        }

        struct Pt { public double X; public double Y; public Pt(double x, double y) { X = x; Y = y; } }

        static Pt ReadPoint(int index, CultureInfo ci)
        {
            double x = ReadDouble($"x{index}", ci);
            double y = ReadDouble($"y{index}", ci);
            return new Pt(x, y);
        }

        static double ReadDouble(string label, CultureInfo ci)
        {
            while (true)
            {
                Console.Write($"{label} = ");
                var s = Console.ReadLine()?.Trim();
                if (double.TryParse(s, NumberStyles.Float, ci, out var v))
                    return v;

                Console.WriteLine($"Invalid input for {label}. Please enter a number (e.g., 12.34).");
            }
        }

        static double Distance2(Pt p, Pt q)
        {
            double dx = p.X - q.X;
            double dy = p.Y - q.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        static double AreaOfTriangle(double a, double b, double c)
        {
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(Math.Max(0, s * (s - a) * (s - b) * (s - c)));
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfPentagon
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculation());
        }
    }
}*/
