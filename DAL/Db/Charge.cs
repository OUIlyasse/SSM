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
    
    public partial class Charge
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Charge()
        {
            this.Compte_Charge = new HashSet<Compte_Charge>();
        }
    
        public string chrg_Code { get; set; }
        public string chrg_Nom { get; set; }
        public Nullable<decimal> chrg_Max_Valeur { get; set; }
        public Nullable<bool> chrg_Status { get; set; }
        public string chrg_Note { get; set; }
        public string chrg_T_Code { get; set; }
    
        public virtual Charge_Type Charge_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compte_Charge> Compte_Charge { get; set; }
    }
}
