using System;
using System.Collections.Generic;

namespace IOOPMVC.Models
{
    public partial class PaiementViewModel
    {
        public int IdPaiement { get; set; }
        public double? Montant { get; set; }
        public int? IdModePaiement { get; set; }
        public int? IdInscription { get; set; }
        public DateTime? DatePaiement { get; set; }

        public virtual InscriptionViewModel IdInscriptionNavigation { get; set; }
        public virtual ModePaiementViewModel IdModePaiementNavigation { get; set; }
    }
}
