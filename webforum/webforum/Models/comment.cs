//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webforum.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comment
    {
        public comment()
        {
            this.comments1 = new HashSet<comment>();
        }
    
        public int comment_id { get; set; }
        public int target_thread_id { get; set; }
        public Nullable<int> target_comment_id { get; set; }
        public int user_id { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<int> upvotes { get; set; }
        public string content { get; set; }
    
        public virtual ICollection<comment> comments1 { get; set; }
        public virtual comment comment1 { get; set; }
        public virtual thread thread { get; set; }
        public virtual user user { get; set; }
    }
}
