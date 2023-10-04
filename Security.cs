//Створити абстрактний базовий клас Worker (працівник) з методом Print().
//Створіть чотири похідні класи: President, Security, Manager, Engineer.
//Перевизначте метод Print() для виведення інформації, яка відповідає кожному типу працівника.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_4_4
{
    internal class Security:Worker
    {
        public Security(string position, string information) : base() 
        {
            if (position == "") throw new ArgumentNullException("Немає вакансії");
            Position = position;
            Info = information;
        }
        public override void Print()
        {
            if (Info == "")
            {
                throw new ArgumentNullException($"Немає ітформації о {Position}");
            }
            else
            {
                Console.WriteLine($"Інформація о должности {Position}: {Info}");
            }
        }
    }
}
