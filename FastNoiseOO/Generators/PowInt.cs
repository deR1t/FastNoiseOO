namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Raises a generator to a power. This generator is meant for ints.
    /// </summary>
    public sealed class PowInt : Generator
    {

        public PowInt() : base()
        {
            _generator = new FastNoise("PowInt");
        }

        /// <summary>
        /// Sets the generator to be raised to a power.
        /// </summary>
        /// <param name="gen">The generator to be raised to a power.</param>
        public void SetValue(Generator gen)
        {
            _generator.Set("Value", gen._generator);
        }

        /// <summary>
        /// Sets the power that the generator will be raised to.
        /// </summary>
        /// <param name="value">The power that the generator will be raised to.</param>
        public void SetPow(int value)
        {
            _generator.Set("Pow", value);
        }

    }
}
