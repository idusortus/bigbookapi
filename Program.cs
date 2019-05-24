using System;
using System.Net;

/****
 * Overall idea is to package up the BB and serve it online
 * 
 * 
 */
namespace bigbookapi
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://anonpress.org/bb/Page_1.htm has data already formatted in a more useful than the text file format
            // Start by scraping this and putting it together.
            // I'll start by fetching each individual page and store it as raw html
            var pageGrabber = new WebClient();

            for (int i = 1; i < 165; i++)
            {                
                System.IO.File.WriteAllText(@"BigBookHTML_" + i.ToString().PadLeft(4,'0'), pageGrabber.DownloadString(@"https://anonpress.org/bb/Page_"+i+".htm"));
            }
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
