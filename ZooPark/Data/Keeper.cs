using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Data
{
    [Table("Keepers")]
    public class Keeper
    {
        public Keeper()
        {
            Animals = new List<Animal>();
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required,MaxLength(100)]
        public string SurName { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
