using System.ComponentModel.DataAnnotations;

namespace Hsf_Receitas.Models
{
    public class Medicacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Nome do medicamento é obrigatório! "), StringLength(80)]
        public string MedicationName { get; set; }

        [Required(ErrorMessage = " Dosagem do medicamento é obrigatória! "), StringLength(20)]
        public string MedicationDosage { get; set; }

        [Required(ErrorMessage = " Método de uso do medicamento é obrigatório! "), StringLength(20)]
        public string MedicationMethodUse { get; set; }

    }
}