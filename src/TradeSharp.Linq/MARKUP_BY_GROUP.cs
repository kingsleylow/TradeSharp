//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TradeSharp.Linq
{
    using System;
    using System.Collections.Generic;
    
    public partial class MARKUP_BY_GROUP
    {
        public string Spot { get; set; }
        public string Group { get; set; }
        public double MarkupAbs { get; set; }
    
        public virtual ACCOUNT_GROUP ACCOUNT_GROUP { get; set; }
        public virtual SPOT SPOT1 { get; set; }
    }
}