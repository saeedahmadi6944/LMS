//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubCourse
    {
        public int SubCourseID { get; set; }
        public int CourseID { get; set; }
        public string SubCourseTitle { get; set; }
        public string SubCourseDescription { get; set; }
        public bool CashOrFree { get; set; }
        public string VideoName { get; set; }
    
        public virtual Courses Courses { get; set; }
    }
}
