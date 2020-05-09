using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Superposition
{

    class Driver
    {
        static void Main(string[] args)
        {
            int ones = 0;
            using (var qsim = new QuantumSimulator())
            {
                for (int index = 0; index < 10000; index++)
                {
                    var result = Superposition.Run(qsim).Result;
                    if (result == Result.One)
                    {
                        ones++;
                    }
                }
            }

            Console.WriteLine("Collpased state!");
            Console.WriteLine($"\tOnes state {ones}");
            Console.WriteLine($"\tZeros state {10000-ones}");
            Console.ReadKey();
        }
    }
}