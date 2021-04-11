using System;

namespace FastNoiseOO.Generators
{

    /// <summary>
    /// Base class for cellular generators.
    /// </summary>
    public abstract class Cellular : Generator
    {
        internal Cellular() : base()
        {
        }

        /// <summary>
        /// Sets the function applied to the number returned from the center of each cell.<br/>
        /// Can be used to create different shapes for your cells.
        /// </summary>
        /// <param name="distanceFunction">Distance function to use</param>
        public void SetDistanceFunction(DistanceFunction distanceFunction)
        {
            switch (distanceFunction)
            {
                case DistanceFunction.Euclidean:
                    _generator.Set("DistanceFunction", "Euclidean");
                    break;
                case DistanceFunction.EuclideanSquared:
                    _generator.Set("DistanceFunction", "EuclideanSquared");
                    break;
                case DistanceFunction.Manhattan:
                    _generator.Set("DistanceFunction", "Manhattan");
                    break;
                case DistanceFunction.Hybrid:
                    _generator.Set("DistanceFunction", "Hybrid");
                    break;
                case DistanceFunction.MaxAxis:
                    _generator.Set("DistanceFunction", "MaxAxis");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(distanceFunction), distanceFunction, null);
            }
        }

        /// <summary>
        /// Multiplies how much the "vertices" of each cell are skewed.<br/>
        /// 0 will create perfect squares, whereas 1 will push those "vertices" around and create a cellular / fractured look.
        /// </summary>
        /// <param name="value">Vertex skew multiplier</param>
        public void SetJitterModifier(float value)
        {
            _generator.Set("JitterModifier", value);
        }

        /// <summary>
        /// Multiplies how much the "vertices" of each cell are skewed.<br/>
        /// 0 will create perfect squares, whereas 1 will push those "vertices" around and create a cellular / fractured look.
        /// </summary>
        /// <param name="gen">Generator to use</param>
        public void SetJitterModifier(Generator gen)
        {
            _generator.Set("JitterModifier", gen._generator);
        }

    }

}
