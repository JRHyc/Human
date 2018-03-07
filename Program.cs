using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jeff = new Human("Jeff");
            Human joanna = new Human("Joanna");
            System.Console.WriteLine(jeff.health);
            joanna.Attack(jeff);
        }
    }
}
