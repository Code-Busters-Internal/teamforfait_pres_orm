using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PresOrm.Data.Entities
{
    [Table("Brand")]
    [Index(nameof(Name), IsUnique = true, AllDescending = true)]
    public class EntityBrand
    {

        [Key]
        public long BrandId { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [InverseProperty("Brand")]
        public virtual ICollection<EntityCar> Cars { get; set; }


        public override string ToString()
        {
            return $"{GetType().Name}\t\t{BrandId}\t\t{Name}";
        }
    }
}
