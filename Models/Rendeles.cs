using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace premozi.Models
{
    public class Rendeles
    {
        [Key, Column(TypeName = "int(11)"), DatabaseGenerated(DatabaseGeneratedOption.Identity), NotNull, Required, Editable(false)]
        public int id { get; set; }
        [Column(TypeName = "int(11)"), NotNull, Required, ForeignKey("Vetites(id)")]
        public int VetitesID { get; set; }
        [Column(TypeName = "text"), NotNull, Required, ForeignKey("User(userID)")]
        public string UserID { get; set; }
        [Column(TypeName = "text"), NotNull, Required]
        public int Hely { get; set; }
        [Column(TypeName ="text"), NotNull, Required]
        public string Statusz { get; set; }
        [Column(TypeName = "longtext"), AllowNull]
        public string Megjegyzes { get; set; }
        public virtual User User { get; set; }
        public virtual Vetites Vetites { get; set; }
    }
}
