using System;
using System.Collections.Generic;
namespace Studia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("--- Sprawdzenie poprawności tworzenia obiektu ---");
            // Time t = new Time(11, 30, 30);
            // Console.WriteLine(t);
            // Console.WriteLine("--- Sprawdzenie równości obiektów ---");
            // Time t1 = new Time(11, 35, 00);
            // Time t2 = new Time(11, 35, 00);
            // Time t3 = new Time("11:35:00");

            // Console.WriteLine($"t1: {t1} hashCode: {t1.GetHashCode()}");
            // Console.WriteLine($"t2: {t2} hashCode: {t2.GetHashCode()}");
            // Console.WriteLine($"t3: {t3} hashCode: {t3.GetHashCode()}");

            // Console.WriteLine($"--- Równość dla p1 oraz p2 -");
            // Console.WriteLine($"Object.ReferenceEquals(p1, p2): {Object.ReferenceEquals(t1, t2)}");
            // Console.WriteLine($"p1.Equals(p2): {t1.Equals(t2)}");
            // Console.WriteLine($"p1 == p2: {t1 == t2}");
            // Console.WriteLine();

            // Console.WriteLine($"--- Równość dla p1 oraz p2 -");
            // Console.WriteLine($"Object.ReferenceEquals(p1, p2): {Object.ReferenceEquals(t1, t3)}");
            // Console.WriteLine($"p1.Equals(p2): {t1.Equals(t3)}");
            // Console.WriteLine($"p1 == p2: {t1 == t3}");
            // Console.WriteLine();

            // spróbować ze stringiem etc
            // var list = new List<Time>();
            // list.Add(new Time(11, 35, 00));
            // list.Add(new Time(12, 35, 00));
            // list.Add(new Time(11, 40, 00));
            // list.Add(new Time(11, 35, 01));
            // foreach (var data in list)
            //     Console.WriteLine(data);

            // list.Sort();

            // Console.WriteLine("Po posortowaniu:");
            // foreach (var data in list)
            //     Console.WriteLine(data);

            // > < 
            // Time t1 = new Time(11, 40, 00);
            // Time t2 = new Time(11, 35, 01);
            // Console.WriteLine($"t1 > t2: {t1 > t2}");
            // Console.WriteLine($"t1 > t2: {t1 < t2}");
            // Console.WriteLine();


            // >= <=
            // Time t1 = new Time(11, 40, 00);
            // Time t2 = new Time(11, 35, 01);
            // Time t3 = new Time("11:40:00");
            // Console.WriteLine($"t1 > t2: {t1 >= t2}");
            // Console.WriteLine($"t1 > t2: {t1 <= t2}");
            // Console.WriteLine($"t1 > t2: {t1 <= t3}");

        }
    }


}
