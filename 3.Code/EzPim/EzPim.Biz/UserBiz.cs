using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EzPim.Entity;
using MongoDB.Driver;

namespace EzPim.Biz
{
    public class UserBiz : BasicBiz<User>
    {
        public UserBiz(string connection, string dbname) : base(connection, dbname)
        {
            
        }
    }
}
