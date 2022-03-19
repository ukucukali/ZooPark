using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark.Data
{
    [Table("Animals")]
    public class Animal
    {
        public Animal()
        {
            Keepers = new List<Keeper>(); 
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(200, ErrorMessage = "Name cannot be longer than 200 ")]
        public string Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public bool HavingOwner { get; set; }
        [Required]
        public DateTime? DOB { get; set; }
        public decimal Mass { get; set; }
        [Required]
        public string Species { get; set; }
        //[ForeignKey("Food")] if dont use foodid as a tradititon
        public int? FoodId { get; set; }
        public virtual Food Food { get; set; }
        public virtual ICollection<Keeper> Keepers { get; set; }
    }
    public enum Gender
    {
        Male, Female, notKnown
    }
}
