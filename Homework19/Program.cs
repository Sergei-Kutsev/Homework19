using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pc> listPc = new List<Pc>()
        {
            new Pc() { ID = "D1516", Name = "Dell", CPU = "AMD", Ghz = 2.5, Ram = 4, Hard = 250, GraphicsCard = 2, Price = 25000, Number =5},
            new Pc() { ID = "C1565R", Name = "Asus", CPU = "Intel", Ghz = 3.2, Ram = 16, Hard = 500, GraphicsCard = 6, Price = 85000, Number =45},
            new Pc() { ID = "F165R", Name = "Lenovo", CPU = "Intel", Ghz = 2.6, Ram = 4, Hard = 250, GraphicsCard = 2, Price = 55000, Number =7},
            new Pc() { ID = "C2656", Name = "Acer", CPU = "Intel", Ghz = 4.0, Ram = 6, Hard = 350, GraphicsCard = 4, Price = 45000, Number =6},
            new Pc() { ID = "T1656", Name = "MSI", CPU = "AMD", Ghz = 4.0, Ram = 32, Hard = 1000, GraphicsCard = 8, Price = 125000, Number =2},
            new Pc() { ID = "J15", Name = "HP", CPU = "AMD", Ghz = 2.6, Ram = 12, Hard = 750, GraphicsCard = 8, Price = 65000, Number =3},
            new Pc() { ID = "415", Name = "Aces", CPU = "Intel", Ghz = 3.2, Ram = 16, Hard = 550, GraphicsCard = 6, Price = 49000, Number =9},
            new Pc() { ID = "HT15", Name = "Asus", CPU = "AMD", Ghz = 4.0, Ram = 32, Hard = 800, GraphicsCard = 8, Price = 90000, Number =2},
        };
            Console.Write("Укажите название процессора: ");
            string first = Console.ReadLine();
            IEnumerable<Pc> computers1 = listPc
                .Where(P => P.CPU == first);

            foreach (Pc P in computers1)
            { Console.WriteLine($"{P.ID} {P.Name} {P.CPU} {P.Ghz} {P.Ram} {P.Hard} {P.GraphicsCard} {P.Price} {P.Number}"); }
            Console.ReadKey();


            Console.Write("Укажите минимальный объем оперативной памяти: ");
            int second = Convert.ToInt32(Console.ReadLine());
            IEnumerable<Pc> computers2 = listPc
                 .Where(P1 => P1.Ram >= second);

            foreach (Pc P1 in computers2)
            { Console.WriteLine($"{P1.ID} {P1.Name} {P1.CPU} {P1.Ghz} {P1.Ram} {P1.Hard} {P1.GraphicsCard} {P1.Price} {P1.Number}"); }
            Console.ReadKey();


            Console.WriteLine("Полный список доступных компьютеров, отсортированный по увеличению стоимости:");
            List<Pc> computers3 = listPc
                .OrderBy(P2 => P2.Price)
                .ToList();

            foreach (Pc P2 in computers3)
            { Console.WriteLine($"{P2.ID} {P2.Name} {P2.CPU} {P2.Ghz} {P2.Ram} {P2.Hard} {P2.GraphicsCard} {P2.Price} {P2.Number}"); }
            Console.ReadKey();


            Console.WriteLine("Полный список доступных компьютеров, сгрупированный по типу процессора:");
            var computers4 = listPc
                .GroupBy(P3 => P3.CPU);

            foreach (IGrouping<string, Pc> P3 in computers4)
            {
                Console.WriteLine(P3.Key);
                foreach (var t in P3)
                    Console.WriteLine($"{t.ID} {t.Name} {t.CPU} {t.Ghz} {t.Ram} {t.Hard} {t.GraphicsCard} {t.Price} {t.Number}");
            }
            Console.ReadKey();


            Pc computer6 = computers3
            .First();
            Pc computer7 = computers3
            .Last();
            Console.WriteLine();
            Console.WriteLine("Самый бюджетный компьютер:");
            Console.WriteLine($"{computer6.ID} {computer6.Name} {computer6.CPU} {computer6.Ghz} {computer6.Ram} {computer6.Hard} {computer6.GraphicsCard} {computer6.Price} {computer6.Number}");
            Console.WriteLine();
            Console.WriteLine("Самый дорогой компьютер:");
            Console.WriteLine($"{computer7.ID} {computer7.Name} {computer7.CPU} {computer7.Ghz} {computer7.Ram} {computer7.Hard} {computer7.GraphicsCard} {computer7.Price} {computer7.Number}");
            Console.ReadKey();

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            var computers8 = listPc
                .Where(P4 => P4.Number >= 30)
                .Count();
            Console.WriteLine();
            if (computers8 == 0) { Console.WriteLine($"На текущий момент в наличии нет такого количества компьютеров."); }
            else { Console.WriteLine($"В наличи есть \"{computers8}\" компьютер в таком количестве"); }
            Console.ReadKey();
        }
    }
    class Pc
    {
        public string ID { get; set; } // код
        public string Name { get; set; } // название
        public string CPU { get; set; } // тип процессора
        public double Ghz { get; set; } // частота (2,50 2,6 3,2 4)
        public int Ram { get; set; } // объем оперативки (2гб, 4, 6, 8, 12, 16, 32)
        public int Hard { get; set; } // объем жесткого диска
        public int GraphicsCard { get; set; } // объем видеокарты
        public double Price { get; set; } // цена
        public int Number { get; set; } // количество шт
    }
}
