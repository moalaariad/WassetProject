//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WassetPortal_DAL.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class UserAction
    {
        public long UserActionID { get; set; }
        public Nullable<long> FK_UserID { get; set; }
        public Nullable<int> FK_ActionID { get; set; }
        public Nullable<bool> UserActionStatus { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual Action Action { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual User User { get; set; }
    }
}