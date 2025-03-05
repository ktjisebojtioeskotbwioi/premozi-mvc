using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace premozi.Models
{
    public class Film
    {
        [Key, Column(TypeName = "int(11)"), DatabaseGenerated(DatabaseGeneratedOption.Identity), NotNull, Required, Editable(false)]
        public int id { get; set; }
        [Required,NotNull, Column(TypeName ="TEXT")]
        public string Cim { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Kategoria { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Mufaj { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Korhatar { get; set; }
        [Required, NotNull, Column(TypeName = "INT(4)")]
        public int Jatekido { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Gyarto { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Rendezo { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Szereplok { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Leiras { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Eredeti_nyelv { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Eredeti_cim { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string Szinkron { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string TrailerLink { get; set; }
        [Required, NotNull, Column(TypeName = "TEXT")]
        public string IMDB { get; set; }
        [Required, NotNull, Column(TypeName = "INT(11)")]
        public int AlapAr { get; set; }

    }
}
