using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrenteDeLoja.Models
{
    [Table("TB_FDL_USUARIO")]
    public class Usuario
    {
        public Usuario() { }

        [Key]
        [Required]
        [Column("ID_USUARIO")]
        public int Id { get; set; }
        [Column("DS_LOGIN")]
        public string LoginUsuario { get; set; }
        [Column("DS_SENHA")]
        public string SenhaUsuario { get; set; } 

    }
}
