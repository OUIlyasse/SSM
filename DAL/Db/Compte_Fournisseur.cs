//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
