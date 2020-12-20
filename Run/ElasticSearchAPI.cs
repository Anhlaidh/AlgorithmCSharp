using System;
using Nest;
using NUnit.Framework;

namespace Run
{
    public class ElasticSearchAPI
    {
        public class Product
        {
            public string name { get; set; }
            public string desc { get; set; }
            public long price { get; set; }
            public string[] tags { get; set; }
        }

        ElasticClient client = new ElasticClient(new ConnectionSettings(new Uri("http://localhost:9200/")).DefaultIndex("product"));

        [Test]
        public void Connect()
        {
            var response = client.Get<Product>(new GetRequest("product", "_doc", 2));
            Console.WriteLine("success");
        }

        [Test]
        public void Query()
        {
            
        }
    }
}