using System;
using Newtonsoft.Json;

namespace lib
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }

        public string UseJsonNetForSomeReason<T>(T input)
        {
            return JsonConvert.SerializeObject(input);
        }
    }
}
