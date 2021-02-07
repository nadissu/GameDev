using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    interface IGamerService
    {
        void Save(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
        
    }
}
