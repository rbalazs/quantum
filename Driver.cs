using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Entaglement
{

    class Driver
    {
        static void Main(string[] args)
        {
            int ones = 0;
            using (var qsim = new QuantumSimulator())
            {
                for (int index = 0; index < 100; index++)
                {
                    var result = Entaglement.Run(qsim).Result;
                    if (result == Result.One)
                    {
                        ones++;
                    }
                }
            }

            Console.WriteLine("Collpased state!");
            Console.WriteLine($"\tOnes state {ones}");
            Console.WriteLine($"\tZeros state {100-ones}");
            Console.ReadKey();
        }
    }
}