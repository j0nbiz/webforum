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
    
    public partial class thread
    {
        public thread()
        {
            this.comments = new HashSet<comment>();
        }
    
        public int thread_id { get; set; }
        public int user_id { get; set; }
        public string title { get; set; }
        public System.DateTime date { get; set; }
        public string tags { get; set; }
        public Nullable<int> views { get; set; }
        public Nullable<int> upvotes { get; set; }
        public string content { get; set; }
    
        public virtual ICollection<comment> comments { get; set; }
        public virtual user user { get; set; }
    }
}
