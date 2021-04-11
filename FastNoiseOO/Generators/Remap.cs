using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Remaps the input.<br/>
    /// This is just a quick way of normalizing many values to fit between two arbitrary values.
    /// </summary>
    public sealed class Remap : Generator
    {

        public Remap() : base()
        {
            _generator = new FastNoise("Remap");
        }

        /// <summary>
        /// Sets the generator to remap.
        /// </summary>
        /// <param name="gen">The generator to remap.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Change how to remap the input.
        /// </summary>
        /// <param name="fromMin">The minimum value of the input.</param>
        /// <param name="fromMax">The maximum value of the input.</param>
        /// <param name="toMin">The new minimum value.</param>
        /// <param name="toMax">The new maximum value.</param>
        public void SetRemap(float fromMin, float fromMax, float toMin, float toMax)
        {
            _generator.Set("FromMin", fromMin);
            _generator.Set("FromMan", fromMax);
            _generator.Set("ToMin", toMin);
            _generator.Set("ToMax", toMax);
        }

    }
}
