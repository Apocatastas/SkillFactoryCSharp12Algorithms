using System;
using System.Collections;
using System.Reflection;

namespace TasksInUnit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(-50, 100);
            }

            Console.WriteLine("Несортированный массив:");
            PrintArray(array, array.Length);

            Array.Sort(array, 0, length);

            Console.WriteLine("\nОтсортированный массив:");
            PrintArray(array, array.Length);

            Console.WriteLine("\nВведите элемент для поиска: ");
            int target = int.Parse(Console.ReadLine());
            int targetPosition = BinarySearch(array, target, 0, array.Length - 1);
            Console.WriteLine("Найден, элемент array[{0}] = {1}", targetPosition, array[targetPosition]);
            Console.ReadKey();
        }

        public static void PrintArray(int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static int BinarySearch(int[] array, int target, int left, int right)
        {
            int middle = array.Length / 2;
            while (!(array[middle] == target))
            {
                middle = (left + right) / 2;
                if (array[middle] > target)
                {
                    Console.WriteLine("Ищем: {0} - {1}", left, right);
                    right = middle - 1;

                }
                else
                {
                    Console.WriteLine("Ищем: {0} - {1}", left, right);
                    left = middle + 1;
                }

            }
            return middle;
        }
    }
}
