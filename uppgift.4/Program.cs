using System;

namespace Uppgift_4._1
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("vad har de fösta anställda för lön");
            int lön = int.Parse(Console.ReadLine());

            Console.WriteLine("vad har de andra anställda för lön");
            int lön2 = int.Parse(Console.ReadLine());
            Console.WriteLine("vad har den tredje anställda för lön");
            int lön3 = int.Parse(Console.ReadLine());

            int medellönen = (lön * 600) - 600;
            int lön4 = 200 + medellönen;

            Console.WriteLine("medellönen är" + lön + "kronor");


        }


    }


}