namespace FastNoiseOO
{

    /// <summary>
    /// Dimensions. <br/>
    /// Don't use Count.
    /// </summary>
    public enum Dim
    {
        /// <summary>
        /// X Dimension.
        /// </summary>
        X,
        /// <summary>
        /// Y Dimension.
        /// </summary>
        Y,
        /// <summary>
        /// Z Dimension.
        /// </summary>
        Z,
        /// <summary>
        /// W Dimension.
        /// </summary>
        W,
        /// <summary>
        /// Helper enum.
        /// </summary>
        Count
    };

    /// <summary>
    /// Distance functions.
    /// </summary>
    public enum DistanceFunction
    {
        /// <summary>
        /// Euclidean function.
        /// </summary>
        Euclidean,
        /// <summary>
        /// Euclidean squared function.
        /// </summary>
        EuclideanSquared,
        /// <summary>
        /// Manhattan function.
        /// </summary>
        Manhattan,
        /// <summary>
        /// Hybrid function.
        /// </summary>
        Hybrid,
        /// <summary>
        /// Max Axis function.
        /// </summary>
        MaxAxis,
    };

    /// <summary>
    /// Base generator class.
    /// </summary>
    public class Generator
    {

        protected internal FastNoise _generator;

        internal Generator()
        {
        }

        /// <summary>
        /// Generates a flat array of 2D noise.
        /// </summary>
        /// <param name="xStart">Start X Position</param>
        /// <param name="yStart">Start Y Position</param>
        /// <param name="xSize">X Size</param>
        /// <param name="ySize">Y Size</param>
        /// <param name="frequency">The scale of the noise</param>
        /// <param name="seed">The noise's seed</param>
        /// <returns>A 1 dimensional float array of 2D noise.</returns>
        public float[] GenUniformGrid2D(int xStart, int yStart, int xSize, int ySize, float frequency, int seed, out FastNoise.OutputMinMax minMax)
        {

            float[] noise = new float[xSize * ySize];
            minMax = _generator.GenUniformGrid2D(noise, xStart, yStart, xSize, ySize, frequency, seed);
            return noise;

        }

        /// <summary>
        /// Generates a flat array of 3D noise.
        /// </summary>
        /// <param name="xStart">Start X Position</param>
        /// <param name="yStart">Start Y Position</param>
        /// <param name="zStart">Start Z Position</param>
        /// <param name="xSize">X Size</param>
        /// <param name="ySize">Y Size</param>
        /// <param name="zSize">Z Size</param>
        /// <param name="frequency">The scale of the noise</param>
        /// <param name="seed">The noise's seed</param>
        /// <returns>A 1 dimensional float array of 3D noise.</returns>
        public float[] GenUniformGrid3D(int xStart, int yStart, int zStart, int xSize, int ySize, int zSize, float frequency, int seed, out FastNoise.OutputMinMax minMax)
        {

            float[] noise = new float[xSize * ySize * zSize];
            minMax = _generator.GenUniformGrid3D(noise, xStart, yStart, zStart, xSize, ySize, zSize, frequency, seed);
            return noise;

        }

        /// <summary>
        /// Generates a flat array of 4D noise.
        /// </summary>
        /// <param name="xStart">Start X Position</param>
        /// <param name="yStart">Start Y Position</param>
        /// <param name="zStart">Start Z Position</param>
        /// <param name="wStart">Start W Position</param>
        /// <param name="xSize">X Size</param>
        /// <param name="ySize">Y Size</param>
        /// <param name="zSize">Z Size</param>
        /// <param name="wSize">W Size</param>
        /// <param name="frequency">The scale of the noise</param>
        /// <param name="seed">The noise's seed</param>
        /// <returns>A 1 dimensional float array of 4D noise.</returns>
        public float[] GenUniformGrid4D(int xStart, int yStart, int zStart, int wStart, int xSize, int ySize, int zSize, int wSize, float frequency, int seed, out FastNoise.OutputMinMax minMax)
        {

            float[] noise = new float[xSize * ySize * zSize * wSize];
            minMax = _generator.GenUniformGrid4D(noise, xStart, yStart, zStart, wStart, xSize, ySize, zSize, wSize, frequency, seed);
            return noise;

        }

        public float[] GenPositionArray2D(int count, float[] xPosArray, float[] yPosArray, float xOffset, float yOffset, int seed, out FastNoise.OutputMinMax minMax)
        {

            float[] noise = new float[count];
            minMax = _generator.GenPositionArray2D(noise, xPosArray, yPosArray, xOffset, yOffset, seed);
            return noise;

        }

        public float[] GenPositionArray3D(int count, float[] xPosArray, float[] yPosArray, float[] zPosArray, float xOffset, float yOffset, float zOffset, int seed, out FastNoise.OutputMinMax minMax)
        {

            float[] noise = new float[count];
            minMax = _generator.GenPositionArray3D(noise, xPosArray, yPosArray, zPosArray, xOffset, yOffset, zOffset, seed);
            return noise;

        }

        public float[] GenPositionArray4D(int count, float[] xPosArray, float[] yPosArray, float[] zPosArray, float[] wPosArray, float xOffset, float yOffset, float zOffset, float wOffset, int seed, out FastNoise.OutputMinMax minMax)
        {

            float[] noise = new float[count];
            minMax = _generator.GenPositionArray4D(noise, xPosArray, yPosArray, zPosArray, wPosArray, xOffset, yOffset, zOffset, wOffset, seed);
            return noise;

        }

        /// <summary>
        /// Gets a single point of 2D noise.
        /// </summary>
        /// <param name="x">X Position</param>
        /// <param name="y">Y Position</param>
        /// <param name="seed">The noise's seed</param>
        /// <returns>A single point of 2D noise.</returns>
        public float GenSingle2D(float x, float y, int seed)
        {
            return _generator.GenSingle2D(x, y, seed);
        }

        /// <summary>
        /// Gets a single point of 3D noise.
        /// </summary>
        /// <param name="x">X Position</param>
        /// <param name="y">Y Position</param>
        /// <param name="z">Z Position</param>
        /// <param name="seed">The noise's seed</param>
        /// <returns>A single point of 3D noise.</returns>
        public float GenSingle3D(float x, float y, float z, int seed)
        {
            return _generator.GenSingle3D(x, y, z, seed);
        }

        /// <summary>
        /// Gets a single point of 4D noise.
        /// </summary>
        /// <param name="x">X Position</param>
        /// <param name="y">Y Position</param>
        /// <param name="z">Z Position</param>
        /// <param name="w">W Position</param>
        /// <param name="seed">The noise's seed</param>
        /// <returns>A single point of 4D noise.</returns>
        public float GenSingle4D(float x, float y, float z, float w, int seed)
        {
            return _generator.GenSingle4D(x, y, z, w, seed);
        }

        /// <summary>
        /// Generates a square of 2D noise that's tileable like a texture.
        /// </summary>
        /// <param name="xSize">X Size</param>
        /// <param name="ySize">Y Size</param>
        /// <param name="frequency">The scale of the noise</param>
        /// <param name="seed">The noise's seed</param>
        /// <returns>A 1 dimensional float array of 2D noise.</returns>
        public float[] GenTileable2D(int xSize, int ySize, float frequency, int seed, out FastNoise.OutputMinMax minMax)
        {

            float[] noise = new float[xSize * ySize];
            minMax = _generator.GenTileable2D(noise, xSize, ySize, frequency, seed);
            return noise;

        }
        
    }

}
