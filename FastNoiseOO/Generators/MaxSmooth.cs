namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Compares two values and returns the highest, and allows you to smooth out the cutoff.
    /// </summary>
    public sealed class MaxSmooth : OperatorSourceLHS
    {

        public MaxSmooth() : base()
        {
            _generator = new FastNoise("MaxSmooth");
        }

        /// <summary>
        /// Sets how smooth the cutoff should be.
        /// </summary>
        /// <param name="gen">The generator to determine the smoothness.</param>
        public void SetSmoothness(Generator gen)
        {
            _generator.Set("Smoothness", gen._generator);
        }

        /// <summary>
        /// Sets how smooth the cutoff should be.
        /// </summary>
        /// <param name="value">How smooth the cutoff should be.</param>
        public void SetSmoothness(float value)
        {
            _generator.Set("Smoothness", value);
        }

    }
}
