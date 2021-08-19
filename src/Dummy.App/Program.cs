using System;
using System.Threading;

namespace Dummy.App
{
    class Program
    {
        private const string WorkingTime = "WORKING_TIME";
        
        static void Main(string[] args)
        {            
            Console.WriteLine("Start");
            
            var periodEnvironmentVariable = Environment.GetEnvironmentVariable(WorkingTime);

            if (periodEnvironmentVariable == null)
            {
                throw new ArgumentException($"{WorkingTime} environment variable not defined");
            }

            if (int.TryParse(periodEnvironmentVariable, out var period))
            {
                var counter = 0;

                do
                {
                    counter++;
                    Thread.Sleep(1000);

                    Console.WriteLine($"{DateTime.Now:g} Counter: {counter} Period: {period}");
                } while (counter < period);
            }
            else
            {
                throw new ArgumentException($"{WorkingTime} environment variable is not valid integer value");
            }
            
            Console.WriteLine("Finish");
        }
    }
}