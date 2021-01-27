using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entity
{
    class Player : Abstract.IEntity
    {
        public int Id { get; set; }
        public string IdentityNum { get; set; } //TC
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

    }
}
