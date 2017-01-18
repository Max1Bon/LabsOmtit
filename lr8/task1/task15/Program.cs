using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("vvedie razmernost' massiva n: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
           
            Console.WriteLine("vvedite massiv: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 1 || arr[i] > 4)
                {
                    Console.WriteLine("error:need from 1 to 4");
                    return;
                }
            }
            //сортировка массива по возрастанию
            int temp;
            int k=0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        k++;
                        arr[j] = temp;
                    }
                }
            }



            /*
            Console.WriteLine("Отсортированный массив");
            Array.Sort(arr); // Функция сортировки массива 
            */
            for (int i = 0; i < arr.Length; i++) // вывод отсортированного массива                 
                Console.Write(" " + arr[i]);
            Console.WriteLine(k);
        }
    }
}
