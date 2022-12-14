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
    
    public partial class Produit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit()
        {
            this.Bon_Destruction_Produit = new HashSet<Bon_Destruction_Produit>();
            this.Bon_Entree_Produit = new HashSet<Bon_Entree_Produit>();
            this.Bon_Sortie_Produit = new HashSet<Bon_Sortie_Produit>();
            this.Facture_Achat_Bonus = new HashSet<Facture_Achat_Bonus>();
            this.Facture_Achat_Produit = new HashSet<Facture_Achat_Produit>();
            this.Facture_Achat_Produit_Retour = new HashSet<Facture_Achat_Produit_Retour>();
            this.Facture_Vente_Bonus = new HashSet<Facture_Vente_Bonus>();
            this.Facture_Vente_Produit = new HashSet<Facture_Vente_Produit>();
            this.Facture_Vente_Produit_Retour = new HashSet<Facture_Vente_Produit_Retour>();
            this.Produit_Barcode = new HashSet<Produit_Barcode>();
            this.Produit_Emplacement = new HashSet<Produit_Emplacement>();
            this.Produit_Image = new HashSet<Produit_Image>();
        }
    
        public string prd_Code { get; set; }
        public string prd_Nom { get; set; }
        public Nullable<int> prd_Nbr_Min { get; set; }
        public Nullable<int> prd_Nbr_Max { get; set; }
        public Nullable<int> prd_Nbr_Limit { get; set; }
        public Nullable<decimal> prd_Prix_Achat { get; set; }
        public Nullable<decimal> prd_Prix_Vente { get; set; }
        public Nullable<decimal> prd_Prix_Avg { get; set; }
        public Nullable<decimal> prd_Prix_Gros { get; set; }
        public Nullable<decimal> prd_Prix_Coutant { get; set; }
        public Nullable<decimal> prd_Escompte { get; set; }
        public Nullable<int> prd_Escompte_Pourc { get; set; }
        public Nullable<int> prd_Tax_Pourc { get; set; }
        public Nullable<bool> prd_Status { get; set; }
        public string prd_Note { get; set; }
        public string typ_Code { get; set; }
        public string sec_Code { get; set; }
        public string unt_M_Code { get; set; }
        public string box_Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Destruction_Produit> Bon_Destruction_Produit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Entree_Produit> Bon_Entree_Produit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Sortie_Produit> Bon_Sortie_Produit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Achat_Bonus> Facture_Achat_Bonus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Achat_Produit> Facture_Achat_Produit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Achat_Produit_Retour> Facture_Achat_Produit_Retour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Vente_Bonus> Facture_Vente_Bonus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Vente_Produit> Facture_Vente_Produit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Vente_Produit_Retour> Facture_Vente_Produit_Retour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit_Barcode> Produit_Barcode { get; set; }
        public virtual Produit_Detail Produit_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit_Emplacement> Produit_Emplacement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit_Image> Produit_Image { get; set; }
        public virtual Produit_Boxe Produit_Boxe { get; set; }
        public virtual Produit_Section Produit_Section { get; set; }
        public virtual Produit_Type Produit_Type { get; set; }
        public virtual Unite_Mesure Unite_Mesure { get; set; }
    }
}
