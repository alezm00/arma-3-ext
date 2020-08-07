using System;
using System.Net;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] b = a.Split("|");
            WebRequest req = WebRequest.Create(b[0]);
            Stream z = req.GetResponse().GetResponseStream();

            StreamReader s = new StreamReader(z);
            string sline = "";
            int i = 0;
            while (sline != null)
            {
                i++;
                sline = s.ReadLine();
                if (sline != null) Console.WriteLine("{0}:{1}", i, sline);
            }

        }
    }
}
