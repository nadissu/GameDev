using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    class BaseGamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted");
        }

        public void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer Saved"+gamer.Name);   
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name+ " Gamer Updated ");
        }
    }
}
