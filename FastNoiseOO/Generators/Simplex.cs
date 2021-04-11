namespace FastNoiseOO.Generators
{
    /// <summary>
    /// The successor to perlin noise. Generates random smooth curves.
    /// </summary>
    public sealed class Simplex : Generator
    {

        public Simplex() : base()
        {
            _generator = new FastNoise("Simplex");
        }

    }
}
