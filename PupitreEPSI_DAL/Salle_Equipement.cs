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
    
    public partial class Salle_Equipement
    {
        public int idSalle { get; set; }
        public int idEquipement { get; set; }
        public int nbEquipement { get; set; }
    
        public virtual Equipement Equipement { get; set; }
        public virtual Salle Salle { get; set; }
    }
}
