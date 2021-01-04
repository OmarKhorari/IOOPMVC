using System;
using System.Collections.Generic;
using System.Text;
using IOOPMVC.Domain;

namespace IOOPMVC.Business.Interfaces
{
    public interface IEtudiantBusiness
    {
        string GetStudantName(int id);
        List<EtudiantDomainModel> GetAllStudents();
    }
}
