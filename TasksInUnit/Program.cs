using System;
using System.Collections;
using System.Reflection;
using System.Xml.Linq;

namespace TasksInUnit
{
    /// <summary>
    /// Реализуйте метод, который будет возвращать индекс элемента в отсортированном массиве,
    /// на место которого можно будет вставить элемент так, чтобы не нарушить порядок сортировки.
    /// В рамках решения задачи считаем, что:
    /// 1) массив отсортирован от меньшего к большему, и что числа в нём не повторяются;
    /// 2) при вставке элемента по индексу, который будет возвращен, оставшаяся часть массива
    ///    будет сдвигаться вправо.
    /// </summary>
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

            Console.WriteLine("\nВведите элемент для поиска индекса вставки: ");
            int target = int.Parse(Console.ReadLine());

            int index = FindAPlace(array, target);

            PrintArray(array, 0, index);
            Console.Write(" [ ] ");
            PrintArray(array, index, array.Length);
            Console.WriteLine("\nВставлен элемент {0} на позицию {1}", target, index);
            Console.ReadKey();
        }

        public static int FindAPlace(int[] array, int target)
        {
            int index = 0;
            for (index = 0; index < array.Length; index++)
            {
                if (array[index] > target)
                {
                    return index;
                }
            }
            return index;
        }

        public static void PrintArray(int[] array, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void PrintArray(int[] array, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
