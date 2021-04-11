using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Compares two values and returns the highest.
    /// </summary>
    public sealed class Max : OperatorSourceLHS
    {

        public Max() : base()
        {
            _generator = new FastNoise("Max");
        }

    }
}
