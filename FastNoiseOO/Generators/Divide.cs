using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{

    /// <summary>
    /// It divides the values of generators by each other or a constant.
    /// </summary>
    public sealed class Divide : OperatorHybridLHS
    {

        public Divide() : base()
        {
            _generator = new FastNoise("Divide");
        }

    }
}
