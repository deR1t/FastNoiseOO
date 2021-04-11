using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Rotates the generator's output.
    /// </summary>
    public sealed class DomainRotate : Generator
    {

        public DomainRotate() : base()
        {
            _generator = new FastNoise("DomainRotate");
        }

        /// <summary>
        /// Sets the generator to rotate.
        /// </summary>
        /// <param name="gen">The generator to rotate.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets how much the generator rotates in yaw.
        /// </summary>
        /// <param name="value">The yaw to rotate the generator with.</param>
        public void SetYaw(float value)
        {
            _generator.Set("Yaw", value);
        }

        /// <summary>
        /// Sets how much the generator rotates in pitch.
        /// </summary>
        /// <param name="value">The pitch to rotate the generator with.</param>
        public void SetPitch(float value)
        {
            _generator.Set("Pitch", value);
        }

        /// <summary>
        /// Sets how much the generator rotates in roll.
        /// </summary>
        /// <param name="value">The roll to rotate the generator with.</param>
        public void SetRoll(float value)
        {
            _generator.Set("Roll", value);
        }

    }
}
