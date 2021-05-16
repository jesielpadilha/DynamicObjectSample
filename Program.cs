using System;
using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;

namespace DynamicObjectSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new ExpandoObject();

            obj.FirstName = "Ellen";
            obj.LastName = "Adams";
            obj.Age = 20;
            obj.Todos = new List<string> {"task 1", "task 2", "task 3"};

            var json = JsonConvert.SerializeObject(obj);
            Console.WriteLine($"\n**** Json Object: \n{json}\n");
        }
    }
}
