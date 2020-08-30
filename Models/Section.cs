using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp.Models
{
    [Table("Section",Schema ="cm")]
    public partial class Section
    {
        public Section()
        {
            this.Article = new HashSet<Article>();
        }
        [Key]
        [StringLength(16)]
        [DisplayName("ID de Sección")]
        public string SectionId { get; set; }
        [StringLength(128)]
        [DisplayName("Sección")]
        public string SectionName { get; set; }
        [DataType(DataType.MultilineText)]
        [DisplayName("Descripción")]
        public string Description { get; set; }

        public virtual ICollection<Article> Article { get; set; }
    }
}
