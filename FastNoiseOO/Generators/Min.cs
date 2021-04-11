namespace FastNoiseOO.Generators
{    
    /// <summary>
    /// Compares two values and returns the lowest.
    /// </summary>
    public sealed class Min : OperatorSourceLHS
    {

        public Min() : base()
        {
            _generator = new FastNoise("Min");
        }

    }
}
