namespace FastNoiseOO.Generators
{

    /// <summary>
    /// Generates sine waves in many dimensions.
    /// </summary>
    public sealed class SineWave : Generator
    {

        public SineWave() : base()
        {
            _generator = new FastNoise("SineWave");
        }

        /// <summary>
        /// Sets the scale of the sine waves.
        /// </summary>
        /// <param name="value">The scale to set the sine waves to</param>
        public void SetScale(float value)
        {
            _generator.Set("Scale", value);
        }

    }
}
