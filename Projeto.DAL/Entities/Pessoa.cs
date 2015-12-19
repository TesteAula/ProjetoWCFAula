using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //ORM
using System.ComponentModel.DataAnnotations.Schema; //ORM

namespace Projeto.DAL.Entities
{
    [Table("PESSOA")]
    public class Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("IDPESSOA")]
        public int IdPessoa { get; set; }

        [Required]
        [StringLength(50)]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        [Column("SOBRENOME")]
        public string Sobrenome { get; set; }
    }
}
