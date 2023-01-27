using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SLNClinica.Models
{
    public class Medico
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Apellido { get; set; }

        [RegularExpression("@^[A-Z]{2}[0-9]{4}")]
        public int Matricula { get; set; }

    }
}
