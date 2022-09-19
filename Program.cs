using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Сложить 2 числа ");
            Console.WriteLine("2. Вычесть первое из второго ");
            Console.WriteLine("3. Перемножить два числа ");
            Console.WriteLine("4. Разделить первое на второе ");
            Console.WriteLine("5. Возвести в степень N первое число ");
            Console.WriteLine("6. Найти квадратный корень из числа ");
            Console.WriteLine("7. Найти 1 процент от числаm ");
            Console.WriteLine("8. Найти факториал из числа ");
            Console.WriteLine("9. Выйти из программы ");
            while (true)
            {
                Console.WriteLine("------------------------------------- ");
                Console.WriteLine("Какое действие вы хотите выполнить ? ");
                int action = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите первое число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int input_2 = Convert.ToInt32(Console.ReadLine());
                            result = Addition(input_1, input_2);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите первое число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int input_2 = Convert.ToInt32(Console.ReadLine());
                            result = Subtraction(input_1, input_2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите первое число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int input_2 = Convert.ToInt32(Console.ReadLine());
                            result = Multiplication(input_1, input_2);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите первое число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int input_2 = Convert.ToInt32(Console.ReadLine());
                            result = Division(input_1, input_2);
                            break;
                        }
                    case 5: //Возвести в степень N первое число
                        {
                            Console.WriteLine("Введите первое число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число");
                            int input_2 = Convert.ToInt32(Console.ReadLine());
                            result = Stepen(input_1, input_2);
                            break;
                        }
                    case 6: // Найти квадратный корень из числа
                        {
                            Console.WriteLine("Введите число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            result = kradratkoren(input_1);
                            break;
                        }
                    case 7: // Найти 1 процент от числаm
                        {
                            Console.WriteLine("Введите число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            result = Oneprozent(input_1);
                            break;
                        }
                    case 8: // Найти 1 процент от числаm
                        {
                            Console.WriteLine("Введите число");
                            int input_1 = Convert.ToInt32(Console.ReadLine());
                            result = Factorial(input_1);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Пока");
                            Environment.Exit(0);
                            break;
                        }
                }
                Console.WriteLine("Ответ: {0}", result);
                Console.ReadKey();
            }
           
        }
        //плюси  1
        public static int Addition(int input_1, int input_2)
        {
            int result = input_1 + input_2;
            return result;
        }
        //майнус  2
        public static int Subtraction(int input_1, int input_2)
        {
            int result = input_1 - input_2;
            return result;
        }
        //умножай 3 
        public static int Multiplication(int input_1, int input_2)
        {
            int result = input_1 * input_2;
            return result;
        }
        //деление  4
        public static int Division(int input_1, int input_2)
        {
            int result = input_1 / input_2;
            return result;
        }
        //Возвести в степень N первое число 5 

        public static int Stepen(int input_1, int input_2)
        {
            int result = 1;
            while (input_2 != 0)
            {
                result *= input_1;
                --input_2;
            }
            return result;
        }
        /*public static int Stepen(int input_1, int input_2)
        {
            int result = 1;
            for(int i = 0; i < input_2; i++)
            {
                result = result * input_1;
            }
            return result;
        }*/
        //Найти квадратный корень из числа
        public static int kradratkoren(int input_1)
        {
            double result = Math.Sqrt(input_1);
            return (int)result;
        }
        //Найти 1 процент от числаm 7 
        public static int Oneprozent(int input_1)
        {
            double result = input_1 / 100;
            return (int)result;
        }
        // Найти факториал из числа 8
        public static int Factorial(int input_1)
        {
            int num = input_1;
            int result = 1;

            for (int i =1; i<= num; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}