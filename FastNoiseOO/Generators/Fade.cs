namespace FastNoiseOO.Generators
{
    /// <summary>
    /// "Fades" two generators into each other.
    /// </summary>
    public sealed class Fade : Generator
    {

        public Fade() : base()
        {
            _generator = new FastNoise("Fade");
        }

        /// <summary>
        /// Sets the first generator.
        /// </summary>
        /// <param name="gen">The first generator.</param>
        public void SetA(Generator gen)
        {
            _generator.Set("A", gen._generator);
        }

        /// <summary>
        /// Sets the second generator.
        /// </summary>
        /// <param name="gen">The second generator.</param>
        public void SetB(Generator gen)
        {
            _generator.Set("B", gen._generator);
        }

        /// <summary>
        /// Sets the generator to use to determine how much it should "fade" between the input generators.
        /// </summary>
        /// <param name="gen">The generator that determines the fade amount.</param>
        public void SetFade(Generator gen)
        {
            _generator.Set("Fade", gen._generator);
        }

        /// <summary>
        /// Sets how much it should "fade" between the input generators.
        /// </summary>
        /// <param name="value">Fade amount.</param>
        public void SetFade(float value)
        {
            _generator.Set("Fade", value);
        }

    }
}
