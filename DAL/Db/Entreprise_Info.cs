//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entreprise_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entreprise_Info()
        {
            this.Branche = new HashSet<Branche>();
        }
    
        public string entr_Code { get; set; }
        public string entr_Nom { get; set; }
        public string entr_Adresse { get; set; }
        public string entr_Ville { get; set; }
        public string entr_Pays { get; set; }
        public string entr_Code_Postal { get; set; }
        public string entr_Tele1 { get; set; }
        public string entr_Tele2 { get; set; }
        public string entr_Email { get; set; }
        public string entr_Whatsapp { get; set; }
        public string entr_Fax { get; set; }
        public string entr_Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branche> Branche { get; set; }
    }
}
