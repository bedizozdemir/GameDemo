using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GameDemo.Abstract;
using GameDemo.Entity;

namespace GameDemo.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPlayer(Player player);
    }
}
