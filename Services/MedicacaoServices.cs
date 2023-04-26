using Hsf_Receitas.Models;
using Hsf_Receitas.Data;
using System.Linq;
using System.Collections.Generic;

namespace Hsf_Receitas.Services
{
    public class MedicacaoServices
    {
        public void AddMedicacao (Medicacao novaMedicacao)
        {
            using HSFContext database = new HSFContext();

            database.Medicamentos.Add(novaMedicacao);
            database.SaveChanges();
        }

        public List<Medicacao> ListMedication()
        {
            using HSFContext database = new HSFContext();
            return database.Medicamentos.ToList();
        }

        public List<Medicacao> ListMedicationPrescriptions(int id)
        {
            using HSFContext database = new HSFContext();

            Receituario rec = new Receituario();

            List<Medicacao> foundMedication = database.Medicamentos.Where(m => m.ReceituarioId == id).ToList();

            return foundMedication;
        }

    }
}