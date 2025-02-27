using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace premozi.Models
{
    public class Felhasznalok
    {
        [Key, Column(TypeName = "int(11)"), DatabaseGenerated(DatabaseGeneratedOption.Identity),  NotNull, Required, Editable(false),]
        public int userID { get; private set; }
        [Column(TypeName = "varchar(20)"), Index(IsUnique = true), Length(6,20), NotNull, Required]
        public string username { get; private set; }
        //sha-256
        [Column(TypeName = "char(64)"), Length(64,64), DataType(DataType.Password), NotNull, Required]
        public string password { get; private set; }
        [Column(TypeName = "varchar(100)"), Index(IsUnique = true), DataType(DataType.EmailAddress), NotNull, Required]
        public string email { get; private set; }
        [Column(TypeName = "DateTime"), DataType(DataType.DateTime), Editable(false), NotNull, Required, DefaultValue("getutcdate()")]
        public DateTime creation_date { get; private set; }
        [Column(TypeName = "int(1)"), DefaultValue(1), MaxLength(1), MinLength(1), NotNull, Required]
        public int account_status { get; private set; }
    }
}
