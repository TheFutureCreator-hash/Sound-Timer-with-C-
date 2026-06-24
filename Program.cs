using System;
using System.Timers;

class Program
{
    static int counter = 0;

static void Main()
    {
        Console.Clear();
        Console.WriteLine("==The timer is counting..==");
        Console.WriteLine("See the number growing every second.");
        Console.WriteLine("------------------------------------");

        Timer myTimer = new Timer(1000); // Create the timer

        myTimer.Elapsed += WhatToDoInEachSecond;
        myTimer.start(); // Start the timer
        myTimer.AutoReset = true; //The Timer can repeat
        Console.ReadKey();

        static void WhatToDoInEachSecond(object sender, ElapsedEventArgs e)
        {
            counter++;
            Console.WriteLine($"Counter: {counter}");
            Console.Beep(800, 150); // Sound
        }
    }
}
