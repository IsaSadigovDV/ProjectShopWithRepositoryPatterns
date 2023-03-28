using ProjectShop.Data.Repositories.ShopRepository;
using ProjectShop.Service.Services.Interfaces.ShopService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectShop.Service.Services.Implementations.ShopService
{
    public class ShopService : IShopService
    {
        private readonly IShopRepository _shopRepository = new ShopRepository();
        public void Create()
        {
            Shop shop = new Shop();
            Console.WriteLine("Please add shop name");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Please add shop name correctly");
                name = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            shop.Name = name;
            _shopRepository.Create(shop);
        }

        public void Delete()
        {
            Console.WriteLine("Please enter id to delete a shop");
            int.TryParse(Console.ReadLine(), out int id);

            while(id == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red ;
                Console.WriteLine("Please enter valid id number");
                int.TryParse(Console.ReadLine(), out id);
            }

            Shop shop = _shopRepository.Get(x => x.Id == id);

            if(shop == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter valid id number");
                return;
            }

            Console.ForegroundColor = ConsoleColor.White;
            _shopRepository.Delete(shop);

        }

        public void Get()
        {
            //delete ile eyni tapmaq usulu
            Console.WriteLine("Please enter id to get a shop");
            int.TryParse(Console.ReadLine(), out int id);

            while (id == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter valid id number");
                int.TryParse(Console.ReadLine(), out id);
            }

            Shop shop = _shopRepository.Get(x => x.Id == id);

            if (shop == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter valid id number");
                return;
            }
            //bura qeder
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Id: {shop.Id} Shop Name: {shop.Name}");
        }

        public void GetAll()
        {
            List<Shop> shops = _shopRepository.GetAll();
            shops.ForEach(x =>
            {
                Console.WriteLine($"Id: {x.Id} Name: {x.Name}");
            });
        }

        public void Update()
        {
            //Get metodu ile eynidir yoxlamalar
            Console.WriteLine("Please enter id to update a shop");
            int.TryParse(Console.ReadLine(), out int id);

            while (id == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter valid id number");
                int.TryParse(Console.ReadLine(), out id);
            }

            Shop shop = _shopRepository.Get(x => x.Id == id);

            if (shop == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter valid id number");
                return;
            }
            //bura qeder

            Console.WriteLine("New Name:");
            string name = Console.ReadLine();
            // bu hissede yoxlamalar olmalidi isNullorWhiteSpace ve.s

            shop.Name = name;
            _shopRepository.Update(shop);



        }
    }
}
