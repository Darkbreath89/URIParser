<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URIParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide URI and press enter");
            string uri = Console.ReadLine();
            UriParser parser = new UriParser(uri);

            Console.WriteLine();
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

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URIParser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide URI and press enter");
            string uri = Console.ReadLine();
            UriParser parser = new UriParser(uri);

            Console.WriteLine();
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

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
>>>>>>> 4f7bc2cc04728707c1807094b0dc6824adff9584
