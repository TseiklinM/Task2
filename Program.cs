using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1*/
            
            //1.Ввод данных
            Console.Write(" Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            //2.Проверка условий ввода данных
            if (n < 0)
                n *= -1;
            if (n == 0)
            {
                n = 10;
                Console.WriteLine($" Вы выбрали массив длинной 0. \n " +
                                    $" Размер массива автоматически увеличен до 10. \n");
            }
            int[] arrRandom = new int[n];
            Random rand = new Random(); //Для заполнения массива произвольными значениями
            int count = 0; //Счетчик значений равных нулю
            bool flag = false; // Проверка массива на наличие нулевых значений

            //3.Решение
            Console.WriteLine(" Заполнение массива произвольными значениями от 0 до 5.");
            while (!flag)
            {
                //3.1 Заполнение массива и вывод на экран
                for (int i = 0; i < n; i++)
                {
                    arrRandom[i] = rand.Next(0, 6);
                    Console.Write(" " + arrRandom[i]);
                    if (arrRandom[i] == 0) //Проверка на наличие нулевых значений в массиве
                    {
                        flag = true;
                    }
                }
               
                //3.2 Поиск в массиве нулевых значений и их удаление
                if (flag)
                {
                    int temp = arrRandom.Length;
                    int i = 0;
                    while (temp > 0)
                    {
                        if (arrRandom[i] == 0)
                        {
                            count++; 
                            for (int j = i; j < (arrRandom.Length - count); j++)
                                {
                                    arrRandom[j] = arrRandom[j + 1];
                                }
                            i--;
                        }
                        i++;
                        temp--;
                    }
                
                }else
                    Console.WriteLine("\n Полученный массив не имеет нулевых значений. " +
                                                                "\n Перезапишем массив.\n\n");
            }

            //3.3 Подстановка вместо убранных нулей -1,  в конец массива
            for (int i = (arrRandom.Length - count); i < arrRandom.Length; i++)
            {
                arrRandom[i] = -1;
            }

            //4.Вывод полученного массива на экран
            Console.WriteLine("\n Вывод полученного массива на экран: ");
            for (int i = 0; i < arrRandom.Length; i++)
            {
                Console.Write(" " + arrRandom[i]);
            }
        }
    }
}
