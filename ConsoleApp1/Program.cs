using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //Классная работа
        ////Task1
        //static int Meters(int k, int m)
        //{
        //    return k * 1000 + m;
        //}
        //static int Input(string message)
        //{
        //    Console.WriteLine(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void Output(int rez)
        //{
        //    Console.WriteLine($"rez={rez}");
        //}
        //static void Main(string[] args)
        //{
        //    int k = Input("количество км");
        //    int m = Input("количество метров");
        //    int rez = Meters(k, m);
        //    Output(rez);
        //    Console.Read();
        //}

        ////Task2
        //static int Seconds(int hour, int min, int sec)
        //{
        //    return hour * 60 + min * 60 + sec;
        //}
        //static int Input(string message)
        //{
        //    Console.WriteLine(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void Output(int rez)
        //{
        //    Console.WriteLine($"rez={rez}");
        //}
        //static void Main(string[] args)
        //{
        //    int hour = Input("количество часов");
        //    int min = Input("количество минут");
        //    int sec = Input("количество секунд");
        //    int rez = Seconds(hour, min, sec);
        //    Output(rez);
        //    Console.Read();
        //}

        ////Task3
        //static int Max(int x, int y)
        //{
        //    return (x > y) ? x : y;
        //}
        //static int Max1(int x, int z)
        //{
        //    return (x > z) ? x : z;
        //}
        //static int Max2(int y, int z)
        //{
        //    return (y > z) ? y : z;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("x=");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("y=");
        //    int y = int.Parse(Console.ReadLine());
        //    Console.Write("z=");
        //    int z = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Max={Max(x, y)}");
        //    Console.Read();
        //}

        ////Task4
        //static int Max(int a, int b)
        //{
        //    return (a > b) ? a : b;
        //}
        //static int Max1(int c, int d)
        //{
        //    return (c > d) ? c : d;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("a=");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("b=");
        //    int b = int.Parse(Console.ReadLine());
        //    Console.Write("c=");
        //    int c = int.Parse(Console.ReadLine());
        //    Console.Write("d=");
        //    int d = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Max={Max(a, b) + Max1(c, d)}");
        //    Console.Read();
        //}

        ////Task5
        //public static double Func(int x)
        //{
        //    return (Math.Sqrt(x) + x) / 2;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"y={Func(6) + Func(13) + Func(21):F2}");
        //    Console.Read();
        //}

        ////Task6
        //public static double Func(int x, int y)
        //{
        //    return (x + Math.Sqrt(x)) / (y + Math.Sqrt(y));
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"y={Func(2, 5) + Func(5, 13) + Func(11, 8):F2}");
        //    Console.Read();
        //}

        //Домашняя работа
        ////Task1
        //static int Centimeters(int m, int c)
        //{
        //    return m * 100 + c;
        //}
        //static int Input(string message)
        //{
        //    Console.WriteLine(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void Output(int rez)
        //{
        //    Console.WriteLine($"rez={rez}");
        //}
        //static void Main(string[] args)
        //{
        //    int m = Input("количество метров");
        //    int c = Input("количество сантиметров");
        //    int rez = Centimeters(m, c);
        //    Output(rez);
        //    Console.Read();
        //}

        ////Task2
        //static int Kop(int ruble, int kop)
        //{
        //    return ruble * 100 + kop;
        //}
        //static int Input(string message)
        //{
        //    Console.WriteLine(message);
        //    return int.Parse(Console.ReadLine());
        //}
        //static void Output(int rez)
        //{
        //    Console.WriteLine($"rez={rez}");
        //}
        //static void Main(string[] args)
        //{
        //    int ruble = Input("количество рублей");
        //    int kop = Input("количество копеек");
        //    int rez = Kop(ruble, kop);
        //    Output(rez);
        //    Console.Read();
        //}

        ////Task3
        //static int Min(int x, int y, int z)
        //{
        //    return Math.Min(x, Math.Min(y, z));
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("x=");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("y=");
        //    int y = int.Parse(Console.ReadLine());
        //    Console.Write("z=");
        //    int z = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Min={Min(x, y, z)}");
        //    Console.Read();
        //}

        ////Task4
        //static int Min(int x, int y)
        //{
        //    return x < y ? x : y;
        //}

        //static void Main()
        //{
        //    Console.Write("Введите значение a: ");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.Write("Введите значение b: ");
        //    int b = int.Parse(Console.ReadLine());
        //    int z = Min(2 * a, b + a) + Min(2 * a - b, b);
        //    Console.WriteLine($"Значение z: {z}");
        //    Console.Read();
        //}

        ////Task5
        //public static double Func(int x)
        //{
        //    return (Math.Sqrt(x) + x) / 3;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"y={Func(7) + Func(11) + Func(15):F2}");
        //    Console.Read();
        //}

        ////Task6
        //public static double Func(int x, int y)
        //{
        //    return (x + Math.Sqrt(y)) / (y + Math.Sqrt(x));
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine($"x={Func(15, 8) + Func(6, 12) + Func(7, 21):F2}");
        //    Console.Read();
        //}
    }


}

