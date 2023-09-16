using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mit_spil
{
    public class character
    {
        public string name { get; set; }
    }

    public class Warrior : character
    {
        public int health { get; set; }
        public int damage { get; set; }
        public int armour { get; set; }
        public int level { get; set; }

        public Warrior(string name, int health, int damage, int armour, int level)
        {
            this.name = name;
            health = health;
            damage = damage;
            armour = armour;
            level = level;
        }

    }

    public class Glasscannon : character
    {
        public int health { get; set; }
        public int damage { get; set; }
        public int armour { get; set; }
        public int level { get; set; }
        public Glasscannon(string name, int health, int damage, int armour, int level)
        {
            this.name = name;
            health = health;
            damage = damage;
            armour = armour;
            level = level;
        }

    }

    public class Tank : character
    {
        public int health { get; set; }
        public int damage { get; set; }
        public int armour { get; set; }
        public int level { get; set; }
        public Tank(string name, int health, int damage, int armour, int level)
        {
            this.name = name;
            health = health;
            damage = damage;
            armour = armour;
            level = level;
        }

    }
    public class TextWriter
    {
        public static void WriteSlowly(string text, int delayMilliseconds)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMilliseconds);
            }
            Console.WriteLine();
        }
    }
}
