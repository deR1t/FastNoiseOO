namespace FastNoiseOO.Generators
{

    /// <summary>
    /// Interpolated version of white noise.
    /// </summary>
    public sealed class Value : Generator
    {

        public Value() : base()
        {
            _generator = new FastNoise("Value");
        }

    }
}
