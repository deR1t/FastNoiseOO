namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Outputs the input. Passthrough generator.
    /// </summary>
    public sealed class GeneratorCache : Generator
    {

        public GeneratorCache() : base()
        {
            _generator = new FastNoise("GeneratorCache");
        }

        /// <summary>
        /// Sets the generator to passthrough.
        /// </summary>
        /// <param name="gen">The generator to passthrough.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

    }
}
