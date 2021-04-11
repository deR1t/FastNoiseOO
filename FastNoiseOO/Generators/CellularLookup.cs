using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Creates many cells, value of each cell is based on the lookup generator.
    /// </summary>
    public sealed class CellularLookup : Cellular
    {

        public CellularLookup() : base()
        {
            _generator = new FastNoise("CellularLookup");
        }

        /// <summary>
        /// The generator to use to get each cell's value.
        /// </summary>
        /// <param name="gen">The generator to use</param>
        public void SetLookup(Generator gen)
        {
            _generator.Set("Lookup", gen._generator);
        }

        /// <summary>
        /// The "zoom" of the noise.<br/>
        /// You can pretend you're just using a domain scale on the input noise.
        /// </summary>
        /// <param name="frequency">The frequency</param>
        public void SetLookupFrequency(float frequency)
        {
            _generator.Set("LookupFrequency", frequency);
        }

    }
}
