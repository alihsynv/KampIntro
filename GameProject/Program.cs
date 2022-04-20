using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValitationManager());
            gamerManager.Register(new Gamer
            {
                Id = 1,
                BirtYear = 2002,
                FirstName = "ALI",
                LastName = "HUSEYNOV",
                IdentityNumber = 123456,
            });
        }
    }
}
