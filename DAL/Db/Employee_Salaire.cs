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
    
    public partial class Employee_Salaire
    {
        public string empl_S_Code { get; set; }
        public string empl_S_Nom { get; set; }
        public Nullable<decimal> empl_S_Salaire { get; set; }
        public Nullable<decimal> empl_S_Remise { get; set; }
        public Nullable<decimal> empl_S_Bonus { get; set; }
        public Nullable<decimal> empl_S_Net { get; set; }
        public Nullable<bool> empl_S_Status { get; set; }
        public string empl_S_Note { get; set; }
        public string empl_Code { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
