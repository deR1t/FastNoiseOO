using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// For each pixel, a random number is picked.
    /// </summary>
    public sealed class White : Generator
    {

        public White() : base()
        {
            _generator = new FastNoise("White");
        }

    }
}
