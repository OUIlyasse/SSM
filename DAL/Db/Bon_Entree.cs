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
    
    public partial class Bon_Entree
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Entree()
        {
            this.Bon_Entree_Produit = new HashSet<Bon_Entree_Produit>();
            this.Operation_Bon_Entree_Magasin = new HashSet<Operation_Bon_Entree_Magasin>();
        }
    
        public string bon_E_Code { get; set; }
        public Nullable<System.DateTime> bon_E_Date { get; set; }
        public Nullable<System.TimeSpan> bon_E_Temps { get; set; }
        public string bon_E_Text { get; set; }
        public Nullable<int> bon_E_Status { get; set; }
        public string bon_E_Note { get; set; }
        public string fact_A_Code { get; set; }
        public string bon_T_Code { get; set; }
    
        public virtual Bon_Type Bon_Type { get; set; }
        public virtual Facture_Achat Facture_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Entree_Produit> Bon_Entree_Produit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Bon_Entree_Magasin> Operation_Bon_Entree_Magasin { get; set; }
    }
}
