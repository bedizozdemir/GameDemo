using System;
using System.Text;
using System.Threading.Tasks;
using GameDemo.Abstract;
using GameDemo.Entity;

namespace GameDemo.Concrete
{
    public class PlayerCheckManager : IPlayerCheckService
    {

        bool IPlayerCheckService.CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
