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
    
    public partial class Produit_Image
    {
        public string img_Code { get; set; }
        public string img_Nom { get; set; }
        public string img_Emplacement { get; set; }
        public Nullable<bool> img_Status { get; set; }
        public string img_Note { get; set; }
        public string prd_Code { get; set; }
    
        public virtual Produit Produit { get; set; }
    }
}
