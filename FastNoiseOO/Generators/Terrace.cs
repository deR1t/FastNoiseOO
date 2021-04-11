using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Terraces the input generator.
    /// </summary>
    public sealed class Terrace : Generator
    {

        public Terrace() : base()
        {
            _generator = new FastNoise("Terrace");
        }

        /// <summary>
        /// Sets the generator to terrace.
        /// </summary>
        /// <param name="gen">The generator to terrace.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Multiplies the terrace effect.
        /// </summary>
        /// <param name="multiplier">Terrace effect multiplier.</param>
        public void SetMultiplier(float multiplier)
        {
            _generator.Set("Multiplier", multiplier);
        }

        /// <summary>
        /// Smooths out the terrace effect.
        /// </summary>
        /// <param name="smoothness">How much the terrace effect should be smoothed.</param>
        public void SetSmoothness(float smoothness)
        {
            _generator.Set("Smoothness", smoothness);
        }

    }
}
