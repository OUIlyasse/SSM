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
    
    public partial class Bon_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Type()
        {
            this.Bon_Destruction = new HashSet<Bon_Destruction>();
            this.Bon_Entree = new HashSet<Bon_Entree>();
            this.Bon_Sortie = new HashSet<Bon_Sortie>();
            this.Operation_Bon_Entree_Magasin = new HashSet<Operation_Bon_Entree_Magasin>();
            this.Operation_Bon_Sortie_Magasin = new HashSet<Operation_Bon_Sortie_Magasin>();
        }
    
        public string bon_T_Code { get; set; }
        public string bon_T_Type { get; set; }
        public Nullable<bool> bon_T_Status { get; set; }
        public string bon_T_Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Destruction> Bon_Destruction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Entree> Bon_Entree { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Sortie> Bon_Sortie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Bon_Entree_Magasin> Operation_Bon_Entree_Magasin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Bon_Sortie_Magasin> Operation_Bon_Sortie_Magasin { get; set; }
    }
}
