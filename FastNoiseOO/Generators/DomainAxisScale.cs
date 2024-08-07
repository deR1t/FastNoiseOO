﻿using System;

namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Scales a generator on one axis.
    /// </summary>
    public sealed class DomainAxisScale : Generator
    {

        public DomainAxisScale() : base()
        {
            _generator = new FastNoise("DomainAxisScale");
        }

        /// <summary>
        /// Sets the generator to be scaled.
        /// </summary>
        /// <param name="gen">The generator to be scaled.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets how much the generator should be scaled.
        /// </summary>
        /// <param name="dimension">The axis to scale on.</param>
        /// <param name="value">How much the generator should be scaled by.</param>
        public void SetScale(Dim dimension, float value)
        {
            switch (dimension)
            {
                case Dim.X:
                    _generator.Set("ScaleX", value);
                    break;
                case Dim.Y:
                    _generator.Set("ScaleY", value);
                    break;
                case Dim.Z:
                    _generator.Set("ScaleZ", value);
                    break;
                case Dim.W:
                    _generator.Set("ScaleW", value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dimension), dimension, null);
            }
        }

    }
}
