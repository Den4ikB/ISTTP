using System;
using System.Collections.Generic;

#nullable disable

namespace ISTTP1
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GameId { get; set; }
        public int Ammount { get; set; }

        public virtual Game Game { get; set; }
        public virtual Order Order { get; set; }
    }
}
