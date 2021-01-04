using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOOPMVC.Domain;
using IOOPMVC.Models;

namespace IOOPMVC.Infrastructure
{
    public class AutoMaperWebProfile : AutoMapper.Profile
    {
        public AutoMaperWebProfile()
        {
            CreateMap<EtudiantDomainModel, EtudiantViewModel>();
        }
    }
}
