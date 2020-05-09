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
            var equal = 0;
            using (var qsim = new QuantumSimulator())
            {
                for (int index = 0; index < 1000; index++)
                {
                    var (qubitOne, qubitTow) = Entaglement.Run(qsim).Result;
                    if (qubitOne == Result.One)
                    {
                        ones++;
                    }

                    if (qubitOne == qubitTow)
                    {
                        equal++;
                    }
                }
            }

            Console.WriteLine("Collpased state!");
            Console.WriteLine($"\tOnes state {ones}");
            Console.WriteLine($"\tZero state {100-ones}");
            Console.WriteLine($"\tEQ: {equal}%");
            Console.ReadKey();
        }
    }
}