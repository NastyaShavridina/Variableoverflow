using System;

namespace Variableoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Напишите программу, в которой в теле метода Main создайте две локальные
            //переменные типа int в которые получите числа от пользователя и проинициализируйте
            //ее значением, полученным из консоли.
            //Создайте блок, в котором, проверяя арифметические переполнения, выполните
            //умножение и сложение введенных чисел. Результат умножения и сложения выведите на
            //экран.Попробуйте вычисления с числами, явно вызывающими переполнение.

            int value1, value2, result;

            Console.WriteLine("Число 1 : ");

            value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Число 2 : ");

            value2 = Convert.ToInt32(Console.ReadLine());

            checked
            {
                result = value1 + value2;

                Console.WriteLine($"Результат сложения {result}");

                result = value1 * value2;

                Console.WriteLine($"Результат умножение {result}");

            }

            //  Измените проект из задания 2 таким образом, чтобы у вас проверка переполнения
            //выполнялась по умолчанию.При этом отключите проверку переполнения для операций
            //умножения и сложения.

            unchecked
            {
                result = value1 + value2;

                Console.WriteLine($"Результат сложения {result}");

                result = value1 * value2;

                Console.WriteLine($"Результат умножение {result}");

            }

        }
    }
}
