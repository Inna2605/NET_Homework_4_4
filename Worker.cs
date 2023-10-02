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
    public abstract class Worker
    {
        public string Position = "";
        public string Info = "";
        public abstract void Print();
    }
}
