using System;
namespace Human
{
    public class Human
    {
       public string name;
       public int strength = 3;
       public int intelligence = 3;
       public int dexterity = 3;
       public int health = 100;

       public Human(string n)
       {
           name = n;
       }

       public Human(string n, int str, int ing, int dext, int hp)
       {
           name = n;
           strength = str;
           intelligence = ing;
           dexterity = dext;
           health = hp;
       }

       public Human Attack(Human enemy)
       {
           int damage = 5*strength;
           enemy.health -= damage;
           System.Console.WriteLine($"{name} attacked {enemy.name} for {damage}. Health is now {enemy.health}");
           return enemy;
       }
    }
}