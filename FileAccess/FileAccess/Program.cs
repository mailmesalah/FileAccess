using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            if(DateTime.Now>=new DateTime(2017, 2, 3))
            {
                Console.WriteLine("Expired");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please Provide the file path");
            string path=Console.ReadLine();

            try
            {
                
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                // Get the creation time of a well-known directory.
                DateTime dt = File.GetLastAccessTime(path);
                Console.WriteLine("The last access time for this file was {0}.", dt);


            }
            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
