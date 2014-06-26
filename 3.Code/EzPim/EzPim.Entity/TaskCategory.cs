using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzPim.Entity
{
    public class TaskCategory
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Name { get; set; }

        public List<TaskCategory> Childs { get; set; }
    }
}
