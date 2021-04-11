using System;

namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Offsets the input generator.
    /// </summary>
    public sealed class DomainOffset : Generator
    {

        public DomainOffset() : base()
        {
            _generator = new FastNoise("DomainOffset");
        }

        /// <summary>
        /// Sets the generator to be offset.
        /// </summary>
        /// <param name="gen">The generator to be offset.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets the offset.
        /// </summary>
        /// <param name="dimension">The axis to set.</param>
        /// <param name="gen">The generator to base the offset on.</param>
        public void SetOffset(Dim dimension, Generator gen)
        {
            switch (dimension)
            {
                case Dim.X:
                    _generator.Set("OffsetX", gen._generator);
                    break;
                case Dim.Y:
                    _generator.Set("OffsetY", gen._generator);
                    break;
                case Dim.Z:
                    _generator.Set("OffsetZ", gen._generator);
                    break;
                case Dim.W:
                    _generator.Set("OffsetW", gen._generator);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null);
            }
        }

        /// <summary>
        /// Sets the offset.
        /// </summary>
        /// <param name="dimension">The axis to set.</param>
        /// <param name="value">The value to offset the generator by.</param>
        public void SetOffset(Dim dimension, float value)
        {
            switch (dimension)
            {
                case Dim.X:
                    _generator.Set("OffsetX", value);
                    break;
                case Dim.Y:
                    _generator.Set("OffsetY", value);
                    break;
                case Dim.Z:
                    _generator.Set("OffsetZ", value);
                    break;
                case Dim.W:
                    _generator.Set("OffsetW", value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null);
            }
        }

    }
}
