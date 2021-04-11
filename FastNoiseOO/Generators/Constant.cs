namespace FastNoiseOO.Generators
{
    /// <summary>
    /// Always returns the same number.
    /// </summary>
    public sealed class Constant : Generator
    {

        public Constant() : base()
        {
            _generator = new FastNoise("Constant");
        }

        /// <summary>
        /// Sets the constant's value.
        /// </summary>
        /// <param name="value">The value to set the constant to</param>
        public void SetValue(float value)
        {
            _generator.Set("Value", value);
        }

    }
}
