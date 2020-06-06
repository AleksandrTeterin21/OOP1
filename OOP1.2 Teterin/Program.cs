using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._2_Teterin
{
    class Program
    {
        class Subscriber
        {
            internal int Id;
            public string Name;
            public string Surname;
            public string Patronymic;
            internal string Address;
            internal int Distance;
        }
        static void Main(string[] args)
        {
            Subscriber Subscriber = new Subscriber();
            Console.Write("Введите id аб-та: ");
            Subscriber.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Имя аб-та: ");
            Subscriber.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите фамилию аб-та: ");
            Subscriber.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Введите отчество аб-та: ");
            Subscriber.Patronymic = Convert.ToString(Console.ReadLine());

            Console.Write("Введите адресс аб-та: ");
            Subscriber.Address = Convert.ToString(Console.ReadLine());

            Console.Write("Введите расстояние аб-та: ");
            Subscriber.Distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Subscriber.Id + " " + Subscriber.Name + " " + Subscriber.Surname + " " + Subscriber.Patronymic + " " + Subscriber.Address + " " + Subscriber.Distance);
            Console.ReadLine();
        }
    }
    }

