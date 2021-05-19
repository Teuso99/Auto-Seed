using AutoSeed.Models;
using Bogus;
using Bogus.Extensions.Brazil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSeed.Data
{
    public static class SeedData
    {

        public static List<User> Users = new List<User>();

        public static void Init(int count)
        {
            var userId = 1;

            var userFaker = new Faker<User>(locale: "pt_BR")
                .RuleFor(u => u.Id, _ => userId++)
                .RuleFor(u => u.Nome, f => f.Name.FullName())
                .RuleFor(u => u.Cpf, f => f.Person.Cpf())
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Nome));

            var users = userFaker.Generate(count);

            SeedData.Users.AddRange(users);
        }
    }
}
