//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LADLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LearningActivity
    {
        public long LearningActivityID { get; set; }
        public long UserID { get; set; }
        public long ActivityTypeID { get; set; }
        public long LearningObjectID { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<int> During { get; set; }
        public long LocationID { get; set; }
        public string WorksUrl { get; set; }
        public string Others { get; set; }
        public Nullable<System.DateTime> CreatDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public Nullable<int> Flag { get; set; }
    
        public virtual ActivityType ActivityType { get; set; }
        public virtual LearningObject LearningObject { get; set; }
        public virtual Location Location { get; set; }
        public virtual User User { get; set; }
    }
}
