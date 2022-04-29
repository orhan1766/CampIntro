using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaingManager : ICampaignService
    {
        public void Add(Campaing campaing, Order order)
        {
            Console.WriteLine("Kampanya eklendi " + campaing.Name + "Kampanyali fiyatiniz: " + order.UnitPrice * campaing.DiscountRate);
        }

        public void Delete(Campaing campaing,Order order)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaing campaing, Order order)
        {
            Console.WriteLine("Kampanya guncellendi");
        }
    }
}
