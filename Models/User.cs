using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace premozi.Models
{
    public class User
    {
        [Key, Column(TypeName = "int(11)"), DatabaseGenerated(DatabaseGeneratedOption.Identity),  NotNull, Required, Editable(false)]
        public int userID { get; private set; }
        [Column(TypeName = "varchar(20)"), Index(IsUnique = true), StringLength(20,ErrorMessage ="A felhasználónév 6 és 20 karakter hosszú lehet",MinimumLength=6), NotNull, Required]
        public string username { get; set; }
        //sha-256
        [Column(TypeName = "char(88)"), Length(88,88), DataType(DataType.Password), NotNull, Required]
        public string password { get; set; }
        [Column(TypeName = "varchar(100)"), Index(IsUnique = true), DataType(DataType.EmailAddress, ErrorMessage ="Valid Email-címet kell megadni"), NotNull, Required]
        public string email { get; set; }
        [Column(TypeName = "DateTime"), DatabaseGenerated(DatabaseGeneratedOption.Computed), DataType(DataType.DateTime), Editable(false), NotNull, Required, DefaultValue("UTC_TIMESTAMP()")]
        public DateTime creation_date { get; private set; }
        [Column(TypeName = "int(1)"), DatabaseGenerated(DatabaseGeneratedOption.Computed), DefaultValue(1), MaxLength(1), MinLength(1), NotNull, Required]
        public int account_status { get; private set; }
        [Column(TypeName = "int(1)"), DatabaseGenerated(DatabaseGeneratedOption.Computed), DefaultValue(2), MaxLength(1), MinLength(1), NotNull, Required]
        public int priviledges { get; private set; }
    }
}
