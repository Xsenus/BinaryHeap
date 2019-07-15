using BinaryHeap.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();

            //var heap = new Heap();
            //heap.Add(20);
            //heap.Add(11);
            //heap.Add(17);
            //heap.Add(7);
            //heap.Add(4);
            //heap.Add(13);
            //heap.Add(15);
            //heap.Add(14);

            //while (heap.Count > 0)
            //{
            //    Console.WriteLine(heap.GetMax());
            //}            

            var rnd = new Random();
            var startItems = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                startItems.Add(rnd.Next(-1000, 1000));
            }

            timer.Start();
            var heap = new Heap(startItems);
            timer.Stop();
            Console.WriteLine($"Первоначальная инициализация из 1000 элементов: {timer.Elapsed}");

            timer.Restart();
            for (int i = 0; i < 1000; i++)
            {
                heap.Add(rnd.Next(-1000, 1000));
            }
            timer.Stop();
            Console.WriteLine($"Добавление второй 1000 элементов: {timer.Elapsed}");

            timer.Restart();
            foreach (var item in heap)
            {
                Console.Write($"{item} ");
            }
            timer.Stop();
            Console.WriteLine($"\nВывод 2000 элементов: {timer.Elapsed}");

            Console.ReadLine();
        }
    }
}
