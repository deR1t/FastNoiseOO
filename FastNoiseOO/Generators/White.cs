namespace FastNoiseOO.Generators
{
    /// <summary>
    /// For each pixel, a random number is picked.
    /// </summary>
    public sealed class White : Generator
    {

        public White() : base()
        {
            _generator = new FastNoise("White");
        }

    }
}
