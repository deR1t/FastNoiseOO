using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Scales the domain's output.
    /// </summary>
    public sealed class DomainScale : Generator
    {

        public DomainScale() : base()
        {
            _generator = new FastNoise("DomainScale");
        }

        /// <summary>
        /// Sets the generator to scale.
        /// </summary>
        /// <param name="gen">The generator to scale.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets the amount the generator should be scaled by.
        /// </summary>
        /// <param name="value">The amount to scale the generator.</param>
        public void SetScale(float value)
        {
            _generator.Set("Scale", value);
        }

    }
}
