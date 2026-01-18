using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Domain
{
    internal class Note
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EditDate { get; set; }

    }
}
