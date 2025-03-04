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
        [Key, Column(TypeName = "int(11)"), DatabaseGenerated(DatabaseGeneratedOption.Identity), NotNull, Required, Editable(false)]
        public int id { get; set; }
        public int Ferohely { get; set; }
        public string Tipus { get; set; }
    }
}
