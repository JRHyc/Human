using System;
namespace Human
{
    public class Wizard : Human
    {
        public Wizard(string n) : base(n)
        {
            health = 50;
            intelligence = 25;
        }   
        public void heal()
        {
            health += intelligence * 10;
        }
        public void fireball(object target)
        {
            if(target is Human)
            {
                Human enemy = target as Human;
                Random rand = new Random();
                int damage = rand.Next(20,51);
                enemy.health -= damage;
                System.Console.WriteLine("{0} took a fireball to the face from {1}. Health is now {2}.", enemy.name, name, enemy.health);
            }
        }
    }
}
