using System;
using System.Diagnostics;

namespace NetshCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Execute the 'netsh int ipv4 show dynamicport tcp' command
            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "netsh",
                    Arguments = "int ipv4 show dynamicport tcp",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };
            process.Start();

            // Read the output of the command
            string output = process.StandardOutput.ReadToEnd();

            // Print the output to the console
            Console.WriteLine(output);
        }
    }
}
