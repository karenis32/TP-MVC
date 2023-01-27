using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEscuelaMVC.Validations;

namespace WebEscuelaMVC.Models
{
    public class Aula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MayorACienAttribute]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string Estado { get; set;}
    }
}
