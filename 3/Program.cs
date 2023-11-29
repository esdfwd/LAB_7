using System;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
const cache = new FunctionCache();
const myFunc = (key) => key.toUpperCase();
console.log(cache.execute(myFunc, "hello")); // "HELLO"
console.log(cache.execute(myFunc, "hello")); // "HELLO"