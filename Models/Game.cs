using System;
using System.Collections.Generic;

#nullable disable

namespace ISTTP1
{
    public partial class Game
    {
        public Game()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int ReleaseYear { get; set; }
        public decimal Price { get; set; }
        public string GeneralInfo { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
