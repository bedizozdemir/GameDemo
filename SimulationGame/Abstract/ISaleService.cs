using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entity;


namespace GameDemo.Abstract
{
    public interface ISaleService
    {
        void Add(Player player, Sale sale, Campaign campaign);
        void Update(Player player, Sale sale, Campaign campaign);
        void Delete(Player player, Sale sale, Campaign campaign);
    }
}
