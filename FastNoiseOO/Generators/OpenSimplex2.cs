using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Successor to Simplex, generating similar curves in much less time.
    /// </summary>
    public sealed class OpenSimplex2 : Generator
    {

        public OpenSimplex2() : base()
        {
            _generator = new FastNoise("OpenSimplex2");
        }

    }
}
