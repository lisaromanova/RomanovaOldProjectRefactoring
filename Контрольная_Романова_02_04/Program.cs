using System;

namespace Контрольная_Романова_02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите город");
            string city = Console.ReadLine();
            City A = new City(city);
            A.show();
            Console.WriteLine("Введите количество районов в городе");
            A.area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество магазинов в одном районе города");
            A.kol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"В городе {A.shop()} магазинов 'Пятерочка'");
            Console.WriteLine("Введите количество детских больниц в районе города");
            A.child = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество взрослых больниц в районе города");
            A.adult = Convert.ToInt32(Console.ReadLine());
            A.hospital();
            Console.WriteLine("Введите название деревни");
            string village = Console.ReadLine();
            Village B = new Village(village, city);
            B.show();
            Console.WriteLine("Введите население деревни в этом году");
            B.residents_new = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите население деревни в прошлом году");
            B.residents_old = Convert.ToInt32(Console.ReadLine());
            B.Population();
            Console.WriteLine("Введите количество детских больниц в деревне");
            B.child = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество взрослых больниц города");
            B.adult = Convert.ToInt32(Console.ReadLine());
            B.hospital();
        }
    }
}
