//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HiringRequest
    {
        public int HiringRequest_Id { get; set; }
        public System.TimeSpan Time { get; set; }
        public int Pm_Id { get; set; }
        public int User_Id { get; set; }
        public int RequestStatus_Id { get; set; }
        public int Project_Id { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual RequestStatu RequestStatu { get; set; }
        public virtual Project Project { get; set; }
    }
}
