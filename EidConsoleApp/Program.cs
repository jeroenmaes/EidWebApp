using EidShared;

namespace EidConsoleApp
{
    internal class Program
    {
        static string ProcessInput(string s)
        {
            // TODO Verify and validate the input 
            // string as appropriate for your application.
            return s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EidConsoleApp.exe invoked with the following parameters.\r\n");
            Console.WriteLine("Raw command-line: \n\t" + Environment.CommandLine);

            Console.WriteLine("\n\nArguments:\n");
            foreach (string s in args)
            {
                Console.WriteLine("\t" + ProcessInput(s));
            }

            Console.WriteLine("Reading Eid...");

            var reader = new EidReader();
            var eid = reader.Read();
            var eidJson = eid.ToJson();

            Console.WriteLine(eidJson);
        }
    }
}