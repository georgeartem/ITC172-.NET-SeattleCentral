//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Show
    {
        public Show()
        {
            this.ShowDetails = new HashSet<ShowDetail>();
        }
    
        public int ShowKey { get; set; }
        public string ShowName { get; set; }
        public Nullable<int> VenueKey { get; set; }
        public System.DateTime ShowDate { get; set; }
        public System.TimeSpan ShowTime { get; set; }
        public string ShowTicketInfo { get; set; }
        public Nullable<System.DateTime> ShowDateEntered { get; set; }
    
        public virtual Venue Venue { get; set; }
        public virtual ICollection<ShowDetail> ShowDetails { get; set; }
    }
}
