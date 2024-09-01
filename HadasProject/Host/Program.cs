using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceHadas));
            host.Open();
            Console.WriteLine("THIS IS A SERVERD DO NOT CLOSE");
            Console.ReadLine();
        }
    }
}
