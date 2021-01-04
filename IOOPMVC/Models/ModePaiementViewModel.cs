using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class ModePaiementViewModel
    {
        public ModePaiementViewModel()
        {
            Paiement = new HashSet<PaiementViewModel>();
        }

        public int IdModePaiement { get; set; }
        public string NomModePaiement { get; set; }

        public virtual ICollection<PaiementViewModel> Paiement { get; set; }
    }
}
