//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Techleb.WebApi.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class notifications_tech
    {
        public int notification_id { get; set; }
        public int c_id { get; set; }
        public int t_id { get; set; }
        public int job_id { get; set; }
        public short notification_is_deleted { get; set; }
        public short notification_is_starred { get; set; }
        public System.DateTime notification_date { get; set; }
        public System.TimeSpan notification_time { get; set; }
        public short notificaiton_flag { get; set; }
    
        public virtual job job { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
