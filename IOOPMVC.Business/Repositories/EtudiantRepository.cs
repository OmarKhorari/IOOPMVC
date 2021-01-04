using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using IOOPMVC.Business.Interfaces;
using IOOPMVC.Repository.DataBase;
using Microsoft.EntityFrameworkCore;

namespace IOOPMVC.Business.Repositories
{
    public class EtudiantRepository : GenericRepository<Etudiant>, IEtudiantRepository
    {
        public EtudiantRepository(IOOPPContext repositoryPatternDemoContext) : base(repositoryPatternDemoContext)
        {
        }


        public Task<Etudiant> GetEtudiantByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.IdEtudiant == id);
        }
    }
}
