using FastNoiseSharp.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// It adds the values of generators together.
    /// </summary>
    public sealed class Add : OperatorSourceLHS
    {

        public Add() : base()
        {
            _generator = new FastNoise("Add");
        }

    }
}
