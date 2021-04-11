using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{

    /// <summary>
    /// Types of fractals.
    /// </summary>
    public enum FractalTypes
    {
        /// <summary>
        /// Domain warp independent fractal.
        /// </summary>
        DomainWarpIndependent = 0,
        /// <summary>
        /// Domain warp progressive fractal.
        /// </summary>
        DomainWarpProgressive,
        /// <summary>
        /// FBm fractal.
        /// </summary>
        FBm,
        /// <summary>
        /// Ping pong fractal.
        /// </summary>
        PingPong,
        /// <summary>
        /// Ridged fractal.
        /// </summary>
        Ridged
    }

    /// <summary>
    /// Base class for fractals.
    /// </summary>
    public abstract class Fractal : Generator
    {

        internal Fractal() : base()
        {
        }

        /// <summary>
        /// Sets the source generator to warp.
        /// </summary>
        /// <param name="gen">Generator to set the source to.</param>
        protected void SetSource(Generator gen)
        {
        }

        /// <summary>
        /// Sets the gain of the fractal based off of the provided generator.
        /// </summary>
        /// <param name="gen">The generator to base the gain off of.</param>
        public void SetGain(Generator gen)
        {
            _generator.Set("Gain", gen._generator);
        }

        /// <summary>
        /// Sets the gain of the fractal.
        /// </summary>
        /// <param name="value">The value to set the gain to.</param>
        public void SetGain(float value)
        {
            _generator.Set("Gain", value);
        }

        /// <summary>
        /// Sets the fractal's weighted strength based on a generator.
        /// </summary>
        /// <param name="gen">The generator to base the weighted strength on.</param>
        public void SetWeightedStrength(Generator gen)
        {
            _generator.Set("WeightedStrength", gen._generator);
        }

        /// <summary>
        /// Sets the fractal's weighted strength.
        /// </summary>
        /// <param name="value">The value to set the weighted strength to.</param>
        public void SetWeightedStrength(float value)
        {
            _generator.Set("WeightedStrength", value);
        }

        /// <summary>
        /// How many octaves the fractal has.
        /// </summary>
        /// <param name="value">The octave count.</param>
        public void SetOctaveCount(int value)
        {
            _generator.Set("Octaves", value);
        }

        /// <summary>
        /// Sets fractal's lacunarity.
        /// </summary>
        /// <param name="value">Sets fractal's lacunarity.</param>
        public void SetLacunarity(float value)
        {
            _generator.Set("Lacunarity", value);
        }

    }

}
