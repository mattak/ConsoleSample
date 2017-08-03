using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>() {{"message", "Hello World!"}};
            var serialized = JsonConvert.SerializeObject(dictionary);
            Console.WriteLine(serialized);
        }
    }
}