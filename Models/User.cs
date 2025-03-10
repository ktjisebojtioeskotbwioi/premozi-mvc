﻿using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace premozi.Models
{
    [Microsoft.EntityFrameworkCore.Index(nameof(email),IsUnique =true), Microsoft.EntityFrameworkCore.Index(nameof(username), IsUnique = true)]
    public class User
    {
        [Key, Column(TypeName = "int(11)"), DatabaseGenerated(DatabaseGeneratedOption.Identity),  NotNull, Required, Editable(false)]
        public int userID { get; private set; }
        [Column(TypeName = "varchar(20)"), DataType(DataType.Text, ErrorMessage = "A felhasználónév csak alfanumerikus karaktereket tartalmazhat"), StringLength(20,ErrorMessage ="A felhasználónév 6 és 20 karakter hosszú lehet",MinimumLength=6), NotNull, Required]
        public string username { get; set; }
        //sha-512 hex
        [Column(TypeName = "char(88)"), Length(88,88), DataType(DataType.Password, ErrorMessage ="Nem várt hiba történt"), NotNull, Required]
        public string password { get; set; }
        [Column(TypeName = "varchar(100)"), DataType(DataType.EmailAddress, ErrorMessage ="Valid Email-címet kell megadni"), NotNull, Required]
        public string email { get; set; }
        [Column(TypeName = "DateTime"), DataType(DataType.DateTime, ErrorMessage = "Nem várt hiba történt"), Editable(false), NotNull, Required]
        public DateTime creation_date { get; private set; } = DateTime.UtcNow;
        [Column(TypeName = "int(1)"), MaxLength(1), MinLength(1), NotNull, Required]
        public int account_status { get; private set; } = 1;
        [Column(TypeName = "int(1)"), MaxLength(1), MinLength(1), NotNull, Required]
        public int priviledges { get; private set; } = 2;
        [Column(TypeName = "longtext"), NotNull, DataType(DataType.Text, ErrorMessage = "Hiba történt a megjegyzés hozzáadása során")]
        public string Megjegyzes { get; set; } = "Nincs megjegyzés";
    }
}
