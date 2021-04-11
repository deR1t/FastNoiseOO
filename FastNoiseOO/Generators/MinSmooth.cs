using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Compares two values and returns the lowest, and allows you to smooth out the cutoff.
    /// </summary>
    public sealed class MinSmooth : OperatorSourceLHS
    {

        public MinSmooth() : base()
        {
            _generator = new FastNoise("MinSmooth");
        }

        /// <summary>
        /// Sets how smooth the cutoff should be.
        /// </summary>
        /// <param name="gen">The generator to determine the smoothness.</param>
        public void SetSmoothness(Generator gen)
        {
            _generator.Set("Smoothness", gen._generator);
        }

        /// <summary>
        /// Sets how smooth the cutoff should be.
        /// </summary>
        /// <param name="value">How smooth the cutoff should be.</param>
        public void SetSmoothness(float value)
        {
            _generator.Set("Smoothness", value);
        }

    }
}
