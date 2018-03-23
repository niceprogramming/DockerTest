using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace DockerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int? stuff = 3;
            var moreStuff = stuff ?? 5;
            var config = Environment.GetEnvironmentVariable("CONFIG_LOCATION");
            try
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine(string.Join(",",Directory.EnumerateDirectories(Directory.GetCurrentDirectory())));
                Console.WriteLine(File.Exists("/test/test.txt"));
                File.WriteAllText(config, "hello world");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
       
        }
    }
}
