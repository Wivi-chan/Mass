using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Одномерный_массив
{
    class Program
    {

        static void Main(string[] args)
        {
            int contin = 1;
            while (contin == 1)
            {
                try
                {
                    Console.WriteLine("Введите количество элементов: ");
                    int NumMass = int.Parse(Console.ReadLine());
                    int[] Mass = new int[NumMass];

                    Console.WriteLine("Введите элемент: ");
                    for (int i = 0; i < Mass.Length; i++)
                    {
                        Mass[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введеный элемент: {0} ", Mass[i]);

                    }
                    Console.Clear();
                    Console.WriteLine("Введеный массив: ");
                    foreach (int j in Mass)
                    {
                        Console.Write("{0} ", j);

                    }
                    
                    Console.WriteLine("\nСумма элементов массива: " + Summ(Mass));
                    Console.WriteLine("Массив максимальный элемент: " + Mass.Max());
                    Console.WriteLine("Массив минимальный элемент: " + Mass.Min());
                    // Console.WriteLine("Массив пузырьковый сортировки: " + SortMin(Mass));
                    // Console.WriteLine("Массив пузырьковый сортировки: " + SortMax(Mass));
                    Console.WriteLine("Массив пузырьковый сортировки from max befor min: ");
                    SortMax(Mass);
                    Console.WriteLine("\nМассив пузырьковый сортировки from min befor max: ");
                    //SortMin(Mass); 
                    BubbleSort(Mass);
                    Console.WriteLine("После сортировки:");
                    for (int i = 0; i < Mass.Length; i++)
                    {
                        Console.Write(Mass[i]);
                    }
                    Console.WriteLine("\n ");
                }
                catch (SystemException)
                {
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\nНужно было ввести число ввести число\nПродолжить?:(1- да, 2- нет) ");
                    contin = int.Parse(Console.ReadLine());
                    
                }
            }

            Console.ReadKey();
        }

        public static int Summ(int[] SumMass)
        {
            int s = 0;

            for (int i = 0; i < SumMass.Length; i++)
            {
                s += SumMass[i];
            }
            return s;

        }

        public static void SortMax(int[] SortMass)
        {
            int temp = 0;

            for (int i = 0; i< SortMass.Length; i++)
            {
                for (int j=0; j< SortMass.Length; j++)
                {
                    if (SortMass[i]> SortMass[j])
                    {
                        temp = SortMass[i];
                        SortMass[i] = SortMass[j];
                        SortMass[j] = temp;
                    }
                }
            } //return SortMass;
            Console.WriteLine("Вывод отсортированного по возростанию массива");
            for (int i = 0; i < SortMass.Length; i++)
            {
                Console.Write(SortMass[i]);
            }

        }

        //public static void SortMin(int[] SortMass1)
        //{
        //    int temp;
        //    for ( int i=0; i< SortMass1.Length-1; i++)
        //    {
        //        for( int j=i+1; j < SortMass1.Length; j++)
        //        {
        //            if (SortMass1[i] > SortMass1[j])
        //            {
        //                temp = SortMass1[i];
        //                SortMass1[i] = SortMass1[j];
        //                SortMass1[j] = temp;
        //            }
        //        }
        //        Console.Write("Отсортированный массив по убыванию:\n");
        //        for (i = 0; i < SortMass1.Length; i++)
        //        {
        //            Console.Write(SortMass1[i]);
        //        }
        //    } //return SortMass1;
        //}
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
