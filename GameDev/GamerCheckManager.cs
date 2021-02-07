using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
