namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Converts to RGBA8 (????)
    /// </summary>
    public sealed class ConvertRGBA8 : Generator
    {

        public ConvertRGBA8() : base()
        {
            _generator = new FastNoise("ConvertRGBA8");
        }

        /// <summary>
        /// Sets the generator to be converted.
        /// </summary>
        /// <param name="gen">The generator to be converted.</param>
        public void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

        /// <summary>
        /// Sets the minimum and maximum.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        public void SetMinMax(float min, float max)
        {
            _generator.Set("Min", min);
            _generator.Set("Max", max);
        }

    }
}
