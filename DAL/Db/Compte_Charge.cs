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
    
    public partial class Compte_Charge
    {
        public string chrg_C_Code { get; set; }
        public string chrg_C_Nom { get; set; }
        public Nullable<System.DateTime> chrg_C_Date { get; set; }
        public Nullable<bool> chrg_C_Status { get; set; }
        public string chrg_C_Note { get; set; }
        public string chrg_Code { get; set; }
    
        public virtual Charge Charge { get; set; }
    }
}
