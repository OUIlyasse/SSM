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
    
    public partial class Branche
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Branche()
        {
            this.Devise = new HashSet<Devise>();
            this.Employee = new HashSet<Employee>();
            this.Magasin_Branche = new HashSet<Magasin_Branche>();
            this.Main_Caisse = new HashSet<Main_Caisse>();
            this.Operation_Facture_Achat = new HashSet<Operation_Facture_Achat>();
            this.Operation_Facture_Achat_Retour = new HashSet<Operation_Facture_Achat_Retour>();
            this.Operation_Facture_Vente = new HashSet<Operation_Facture_Vente>();
            this.Operation_Facture_Vente_Retour = new HashSet<Operation_Facture_Vente_Retour>();
            this.Operation_Recu_Achat = new HashSet<Operation_Recu_Achat>();
            this.Operation_Recu_Vente = new HashSet<Operation_Recu_Vente>();
        }
    
        public string bran_Code { get; set; }
        public string bran_Nom { get; set; }
        public string bran_Adresse { get; set; }
        public string bran_Tele { get; set; }
        public string bran_Mobile { get; set; }
        public Nullable<System.DateTime> bran_Date_Creation { get; set; }
        public Nullable<bool> bran_Status { get; set; }
        public string bran_Note { get; set; }
        public string entr_Code { get; set; }
        public string bran_Ville { get; set; }
        public string bran_Pays { get; set; }
    
        public virtual Entreprise_Info Entreprise_Info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devise> Devise { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Magasin_Branche> Magasin_Branche { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Main_Caisse> Main_Caisse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Facture_Achat> Operation_Facture_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Facture_Achat_Retour> Operation_Facture_Achat_Retour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Facture_Vente> Operation_Facture_Vente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Facture_Vente_Retour> Operation_Facture_Vente_Retour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Recu_Achat> Operation_Recu_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Recu_Vente> Operation_Recu_Vente { get; set; }
    }
}
