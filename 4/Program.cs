using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
const scheduler = new TaskScheduler();
scheduler.addTask("Do something", 2);
scheduler.addTask("Do something else", 1);
scheduler.executeNext((task) => console.log(`Executing: ${ task}`)); // "Executing: Do something"