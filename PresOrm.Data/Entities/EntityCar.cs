using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PresOrm.Data.Entities
{
    [Table("Car")]
    [Index(nameof(Name), IsUnique = true, AllDescending = true)]
    public class EntityCar
    {
        [Key]
        public long CarId { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [Required]
        public DateOnly ModelYear { get; set; }

        [ForeignKey(nameof(Brand))]
        public long BrandId { get; set; }

        public virtual EntityBrand Brand { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name}\t\t{CarId}\t\t{Name}\t\t{ModelYear}\t\t{Brand.Name}";
        }
    }
}
