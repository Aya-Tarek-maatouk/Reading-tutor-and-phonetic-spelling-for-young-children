//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GP_for_seminar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kid_Level_lesson
    {
        public int ID { get; set; }
        public int KidID { get; set; }
        public int LessonID { get; set; }
        public double ProgressLevel { get; set; }
    
        public virtual Kid Kid { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
