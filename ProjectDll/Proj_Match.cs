//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectDll
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proj_Match
    {
        public long MatchID { get; set; }
        public Nullable<long> ProjectID { get; set; }
        public Nullable<long> MatchSender { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<int> IsAccepted { get; set; }
        public Nullable<System.DateTime> AcceptedTime { get; set; }
        public Nullable<double> MatchPercent { get; set; }
        public Nullable<int> Flag { get; set; }
        public string EnterpriseName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Description { get; set; }
    
        public virtual User User { get; set; }
        public virtual Proj_Project Proj_Project { get; set; }
    }
}
