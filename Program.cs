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
            obj.Todos = new List<string> { "task 1", "task 2", "task 3" };
            obj.Addresses = new List<object> {
                new {City = "New York", State = "NY", Country = "US"},
                new {City = "London", State = "", Country = "UK"}
            };


            var objDicionary = new Dictionary<string, object>();
            objDicionary.Add("FirstName", "Ellen");
            objDicionary.Add("LastName", "Adams");
            objDicionary.Add("Age", 20);
            objDicionary.Add("Nickname", "El");
            objDicionary.Add("Todos", new List<string> { "task 1", "task 2", "task 3" });
            objDicionary.Add("Addresses", new List<object> {
                new {City = "New York", State = "NY", Country = "US"},
                new {City = "London", State = "", Country = "UK"}
            });

            var json = JsonConvert.SerializeObject(objDicionary, Formatting.Indented);
            Console.WriteLine($"\n**** Json Object: \n{json}\n");
        }
    }
}
