using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// A fractal that can give a generator a "ridged" look.
    /// </summary>
    public sealed class FractalRidged : Fractal
    {

        public FractalRidged() : base()
        {
            _generator = new FastNoise("FractalRidged");
        }

        /// <summary>
        /// Sets the generator to modify.
        /// </summary>
        /// <param name="gen">The generator to modify.</param>
        public new void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

    }
}
