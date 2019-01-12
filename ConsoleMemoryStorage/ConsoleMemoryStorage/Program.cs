using System;
using Hangfire;
using Hangfire.MemoryStorage;

namespace ConsoleMemoryStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfiguration.Configuration.UseMemoryStorage();

            using(var server = new BackgroundJobServer())
            {
                BackgroundJob.Enqueue(() => Console.WriteLine("Hello World!"));

                Console.ReadKey();
            }
        }
    }
}
