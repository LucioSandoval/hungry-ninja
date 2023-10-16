﻿class Program
{
    static void Main()
    {
        Buffet buffet = new Buffet();
        Ninja ninja = new Ninja();

        while (!ninja.IsFull)
        {
            Food food = buffet.Serve();
            ninja.Eat(food);
        }

        Console.WriteLine("Ninja is full!");

        Console.ReadLine();
    }
}
