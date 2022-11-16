using System;
using System.Collections.Generic;
using System.Text;

namespace Контрольная_Романова_02_04
{
    interface Location
    {
        void show();
        int shop();
        void hospital();
    }
    class City : Location
    {
        public int kol; //количество магазинов в одном райное
        public int area; //количество районов в городе
        string city; // название города
        public int child; //количество детских больниц в районе
        public int adult; //количество взрослых боьниц в районе
        public City(string city)
        {
            this.city = city;
        }
        public virtual void show() // вывод города в котором живете
        {
            Console.WriteLine("Вы живете в городе " + city);
        }
        public int shop() //подсчет количества магазинов в городе по количеству магазинов в одном районе (в каждом районе одинаковое количество магазинов)
        {
            return area * kol;
        }
        public void hospital() //количество детских и взрослых больниц в городе
        {
            Console.WriteLine($"В городе {child*area} детских больниц и {adult*area} взрослых");
        }
    }
    class Village: City
    {
        string village; //название деревни
        public int residents_new; //население деревни этого года
        public int residents_old;//население деревни прошлого года
        public Village(string village, string city):base(city)
        {
            this.village = village;
        }
        public override void show() //вывод города и деревни обитания
        {
            base.show();
            Console.WriteLine("Вы живете в деревне "+ village);
        }
        public void Population() //вывод прибыли и убыли населения
        {
            if (residents_new > residents_old)
            {
                Console.WriteLine($"Прибыль населения на {residents_new-residents_old} человека");
            }
            else
            {
                if(residents_new < residents_old)
                {
                    Console.WriteLine($"Убыль населения на {residents_old - residents_new} человека");
                }
                else
                {
                    Console.WriteLine("Численность населения не изменилась");
                }
            }
            
        }
        new public void hospital() //вывод количества больниц в деревне
        {
            Console.WriteLine($"В деревне всего {child + adult} больниц");
        }
    }
}
