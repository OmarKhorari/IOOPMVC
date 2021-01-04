using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Inscription
    {
        public Inscription()
        {
            Paiement = new HashSet<Paiement>();
        }

        public int IdInscription { get; set; }
        public DateTime DateInscription { get; set; }
        public double? Montant { get; set; }
        public int? IdEtudiant { get; set; }
        public int? IdModule { get; set; }
        public int? IdAnneeScolaire { get; set; }

        public virtual ICollection<Paiement> Paiement { get; set; }
    }
}
