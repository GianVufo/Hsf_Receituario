using Hsf_Receitas.Models;
using Hsf_Receitas.Data;

namespace Hsf_Receitas.Services
{
    public class ReceituarioServices
    {
        public void AddReceita(Receituario novaReceita)
        {
            HSFContext database = new HSFContext();
            database.Receitas.Add(novaReceita);
            database.SaveChanges();
        }

        public void EditReceita (Receituario editreceita)
        {

            using HSFContext database = new HSFContext();

            Receituario rec = database.Receitas.Find(editreceita.Id);

            rec.PacientName = editreceita.PacientName;
            rec.DoctorName = editreceita.DoctorName;
            rec.DateOfMedicalAppoiment = editreceita.DateOfMedicalAppoiment;

            database.SaveChanges();
        
        }

        public Receituario SearchForId(int id)
        {
            using HSFContext dataBase = new HSFContext();
            return dataBase.Receitas.Find(id);
        }

    }
}