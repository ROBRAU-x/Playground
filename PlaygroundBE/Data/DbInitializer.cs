using PlaygroundBE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundBE.Data
{
    public class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{userName="Carson",passWord="Alexander" },
                new User{userName="Meredith",passWord="Alonso"},
                new User{userName="Arturo",passWord="Anand"},
                new User{userName="Gytis",passWord="Barzdukas"},
                new User{userName="Yan",passWord="Li"},
                new User{userName="Peggy",passWord="Justice"},
                new User{userName="Laura",passWord="Norman"},
                new User{userName="Nino",passWord="Olivetto"}
            };

            context.User.AddRange(users);
            context.SaveChanges();
        }
        }
}
