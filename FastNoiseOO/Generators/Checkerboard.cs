﻿namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Generates a checkerboard.
    /// </summary>
    public sealed class Checkerboard : Generator
    {

        public Checkerboard() : base()
        {
            _generator = new FastNoise("Checkerboard");
        }

        /// <summary>
        /// Sets the size of the checkerboard.
        /// </summary>
        /// <param name="value">Scale to use</param>
        public void SetSize(float value)
        {
            _generator.Set("Size", value);
        }

    }
}
