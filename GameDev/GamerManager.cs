using System;
using System.Collections.Generic;
using System.Text;

namespace GameDev
{
    class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public new void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

        }
    }
}
