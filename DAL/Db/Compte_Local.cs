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
    
    public partial class Compte_Local
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compte_Local()
        {
            this.Recu_Achat = new HashSet<Recu_Achat>();
            this.Recu_Vente = new HashSet<Recu_Vente>();
        }
    
        public string loc_C_Code { get; set; }
        public Nullable<System.DateTime> loc_C_Date_Creation { get; set; }
        public Nullable<decimal> loc_C_Solde { get; set; }
        public Nullable<decimal> loc_C_Min { get; set; }
        public Nullable<decimal> loc_C_Max { get; set; }
        public Nullable<bool> loc_C_Status { get; set; }
        public string loc_C_Note { get; set; }
        public string loc_C_T_Code { get; set; }
        public string main_C_Code { get; set; }
    
        public virtual Compte_Local_Type Compte_Local_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recu_Achat> Recu_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recu_Vente> Recu_Vente { get; set; }
    }
}
