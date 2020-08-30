using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp.Models
{
    [Table("Article", Schema = "cm")]
    public partial class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID de artículo")]
        public int ArticleId { get; set; }
        [StringLength(128)]
        [DisplayName("Artículo")]
        public string ArticleName { get; set; }
        [ForeignKey("Section")]
        [StringLength(16)]
        [DisplayName("ID de Sección")]
        public string SectionId { get; set; }
        [StringLength(256)]
        [DisplayName("Resumen")]
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        [ForeignKey("Author")]
        [StringLength(128)]
        [DisplayName("Autor")]
        public string AuthorName { get; set; }
        [DisplayName("Artículo")]
        [DataType(DataType.MultilineText)]
        public string ArticleText { get; set; }

        public virtual Author Author { get; set; }
        public virtual Section Section { get; set; }
    }
}
