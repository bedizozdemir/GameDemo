using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    class BaseSaleManager
    {
        public void Add(Player player, Sale sale, Campaign campaign);
        public void Delete(Player player, Sale sale, Campaign campaign);
        public void Update(Player player, Sale sale, Campaign campaign);
    }
}
