//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThinWalls.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ReviewID { get; set; }
        public string UserID { get; set; }
        public string YelpID { get; set; }
        public string BusinessName { get; set; }
        public int WallScore { get; set; }
        public string Comment { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
