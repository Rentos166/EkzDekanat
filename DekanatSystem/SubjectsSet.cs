//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DekanatSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubjectsSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectsSet()
        {
            this.PointsSet = new HashSet<PointsSet>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Semestr { get; set; }
        public int Year { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointsSet> PointsSet { get; set; }
    }
}
