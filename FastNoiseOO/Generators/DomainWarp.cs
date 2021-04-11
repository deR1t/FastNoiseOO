namespace FastNoiseOO.Generators
{

    /// <summary>
    /// Domain warp types.
    /// </summary>
    public enum DomainWarpTypes
    {
        /// <summary>
        /// Gradient warp.
        /// </summary>
        Gradient = 0
    }

    /// <summary>
    /// Warps the output of a generator.
    /// </summary>
    public abstract class DomainWarp : Generator
    {

        internal DomainWarp() : base()
        {
        }

        /// <summary>
        /// Sets the source generator to warp.
        /// </summary>
        /// <param name="gen">Source generator.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets how much the generator should be warped depending on the output of another generator.
        /// </summary>
        /// <param name="gen">The amount the generator should be warped depending on the output of another generator.</param>
        public void SetWarpAmplitude(Generator gen)
        {
            _generator.Set("WarpAmplitude", gen._generator);
        }

        /// <summary>
        /// Sets how much the generator should be warped.
        /// </summary>
        /// <param name="value">The amount the generator should be warped.</param>
        public void SetWarpAmplitude(float value)
        {
            _generator.Set("WarpAmplitude", value);
        }

        /// <summary>
        /// Sets the zoom of the warping.
        /// </summary>
        /// <param name="value">The zoom of the warping.</param>
        public void SetWarpFrequency(float value)
        {
            _generator.Set("WarpFrequency", value);
        }

    }

}
