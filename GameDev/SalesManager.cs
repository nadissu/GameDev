using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    class SalesManager : ISalesService
    {
        public void Buy(Product product, Gamer gamer)
        {
            Console.WriteLine(gamer.UserName+ "User"+product.Name+ "name is buy. ");
        }
    }
}
