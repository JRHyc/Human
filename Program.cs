using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human jeff = new Human("Jeff");
            Human joanna = new Human("Joanna");
            Wizard gandalf = new Wizard("Gandalf");
            Ninja raphael = new Ninja("Raphael");
            Samurai hanzo = new Samurai("Hanzo");
            
            joanna.Attack(jeff);
            gandalf.fireball(joanna);
            raphael.steal(joanna);
            raphael.getAway();
            hanzo.deathBlow(joanna);

        }
    }
}
