using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicGame.Models
{
    public class DbSeeder
    {
        private readonly GameContext _gameContext;

        public DbSeeder(GameContext gameContext)
        {
            _gameContext = gameContext;
        }

        public bool TrySeed()
        {
            bool is_seeded = false;

            if (!_gameContext.Players.Any() && !_gameContext.Heroes.Any() && !_gameContext.Items.Any())
            {
                seed();
                is_seeded = true;
            }

            return is_seeded;
        }

        private void seed()
        {

            var players = new List<Player>()
            {
                new Player("Sasha",  DateTime.Now.AddYears(-33), "login", DateTime.Now.AddYears(-3)),
                new Player("Pasha", DateTime.Now.AddYears(-11), "l1ogin",  DateTime.Now.AddYears(-1))

            };

            _gameContext.Players.AddRange(players);

            _gameContext.SaveChanges();


            Item i1 = new Item("weapon", "kni1fe", 11, 1, 4, 10);
            Item i2 = new Item("BigWeapon", "kni1fe", -11, 1, 4, 110);


            var Items = new List<Item>()
            {
                new Item("weapon", "knife", 0, 1, 4, 10),

                new Item("Armor", "shild", 5, 1, 40, 10)


            };

            _gameContext.Items.AddRange(Items);

            _gameContext.SaveChanges();

            var Heroes = new List<Hero>()
            {
                new Hero(2, "vampire", 11, 100, 2.3, 221, new List<Item>() {i1, i2 }),
                new Hero(2, "zero", 11, 230, 5.31, 3001, new List<Item>() {i2 }),
                new Hero(1, "zero", 111, 200, 0.31, 1001, new List<Item>() {i1})

            };

            _gameContext.Heroes.AddRange(Heroes);

            _gameContext.SaveChanges();
          
        }
    }
}
