using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicGame.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Health { get; set; }
        public int Regeneration { get; set; }

        public int Armor { get; set; }
        public int Damage { get; set; }

        public virtual ICollection<Hero> Heroes { get; set; }

        public Item()
        {
            Heroes = new List<Hero>();
        }

        public Item(string type, string name, int health, int regeneration, int armor, int damage) : this()
        {
            Type = type;

            Name = name;

            Health = health;

            Regeneration = regeneration;

            Armor = armor;

            Damage = damage;
        }
    }
}
