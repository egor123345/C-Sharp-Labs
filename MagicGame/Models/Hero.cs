using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicGame.Models
{
    public class Hero
    {
        public int Id { get; set; }

        public string Race { get; set; }

        public int Level { get; set; }

        public int Health { get; set; }

        public double Kda { get; set; }

        public int GamesCount { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public virtual ICollection<Item> Items { get; set; }

        public Hero()
        {

        }
        public Hero(int playerId, string race, int level, int health, 
                            double kda, int gamesCount)
        {
            Items = new List<Item>();
            PlayerId = playerId;

            Race = race;

            Level = level;

            Health = health;

            Kda = kda;

            GamesCount = gamesCount;
        }

        public Hero(int playerId, string race, int level, int health,
                            double kda, int gamesCount, ICollection<Item> items) :
                            this(playerId, race, level, health, kda, gamesCount)
        {
            Items = items;
        }

    }
}
