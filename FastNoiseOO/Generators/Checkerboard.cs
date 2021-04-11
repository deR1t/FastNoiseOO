using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Generates a checkerboard.
    /// </summary>
    public sealed class Checkerboard : Generator
    {

        public Checkerboard() : base()
        {
            _generator = new FastNoise("Checkerboard");
        }

        /// <summary>
        /// Sets the size of the checkerboard.
        /// </summary>
        /// <param name="value">Scale to use</param>
        public void SetSize(float value)
        {
            _generator.Set("Size", value);
        }

    }
}
