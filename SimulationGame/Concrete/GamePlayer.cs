using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Abstract;
using System.Linq;
using System.Threading.Tasks;
using GameDemo.Entity;

namespace GameDemo.Concrete
{
    class GamePlayer : BasePlayerManager
    {
        private IPlayerCheckService playerCheckService;

        public GamePlayer(IPlayerCheckService playerCheckService)
        {
            this.playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (playerCheckService.CheckIfRealPlayer(player))
            {
                base.Add(player);
                Console.WriteLine(player.FirstName+" "+player.LastName +" added.");
            }
            else
            {
                throw new Exception("Not a valid person!");
            }
        }

        private void CheckIfRealPlayer(Player player)
        {
       
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " deleted.");
        }
        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " updated.");
        }
    }
}
