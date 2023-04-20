using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hsf_Receitas.Models
{
    public class Receituario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = " Nome do paciente é obrigatório! "), StringLength(80)]
        public string PacientName { get; set; }

        [Required(ErrorMessage = " Nome do médico é obrigatório! "), StringLength(80)]
        public string DoctorName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfMedicalAppoiment { get; set; }

        public Medicacao Medicacao { get; set; }

        [ForeignKey("MedicacaoId")]
        public int MedicacaoId { get; set; }

    }
}