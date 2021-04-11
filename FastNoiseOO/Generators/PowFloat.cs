using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Raises a generator to a power. This generator is meant for floats.
    /// </summary>
    public sealed class PowFloat : Generator
    {

        public PowFloat() : base()
        {
            _generator = new FastNoise("PowFloat");
        }   

        /// <summary>
        /// Sets the generator to use as the value.
        /// </summary>
        /// <param name="gen">The generator to use as the value.</param>
        public void SetValue(Generator gen)
        {
            _generator.Set("Value", gen._generator);
        }

        /// <summary>
        /// Sets the value to use.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public void SetValue(float value)
        {
            _generator.Set("Value", value);
        }

        /// <summary>
        /// Sets the generator to use as the exponent.
        /// </summary>
        /// <param name="gen">The generator to use as the exponent.</param>
        public void SetPow(Generator gen)
        {
            _generator.Set("Pow", gen._generator);

        }

        /// <summary>
        /// Sets the exponent.
        /// </summary>
        /// <param name="value">The exponent.</param>
        public void SetPow(float value)
        {
            _generator.Set("Pow", value);
        }

    }
}
