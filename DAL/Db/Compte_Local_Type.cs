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
    
    public partial class Compte_Local_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compte_Local_Type()
        {
            this.Compte_Local = new HashSet<Compte_Local>();
        }
    
        public string loc_C_T_Code { get; set; }
        public string loc_C_T_Nom { get; set; }
        public string loc_C_T_Type { get; set; }
        public Nullable<bool> loc_C_T_Status { get; set; }
        public string loc_C_T_Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compte_Local> Compte_Local { get; set; }
    }
}