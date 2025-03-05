using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace premozi.Models
{
    public class Vetites
    {
        [Key, Column(TypeName = "int(5)"), DatabaseGenerated(DatabaseGeneratedOption.Identity), NotNull, Required, Editable(false)]
        public int id { get; set; }
        [Column(TypeName = "int(11)"), NotNull, Required, ForeignKey("Film(id)")]
        public int FilmID { get; set; }
        [Column(TypeName = "DateTime"), NotNull, Required]
        public DateTime Idopont { get; set; }
        [Column(TypeName = "int(5)"), NotNull, Required, ForeignKey("Terem(id)")]
        public int TeremID { get; set; }
        [Column(TypeName = "longtext"), AllowNull]
        public string Megjegyzes { get; set; }
        public virtual Film Film { get; set; }
        public virtual Terem Terem { get; set; }
    }
}
