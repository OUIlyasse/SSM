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
    
    public partial class Operation_Facture_Vente
    {
        public string fact_V_O_Code { get; set; }
        public Nullable<System.DateTime> fact_V_O_Date { get; set; }
        public Nullable<System.TimeSpan> fact_V_O_Temps { get; set; }
        public Nullable<decimal> fact_V_O_Montant { get; set; }
        public Nullable<decimal> fact_V_O_Remise { get; set; }
        public Nullable<decimal> fact_V_O_Total { get; set; }
        public Nullable<decimal> fact_V_O_Net { get; set; }
        public Nullable<bool> fact_V_O_Status { get; set; }
        public string fact_V_O_Note { get; set; }
        public string clt_Code { get; set; }
        public string dvis_Code { get; set; }
        public string fact_V_Code { get; set; }
        public string bran_Code { get; set; }
    
        public virtual Branche Branche { get; set; }
        public virtual Client Client { get; set; }
        public virtual Devise Devise { get; set; }
        public virtual Facture_Vente Facture_Vente { get; set; }
    }
}
