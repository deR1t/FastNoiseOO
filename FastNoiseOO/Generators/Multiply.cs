namespace FastNoiseOO.Generators
{
    /// <summary>
    /// It multiplies the values of generators together.
    /// </summary>
    public sealed class Multiply : OperatorSourceLHS
    {

        public Multiply() : base()
        {
            _generator = new FastNoise("Multiply");
        }

    }
}
