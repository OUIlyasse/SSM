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
    
    public partial class Recu_Achat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recu_Achat()
        {
            this.Operation_Recu_Achat = new HashSet<Operation_Recu_Achat>();
        }
    
        public string recu_A_Code { get; set; }
        public Nullable<System.DateTime> recu_A_Date { get; set; }
        public Nullable<System.TimeSpan> recu_A_Temps { get; set; }
        public string recu_A_Text { get; set; }
        public Nullable<decimal> recu_A_Montant { get; set; }
        public Nullable<bool> recu_A_Remise_Type { get; set; }
        public Nullable<decimal> recu_A_Remise { get; set; }
        public Nullable<decimal> recu_A_Total { get; set; }
        public Nullable<decimal> recu_A_Net { get; set; }
        public Nullable<bool> recu_A_Status { get; set; }
        public string recu_A_Note { get; set; }
        public string fact_A_Code { get; set; }
        public string recu_T_Code { get; set; }
        public string esp_C_Code { get; set; }
        public string ban_C_Code { get; set; }
        public string loc_C_Code { get; set; }
    
        public virtual Compte_Bancaire Compte_Bancaire { get; set; }
        public virtual Compte_Espece Compte_Espece { get; set; }
        public virtual Compte_Local Compte_Local { get; set; }
        public virtual Facture_Achat Facture_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Recu_Achat> Operation_Recu_Achat { get; set; }
        public virtual Recu_Type Recu_Type { get; set; }
    }
}
