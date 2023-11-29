using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
const repo = new Repository();
repo.add({ name: "John", age: 25 });
repo.add({ name: "Alice", age: 30 });
const result = repo.find((item) => item.age > 28);
console.log(result); // [{ name: "Alice", age: 30 }]