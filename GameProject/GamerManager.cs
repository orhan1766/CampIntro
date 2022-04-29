using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;
        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }
        public void Add(Gamer gamer)
        {
            if (_validationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayit oldu");
            }
            else
            {
                Console.WriteLine("Dogrulama basarisiz.Kayit olunamadi.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated.");
        }
    }
}
