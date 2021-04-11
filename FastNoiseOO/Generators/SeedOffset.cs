namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Offsets the input generator's seed.
    /// </summary>
    public sealed class SeedOffset : Generator
    {

        public SeedOffset() : base()
        {
            _generator = new FastNoise("SeedOffset");
        }

        /// <summary>
        /// Set the generator to have it's seed offset.
        /// </summary>
        /// <param name="gen">The generator to have it's seed offset.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets how much the seed should be offset.
        /// </summary>
        /// <param name="offset">How much the seed should be offset.</param>
        public void SetOffset(int offset)
        {
            _generator.Set("SeedOffset", offset);
        }

    }
}
