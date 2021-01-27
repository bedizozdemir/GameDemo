using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entity
{
    class Sale : IEntity
    {
        public int SaleId { get; set; }
        public string SaleName { get; set; }
    }
}
