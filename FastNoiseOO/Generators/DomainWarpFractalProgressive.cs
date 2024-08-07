﻿namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Warps a domain warp with a fractal.
    /// </summary>
    public sealed class DomainWarpFractalProgressive : Fractal
    {

        public DomainWarpFractalProgressive() : base()
        {
            _generator = new FastNoise("DomainWarpFractalProgressive");
        }

        /// <summary>
        /// Call this function if it's a domain warp fractal, not the one in the base class.
        /// </summary>
        /// <param name="gen">Domain warp to set the source to.</param>
        public void SetSource(DomainWarp gen)
        {
            _generator.Set("DomainWarpSource", gen._generator);
        }

    }
}
