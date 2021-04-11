namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Compares two values and returns the highest.
    /// </summary>
    public sealed class Max : OperatorSourceLHS
    {

        public Max() : base()
        {
            _generator = new FastNoise("Max");
        }

    }
}
