using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class ModuleViewModel
    {
        public ModuleViewModel()
        {
            Matiere = new HashSet<MatiereViewModel>();
        }

        public int IdModule { get; set; }
        public string NomModule { get; set; }

        public virtual ICollection<MatiereViewModel> Matiere { get; set; }
    }
}
