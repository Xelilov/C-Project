//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Code_Academy_project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group_schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group_schedule()
        {
            this.Group_types = new HashSet<Group_types>();
        }
    
        public int id { get; set; }
        public string group_schedule_name { get; set; }
        public System.DateTime group_begin_time { get; set; }
        public System.DateTime group_end_time { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group_types> Group_types { get; set; }
    }
}
