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
    
    public partial class Compte_Fournisseur
    {
        public string frns_C_Code { get; set; }
        public string frns_C_Nom { get; set; }
        public Nullable<System.DateTime> frns_C_Date { get; set; }
        public Nullable<decimal> frns_C_Limit_Montant { get; set; }
        public string trait_Code { get; set; }
        public Nullable<bool> frns_C_Status { get; set; }
        public string frns_C_Note { get; set; }
        public string frns_Code { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Traitement Traitement { get; set; }
    }
}
