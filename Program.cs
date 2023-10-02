//Створити абстрактний базовий клас Worker (працівник) з методом Print().
//Створіть чотири похідні класи: President, Security, Manager, Engineer.
//Перевизначте метод Print() для виведення інформації, яка відповідає кожному типу працівника.

using NET_Homework_4_4;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int a = 1;
while (a != 0)
{
    Console.WriteLine("\nОберіть посаду, щоб дізнатися інформацію про неї:\n" +
        "0. Завершення вибору;\n" +
        "1. President;\n" +
        "2. Security;\n" +
        "3. Manager;\n" +
        "4. Engineer.\n");
    a = Convert.ToInt32(Console.ReadLine());

    Worker? worker = null;

    switch (a)
    {
            case 0:
            {
                break;
            }
            case 1:
            {
                worker = new President("President", "Інформація");
                break;
            }
            case 2:
            {
                worker = new Security("Security", "Інформація");
                break;
            }
            case 3:
            {
                worker = new Manager("Manager", "Інформація");
                break;
            }
            case 4:
            {
                worker = new Engineer("Engineer", "Інформація");
                break;
            }
    }
    if(worker != null)
    {
        worker.Print();
    }
}
