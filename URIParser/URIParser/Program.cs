using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "https://example.com/path/resource.txt#fragment";
            UriParser parser = new UriParser(uri);

            Console.WriteLine(
                "Scheme : " +
                parser.comp.scheme +
                "\r\n" +
                "Host : " +
                parser.comp.host +
                "\r\n" +
                "User : " +
                parser.comp.user +
                "\r\n" +
                "Password : " +
                parser.comp.password +
                "\r\n" +
                "Path : " +
                parser.comp.path +
                "\r\n" +
                "Fragment : " +
                parser.comp.fragment +
                "\r\n" +
                "Query : " +
                parser.comp.query +
                "\r\n" +
                "Port : " +
                parser.comp.port
                );

            Console.ReadLine();
        }
    }
}
