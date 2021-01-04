using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class InscriptionViewModel
    {
        public InscriptionViewModel()
        {
            Paiement = new HashSet<PaiementViewModel>();
        }

        public int IdInscription { get; set; }
        public DateTime DateInscription { get; set; }
        public double? Montant { get; set; }
        public int? IdEtudiant { get; set; }
        public int? IdModule { get; set; }
        public int? IdAnneeScolaire { get; set; }

        public virtual ICollection<PaiementViewModel> Paiement { get; set; }
    }
}
