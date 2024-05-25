﻿using System;
using System.Runtime.Serialization;

namespace PrimerioProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 1.5F;
            float b = 2.1F;

            double soma = a + b;
            Console.WriteLine($"A soma é: {soma}");
        }
    }
}



using System;

class Program
{
    static void Main(string[] args)
    {
        string[] start = Console.ReadLine().Split(' ');
        int startDay = int.Parse(start[1]);

        string[] startTime = Console.ReadLine().Split(':');
        int startHour = int.Parse(startTime[0]);
        int startMinute = int.Parse(startTime[1]);
        int startSecond = int.Parse(startTime[2]);

        string[] end = Console.ReadLine().Split(' ');
        int endDay = int.Parse(end[1]);

        string[] endTime = Console.ReadLine().Split(':');
        int endHour = int.Parse(endTime[0]);
        int endMinute = int.Parse(endTime[1]);
        int endSecond = int.Parse(endTime[2]);

        TimeSpan duration = new DateTime(1, 1, endDay, endHour, endMinute, endSecond) - new DateTime(1, 1, startDay, startHour, startMinute, startSecond);

        Console.WriteLine($"{duration.Days} dia(s)");
        Console.WriteLine($"{duration.Hours} hora(s)");
        Console.WriteLine($"{duration.Minutes} minuto(s)");
        Console.WriteLine($"{duration.Seconds} segundo(s)");
    }
}

