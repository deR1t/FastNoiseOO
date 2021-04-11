namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Creates random smooth curves, although looks locked to a grid from far away.
    /// </summary>
    public sealed class Perlin : Generator
    {

        public Perlin() : base()
        {
            _generator = new FastNoise("Perlin");
        }

    }
}
