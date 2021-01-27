using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entity
{
    class Campaign : IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
    }
}
