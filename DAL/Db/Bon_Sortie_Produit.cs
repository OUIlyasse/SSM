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
    
    public partial class Bon_Sortie_Produit
    {
        public string prd_B_S_Code { get; set; }
        public Nullable<System.DateTime> prd_B_S_Date { get; set; }
        public Nullable<System.TimeSpan> prd_B_S_Temps { get; set; }
        public Nullable<int> prd_B_S_Quantite { get; set; }
        public string prd_B_S_Text { get; set; }
        public Nullable<bool> prd_B_S_Status { get; set; }
        public string prd_B_S_Note { get; set; }
        public string prd_Code { get; set; }
        public string bon_S_Code { get; set; }
    
        public virtual Bon_Sortie Bon_Sortie { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
