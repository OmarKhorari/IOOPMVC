using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IOOPMVC.Repository.DataBase;

namespace IOOPMVC.Business.Interfaces
{
    public interface IEtudiantRepository
    {
        Task<Etudiant> GetEtudiantByIdAsync(int id);
    }
}
