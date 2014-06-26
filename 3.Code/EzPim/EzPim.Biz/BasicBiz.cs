using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;

namespace EzPim.Biz
{
    public  abstract class BasicBiz<T>
    {
        public string ConnectionString { get; set; }

        public string DbName { get; set; }

        protected BasicBiz(string connection, string dbname)
        {
            this.ConnectionString = connection;
            this.DbName = dbname;
        }

        protected void Add(T info)
        {
            var name = typeof (T).Name;
            var client = new MongoClient(this.ConnectionString);
            var server = client.GetServer();
            var db = server.GetDatabase(this.DbName);
            var list = db.GetCollection<T>(name);

            list.Insert(info);
        }

        public void Edit(T info)
        {
            var name = typeof (T).Name;
            var client = new MongoClient(this.ConnectionString);
            var server = client.GetServer();
            var db = server.GetDatabase(this.DbName);
            var list = db.GetCollection(name);

            list.Save(info);
        }

        public void Remove(IMongoQuery query)
        {
            var name = typeof(T).Name;
            var client = new MongoClient(this.ConnectionString);
            var server = client.GetServer();
            var db = server.GetDatabase(this.DbName);
            var list = db.GetCollection(name);

            list.Remove(query);
        }

        public T GetInfo(IMongoQuery query)
        {
            var name = typeof(T).Name;
            var client = new MongoClient(this.ConnectionString);
            var server = client.GetServer();
            var db = server.GetDatabase(this.DbName);
            var list = db.GetCollection(name);

            return list.FindOneAs<T>(query);
        }

        public List<T> GetList(IMongoQuery query)
        {
            var name = typeof(T).Name;
            var client = new MongoClient(this.ConnectionString);
            var server = client.GetServer();
            var db = server.GetDatabase(this.DbName);
            var list = db.GetCollection(name);

            return list.FindAs<T>(query).ToList();
        }
    }
}
