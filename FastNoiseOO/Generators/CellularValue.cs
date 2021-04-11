using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Creates many cells, value seems to just be random.
    /// </summary>
    public sealed class CellularValue : Cellular
    {

        public CellularValue() : base()
        {
            _generator = new FastNoise("CellularValue");
        }

        /// <summary>
        /// Every pixel nearby another cell get it's color, and this is seemingly the amount of recursion.
        /// </summary>
        /// <param name="value">Amount of recursion.</param>
        public void SetValueIndex(int value)
        {
            _generator.Set("ValueIndex", value);
        }

    }
}
