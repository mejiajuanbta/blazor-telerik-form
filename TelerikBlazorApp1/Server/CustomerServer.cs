using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelerikBlazorApp1.Shared;

namespace TelerikBlazorApp1.Server {
    public class CustomerServer {
        public static List<Person> Customers = new List<Person> {
            new Person {
                Id = 1,
                FirstName = "Joe",
                LastName = "Doe",
                Email = "a@b.com",
                Birthday = DateTime.Now.AddYears(-25),
                FavoriteSports = new List<string>{ "Baseball", "Hockey" }
            },
            new Person {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "a@b.com",
                Birthday = DateTime.Now.AddYears(-25)
            },
            new Person {
                Id = 2,
                FirstName = "Juan",
                LastName = "Mejia",
                Email = "a@b.com",
                Birthday = DateTime.Now.AddYears(-25)
            },
            new Person {
                Id = 2,
                FirstName = "Jose",
                LastName = "Perez",
                Email = "a@b.com",
                Birthday = DateTime.Now.AddYears(-25)
            }
        };
    }
}
