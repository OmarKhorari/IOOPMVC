using System;
using System.Collections.Generic;

namespace IOOPMVC.Repository.DataBase
{
    public partial class ModePaiement
    {
        public ModePaiement()
        {
            Paiement = new HashSet<Paiement>();
        }

        public int IdModePaiement { get; set; }
        public string NomModePaiement { get; set; }

        public virtual ICollection<Paiement> Paiement { get; set; }
    }
}
