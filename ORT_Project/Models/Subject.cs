//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORT_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subject()
        {
            this.Reatinship_Graduent_and_Subject_ = new HashSet<Reatinship_Graduent_and_Subject_>();
        }
    
        public byte ID_Subject { get; set; }
        public string Subject_name { get; set; }
        public Nullable<decimal> Subject_Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reatinship_Graduent_and_Subject_> Reatinship_Graduent_and_Subject_ { get; set; }
    }
}
