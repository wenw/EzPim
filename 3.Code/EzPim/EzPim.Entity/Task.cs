using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzPim.Entity
{
    public class Task
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime DeadLine { get; set; }

        public int Status { get; set; }

        public Guid CategoryId { get; set; }

        public string Tag { get; set; }
    }
}
