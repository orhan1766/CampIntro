using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1990, FirstName = "orhan", LastName = "dogan", IdentityNumber = 12345 });

            OrderManager orderManager = new OrderManager(new CampaingManager());
            orderManager.Calculate(new Campaing { Id = 1, Name = "Yaz indirimi", DiscountRate = 0.5f }, new Order { Id = 1, UnitPrice = 120 });
        }
    }
}
