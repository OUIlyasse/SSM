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
    
    public partial class Compte_Employee
    {
        public string empl_C_Code { get; set; }
        public Nullable<System.DateTime> empl_C_Date { get; set; }
        public Nullable<System.TimeSpan> empl_C_Temps { get; set; }
        public Nullable<decimal> empl_C_Solde { get; set; }
        public string empl_Code { get; set; }
        public Nullable<bool> empl_C_Status { get; set; }
        public string empl_C_Note { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
