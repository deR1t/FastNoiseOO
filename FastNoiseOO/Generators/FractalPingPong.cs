namespace FastNoiseOO.Generators
{
    /// <summary>
    /// A fractal that seems to "feed the input into itself".<br/>
    /// This is probably one you should look at with NoiseTool.
    /// </summary>
    public sealed class FractalPingPong : Fractal
    {

        public FractalPingPong() : base()
        {
            _generator = new FastNoise("FractalPingPong");
        }

        /// <summary>
        /// Sets the generator to modify.
        /// </summary>
        /// <param name="gen">The generator to modify.</param>
        public new void SetSource(Generator gen)
        {
            _generator.Set("Source", gen._generator);
        }

    }
}
