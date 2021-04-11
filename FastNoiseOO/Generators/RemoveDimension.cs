using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Removes a dimension from the input generator.
    /// </summary>
    public sealed class RemoveDimension : Generator
    {

        public RemoveDimension() : base()
        {
            _generator = new FastNoise("RemoveDimension");
        }

        /// <summary>
        /// Sets the generator to remove the dimension from.
        /// </summary>
        /// <param name="gen">The generator to remove the dimension from.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets the dimension to remove.
        /// </summary>
        /// <param name="dimension">The dimension to remove.</param>
        public void SetRemoveDimension(Dim dimension)
        {
            switch (dimension)
            {
                case Dim.X:
                    _generator.Set("RemoveDimension", "X");
                    break;
                case Dim.Y:
                    _generator.Set("RemoveDimension", "Y");
                    break;
                case Dim.Z:
                    _generator.Set("RemoveDimension", "Z");
                    break;
                case Dim.W:
                    _generator.Set("RemoveDimension", "W");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null);
            }
        }

    }
}
