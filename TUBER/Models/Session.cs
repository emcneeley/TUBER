using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TUBER.Models
{
    public class Session
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string StudentId { get; set; }
        public string TutorId { get; set; }
        public int TopicId { get; set; }
        public string Date { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsConfirmed { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public Profile Creator { get; set; }
        public string CreatorId { get; set; }


    }
}


