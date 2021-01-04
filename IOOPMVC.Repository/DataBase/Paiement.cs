using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class Paiement
    {
        public int IdPaiement { get; set; }
        public double? Montant { get; set; }
        public int? IdModePaiement { get; set; }
        public int? IdInscription { get; set; }
        public DateTime? DatePaiement { get; set; }

        public virtual Inscription IdInscriptionNavigation { get; set; }
        public virtual ModePaiement IdModePaiementNavigation { get; set; }
    }
}
