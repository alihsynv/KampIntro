using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Register deleted");
        }

        public void Register(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Registered");
            }
            else
            {
                Console.WriteLine("Validation failed. Registration failed");
            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Register updated");
        }
    }
}
