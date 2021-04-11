namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Warps an input generator.
    /// </summary>
    public sealed class DomainWarpGradient : DomainWarp
    {

        public DomainWarpGradient() : base()
        {
            _generator = new FastNoise("DomainWarpGradient");
        }

    }
}
