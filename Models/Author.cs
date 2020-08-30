using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp.Models
{
    [Table("Author",Schema="cm")]
    public partial class Author
    {
        public Author()
        {
            this.Article = new HashSet<Article>();
        }
        [Key]
        [StringLength(128)]
        [DisplayName("Autor")]
        public string AuthorName { get; set; }
        [DisplayName("e-mail")]
        [DataType(DataType.EmailAddress)]
        public string AuthorMail { get; set; }
        [StringLength(256)]
        [DisplayName("Reseña")]
        public string AuthorReview { get; set; }

        public virtual ICollection<Article> Article { get; set; }
    }
}
