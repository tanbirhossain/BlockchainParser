//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlockchainToSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions
    {
        public Transactions()
        {
            this.Inputs = new HashSet<Inputs>();
            this.Outputs = new HashSet<Outputs>();
        }
    
        public long ID { get; set; }
        public long BlockID { get; set; }
        public long Version { get; set; }
    
        public virtual blocks blocks { get; set; }
        public virtual ICollection<Inputs> Inputs { get; set; }
        public virtual ICollection<Outputs> Outputs { get; set; }
    }
}
