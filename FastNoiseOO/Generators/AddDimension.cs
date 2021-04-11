using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Adds a dimension to a generator.
    /// </summary>
    public sealed class AddDimension : Generator
    {

        public AddDimension() : base()
        {
            _generator = new FastNoise("AddDimension");
        }

        /// <summary>
        /// Sets the generator to add the dimension to.
        /// </summary>
        /// <param name="gen">The generator to add the dimension to.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets the new dimension's position.
        /// </summary>
        /// <param name="gen">Sets the new dimension's position using the values from another generator.</param>
        public void SetNewDimensionPosition(Generator gen)
        {
            _generator.Set("NewDimensionPosition", gen._generator);
        }

        /// <summary>
        /// Sets the new dimension's position.
        /// </summary>
        /// <param name="value">The position.</param>
        public void SetNewDimensionPosition(float value)
        {
            _generator.Set("NewDimensionPosition", value);
        }

    }
}
