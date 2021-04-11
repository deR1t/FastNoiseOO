using System;

namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Outputs a value based on the position of the pixel.<br/>
    /// Multiplies and offsets the final value based on the multipliers and offsets.
    /// </summary>
    public sealed class PositionOutput : Generator
    {

        public PositionOutput() : base()
        {
            _generator = new FastNoise("PositionOutput");
        }

        /// <summary>
        /// Sets a axis's multiplier or offset.
        /// </summary>
        /// <param name="dimension">The axis to set</param>
        /// <param name="multiplier">The multiplier of the axis</param>
        /// <param name="offset">The axis's offset</param>
        public void SetMultiplier(Dim dimension, float multiplier)
        {
            switch (dimension)
            {
                case Dim.X:
                    _generator.Set("MultiplierX", multiplier);
                    break;
                case Dim.Y:
                    _generator.Set("MultiplierY", multiplier);
                    break;
                case Dim.Z:
                    _generator.Set("MultiplierZ", multiplier);
                    break;
                case Dim.W:
                    _generator.Set("MultiplierW", multiplier);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null);
            }
        }

        public void SetOffset(Dim dimension, float offset = 0.0f)
        {
            switch (dimension)
            {
                case Dim.X:
                    _generator.Set("OffsetX", offset);
                    break;
                case Dim.Y:
                    _generator.Set("OffsetY", offset);
                    break;
                case Dim.Z:
                    _generator.Set("OffsetZ", offset);
                    break;
                case Dim.W:
                    _generator.Set("OffsetW", offset);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null);
            }
        }

    }
}
