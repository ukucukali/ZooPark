using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Data
{
    [Table("Food")]
    public class Food
    {
        public Food()
        {
            Animals = new List<Animal>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime ManufactureDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        [Required,Range(0.0d,2000.0d,ErrorMessage ="Callorie should be in a range 0-2000")]
        public decimal? Calories { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
