using System;
namespace Human
{
    public class Ninja : Human
    {
        public Ninja(string n) : base(n)
        {
            dexterity = 175;
        }
        public void steal(Human enemy)
        {
            Attack(enemy);
            health += 10;
            System.Console.WriteLine("{0}'s health is now at {1}!", name, health);
        }
        public void getAway()
        {
            health -= 15;
            System.Console.WriteLine("{0} got away! Health is now at {1}", name, health);
        }
    }
}