using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicGame.Models
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
        public string Login { get; set; }

        public DateTime RegistrationDate { get; set; }

        public ICollection<Hero> heroes { get; set; }

        public Player()
        {
            heroes = new List<Hero>();
        }

        public Player(string name, DateTime birthday, string login, DateTime registrationDate) : this()
        {

            Name = name;

            Birthday = birthday;

            Login = login;

            RegistrationDate = registrationDate;
        }
    }
}
