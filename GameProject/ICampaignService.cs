using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaing campaing, Order order);
        void Update(Campaing campaing, Order order);
        void Delete(Campaing campaing, Order order);

    }
}
