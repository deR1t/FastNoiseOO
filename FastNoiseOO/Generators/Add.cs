namespace FastNoiseOO.Generators
{
    /// <summary>
    /// It adds the values of generators together.
    /// </summary>
    public sealed class Add : OperatorSourceLHS
    {

        public Add() : base()
        {
            _generator = new FastNoise("Add");
        }

    }
}
