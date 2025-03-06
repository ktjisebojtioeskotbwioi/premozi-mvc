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
        [Column(TypeName = "int(11)"), NotNull, Required, ForeignKey("User(userID)")]
        public string UserID { get; set; }
        [Column(TypeName = "text"), NotNull, Required, DataType(DataType.Text, ErrorMessage = "Váratlan hiba történt (hely)")]
        public int Hely { get; set; }
        [Column(TypeName ="int(1)"), DatabaseGenerated(DatabaseGeneratedOption.Computed), NotNull, Required, DataType(DataType.Text, ErrorMessage = "Váratlan hiba történt (státusz)"), DefaultValue(1)]
        public int Statusz { get; set; }
        [Column(TypeName = "longtext"), AllowNull, DataType(DataType.Text, ErrorMessage = "Hiba történt a megjegyzés hozzáadása során")]
        public string Megjegyzes { get; set; }
        public virtual User User { get; set; }
        public virtual Vetites Vetites { get; set; }
    }
}
