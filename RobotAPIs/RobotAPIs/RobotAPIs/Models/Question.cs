//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RobotAPIs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public int QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
    
        public virtual Answer Answer { get; set; }
    }
}
