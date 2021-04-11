using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{

    /// <summary>
    /// Generates sine waves in many dimensions.
    /// </summary>
    public sealed class SineWave : Generator
    {

        public SineWave() : base()
        {
            _generator = new FastNoise("SineWave");
        }

        /// <summary>
        /// Sets the scale of the sine waves.
        /// </summary>
        /// <param name="value">The scale to set the sine waves to</param>
        public void SetScale(float value)
        {
            _generator.Set("Scale", value);
        }

    }
}
