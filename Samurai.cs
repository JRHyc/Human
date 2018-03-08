using System;
namespace Human
{
    public class Samurai : Human
    {
        public Samurai(string n) : base(n)
        {
            health = 200;
        }
        public void deathBlow(Human enemy)
        {
            if(enemy.health < 50)
            {
                enemy.health = 0;
                System.Console.WriteLine("{0} attacked {1}! Finish them! {1} is now at {2} health!", name, enemy.name, enemy.health);
            }
            else
            {
                System.Console.WriteLine("{0} attacked {1} and missed! {1} is still at {2} health!", name, enemy.name, enemy.health);
            }
        }
        public void meditate()
        {
            health = 200;
            System.Console.WriteLine("{0} meditated and is now at {1} health!", name, health);
        }
    }
}