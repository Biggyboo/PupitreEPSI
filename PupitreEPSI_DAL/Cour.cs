//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PupitreEPSI_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cour
    {
        public int id { get; set; }
        public int salle { get; set; }
        public System.TimeSpan heureDebut { get; set; }
        public System.TimeSpan heureFin { get; set; }
        public System.DateTime date { get; set; }
    
        public virtual Salle Salle1 { get; set; }
    }
}
