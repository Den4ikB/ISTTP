using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ISTTPLab1
{
    public partial class Game
    {
        public Game()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        [Display(Name = "Назва")]
        [Required(ErrorMessage = "Поле не повино бути порожнім")]
        public string Name { get; set; }

        [Display(Name = "Жанр")]
        public int GenreId { get; set; }

        [Display(Name = "Рік випуску")]
        [Required(ErrorMessage = "Поле не повино бути порожнім")]
        public int ReleaseYear { get; set; }

        [Display(Name = "Ціна")]
        [Range(0, 200000)]
        [Required(ErrorMessage = "Поле не повино бути порожнім")]
        public decimal Price { get; set; }

        [Display(Name = "Додаткова інформація")]
        public string GeneralInfo { get; set; }

        [Display(Name = "Жанр")]
        public virtual Genre Genre { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
