using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    /// <summary>
    /// Each pixel returns the distance to a point.
    /// </summary>
    public sealed class DistanceToPoint : Generator
    {

        public DistanceToPoint() : base()
        {
            _generator = new FastNoise("DistanceToPoint");
        }

        /// <summary>
        /// Sets the method that should be used to get the number.
        /// </summary>
        /// <param name="distanceFunction">The method that should be used to get the number.</param>
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
        /// Sets position of point to get the distance from.
        /// </summary>
        /// <param name="dimension">The axis to change</param>
        /// <param name="value">The position to set it to</param>
        public void SetScale(Dim dimension, float value)
        {
            switch (dimension)
            {
                case Dim.X:
                    _generator.Set("XPoint", value);
                    break;
                case Dim.Y:
                    _generator.Set("YPoint", value);
                    break;
                case Dim.Z:
                    _generator.Set("ZPoint", value);
                    break;
                case Dim.W:
                    _generator.Set("WPoint", value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null);
            }
        }

        /// <summary>
        /// ?<br/>
        /// We've yet to figure this out.
        /// </summary>
        /// <param name="gen">The source generator</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

    }
}
