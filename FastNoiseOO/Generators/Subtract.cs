using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// It subtracts the values of generators from each other.
    /// </summary>
    public sealed class Subtract : OperatorHybridLHS
    {
        public Subtract() : base()
        {
            _generator = new FastNoise("Subtract");
        }

    }
}
