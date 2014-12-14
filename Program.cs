using System;
using System.Diagnostics;
using System.IO;

namespace MdConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(@"
Markdown Connector

Usage: MdConnector.exe {filename}
    {filename}.md  => http://{parentdir}/?{filename}
    {filename}.txt => {filename}.md
");
            } 
            else if ( args.Length > 0 )
            {
                var fp = args[0];
                var parent = Path.GetFileName(Path.GetDirectoryName(fp));
                var fn = Path.GetFileName(fp);
                if (fn != null) Process.Start(string.Format(@"http://{0}/?{1}", parent, Uri.EscapeUriString(fn)));
            }
        }
    }
}
