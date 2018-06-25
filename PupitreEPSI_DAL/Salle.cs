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
    
    public partial class Salle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Salle()
        {
            this.Cours = new HashSet<Cour>();
            this.Salle_Equipement = new HashSet<Salle_Equipement>();
        }
    
        public int id { get; set; }
        public int etage { get; set; }
        public string intitulé { get; set; }
        public int numéro { get; set; }
        public int bâtiment { get; set; }
        public int capacité { get; set; }
    
        public virtual Batiment Batiment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cour> Cours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salle_Equipement> Salle_Equipement { get; set; }
    }
}