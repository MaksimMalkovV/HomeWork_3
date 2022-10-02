// Знакомство с языком программирования С#
int program;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("Знакомство с языком програмирования С#.");
    Console.WriteLine("введите номер задания из списка ниже или Enter для выхода");
    Console.WriteLine("Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    program = Convert.ToInt32(Console.ReadLine());

    switch (program)
    {
        case 1:
            // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            Console.WriteLine("______________________");
            Console.WriteLine("Введите перове число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}.");
                Console.WriteLine("______________________");
            }
            else
            {
                Console.WriteLine($"Число {num2} больше числа {num1}.");
                Console.WriteLine("______________________");
            }
            break;

        case 2:
            // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            Console.WriteLine("______________________");
            Console.WriteLine("Введите три целых число: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Num3 = Convert.ToInt32(Console.ReadLine());

            int max = 0;

            if (Num1 > max)
            {
                max = Num1;
            }
            if (Num2 > max)
            {
                max = Num2;
            }
            if (Num3 > max)
            {
                max = Num3;
            }

            Console.WriteLine($"Наибольшее из введеных числе равно {max}.");
            Console.WriteLine("______________________");
            break;
        case 3:
            // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
            // является ли число чётным (делится ли оно на два без остатка).
            Console.WriteLine("______________________");
            Console.WriteLine("Введите число: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            if(Num % 2 == 1)
            {
                Console.WriteLine($"Число {Num} является нечетным.");
                Console.WriteLine("______________________");
            }

            else
            {
                Console.WriteLine($"Число {Num} является четным.");
                Console.WriteLine("______________________");
            }
            break;
        case 4:
            // Задача 8: Напишите программу, которая на вход принимает число (N), 
            // а на выходе показывает все чётные числа от 1 до N.
            Console.WriteLine("______________________");
            int i = 1;
            Console.WriteLine("Введите целое число:");
            int nums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + nums);
            while (i <= nums)
            {
                if (i % 2 != 1)
                {
                    Console.WriteLine(i + " ");
                    
                }
                i++;
                
            }
           
            break;
    default:
    begin = false;
    break;
           
    }
}
