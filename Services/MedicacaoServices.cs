using System.Collections.Generic;
using System.Linq;
using Hsf_Receitas.Models;
using Hsf_Receitas.Data;

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

    }
}