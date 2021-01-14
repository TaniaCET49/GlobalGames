using Microsoft.AspNetCore.Identity;
using GlobalGames.Data.Entidades;
using GlobalGames.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace GlobalGames.Data
{
    public class SeedDb
    {

        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();

        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("taniaisantos26@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "´Tania",
                    LastName = "Santos",
                    Email = "taniaisantos26@gmail.com",
                    UserName = "taniaisantos26@gmail.com",
                    PhoneNumber = "918035371"
                };

                var result = await this.userHelper.AddUserAsync(user, "123456");

                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Nao conseguiu criar o utilizador na seed");
                }

            }

            if (!this.context.UserLogin.Any())
            {
                this.AddUserLogin("Ana", user);
                this.AddUserLogin("João", user);
                this.AddUserLogin("Isabel", user);
                this.AddUserLogin("António", user);
                this.AddUserLogin("Patrícia", user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddUserLogin(string name, User user)
        {
            this.context.UserLogin.Add(new UserLogin
            {
                Name = name,
                User = user
            });
        }
    }
}

