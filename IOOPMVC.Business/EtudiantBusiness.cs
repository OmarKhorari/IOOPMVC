using IOOPMVC.Business.Interfaces;
using IOOPMVC.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOOPMVC.Business
{
    public class EtudiantBusiness : IEtudiantBusiness
    {
        public List<EtudiantDomainModel> GetAllStudents()
        {
            List<EtudiantDomainModel> studentslist = new List<EtudiantDomainModel>();
            studentslist.Add(new EtudiantDomainModel { EtudiantID = 1, EtudiantFN = "Omar", EtudiantLN = "Khorari" });
            studentslist.Add(new EtudiantDomainModel { EtudiantID = 2, EtudiantFN = "Ismael", EtudiantLN = "Khorari" });
            studentslist.Add(new EtudiantDomainModel { EtudiantID = 3, EtudiantFN = "Youssef", EtudiantLN = "Khorari" });
            studentslist.Add(new EtudiantDomainModel { EtudiantID = 4, EtudiantFN = "Sofie", EtudiantLN = "Khorari" });
            studentslist.Add(new EtudiantDomainModel { EtudiantID = 5, EtudiantFN = "Mariam", EtudiantLN = "Hilmi" });
            return studentslist;
        }

        public string GetStudantName(int id)
        {
            return "Business Student Name : " + id;
        }
    }
}
