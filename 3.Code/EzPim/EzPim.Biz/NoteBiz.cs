using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EzPim.Entity;

namespace EzPim.Biz
{
    public class NoteBiz : BasicBiz<Note>
    {
        public NoteBiz(string connection, string dbname) : base(connection, dbname)
        {
            
        }
    }
}
