using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace premozi.Models
{
    public class Terem
    {
        [Key, Column(TypeName = "int(5)"), DatabaseGenerated(DatabaseGeneratedOption.Identity), NotNull, Required, Editable(false)]
        public int id { get; set; }
        [Column(TypeName ="int(3)"), NotNull, Required]
        public int Ferohely { get; set; }
        [Column(TypeName ="text"), NotNull, Required]
        public string Tipus { get; set; }
        [Column(TypeName ="int(3)"), NotNull, Required]
        public int Sorok { get; set; }
        [Column(TypeName ="longtext"), NotNull, Required]
        public string Allapot { get; set; }
        [Column(TypeName = "longtext"), AllowNull]
        public string Megjegyzes { get; set; }
    }
}
