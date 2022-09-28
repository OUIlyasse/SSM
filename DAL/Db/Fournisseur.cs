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
    
    public partial class Fournisseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fournisseur()
        {
            this.Compte_Fournisseur = new HashSet<Compte_Fournisseur>();
            this.Facture_Achat = new HashSet<Facture_Achat>();
            this.Facture_Achat_Retour = new HashSet<Facture_Achat_Retour>();
            this.Operation_Facture_Achat = new HashSet<Operation_Facture_Achat>();
            this.Operation_Facture_Achat_Retour = new HashSet<Operation_Facture_Achat_Retour>();
        }
    
        public string frns_Code { get; set; }
        public string frns_Nom { get; set; }
        public string frns_Surnom { get; set; }
        public Nullable<System.DateTime> frns_Date { get; set; }
        public string frns_Nature { get; set; }
        public string frns_Adresse { get; set; }
        public string frns_Tele { get; set; }
        public string frns_Tele2 { get; set; }
        public string frns_Tax_Num { get; set; }
        public Nullable<bool> frns_Status { get; set; }
        public string frns_Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compte_Fournisseur> Compte_Fournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Achat> Facture_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Achat_Retour> Facture_Achat_Retour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Facture_Achat> Operation_Facture_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Facture_Achat_Retour> Operation_Facture_Achat_Retour { get; set; }
    }
}
