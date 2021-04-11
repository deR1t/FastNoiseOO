using System;

namespace FastNoiseOO.Generators
{

    public enum ReturnType
    {
        /// <summary>
        /// Returns only Index0
        /// </summary>
        Index0,

        /// <summary>
        /// Returns Index0 with Index1 added to it.
        /// </summary>
        Index0Add1,

        /// <summary>
        /// Returns Index0 with Index1 subtracted from it.
        /// </summary>
        Index0Sub1,

        /// <summary>
        /// Returns Index0 and Index1 multiplied with each other.
        /// </summary>
        Index0Mul1,

        /// <summary>
        /// Returns Index0 divided by Index1.
        /// </summary>
        Index0Div1
    }

    /// <summary>
    /// Creates many cells, each pixel's value is based on the distance from itself and the nearest cell.
    /// </summary>
    public sealed class CellularDistance : Cellular
    {

        public CellularDistance() : base()
        {
            _generator = new FastNoise("CellularDistance");
        }

        /// <summary>
        /// Each pixel has a sorted array of the distance to the nearest cell, and the distance index is what's used to access that array per pixel.<br/>
        /// It's probably a good idea to check out NoiseTool, so you get a nice visualization of what's happening.
        /// </summary>
        /// <param name="value">Index to use</param>
        public void SetDistanceIndex0(int value)
        {
            _generator.Set("DistanceIndex0", value);
        }

        /// <summary>
        /// Each pixel has a sorted array of the distance to the nearest cell, and the distance index is what's used to access that array per pixel.<br/>
        /// This is the second distance index, you can use this with return type to quickly layer multiple cellular types.<br/>
        /// It's probably a good idea to check out NoiseTool, so you get a nice visualization of what's happening.
        /// </summary>
        /// <param name="value">Index to use</param>
        public void SetDistanceIndex1(int value)
        {
            _generator.Set("DistanceIndex1", value);

        }

        /// <summary>
        /// This modifies the return using both values obtained from the distance array.<br/>
        /// It's probably a good idea to check out NoiseTool, so you get a nice visualization of what's happening.
        /// </summary>
        /// <param name="returnType">Return type to use</param>
        public void SetReturnType(ReturnType returnType)
        {
            switch (returnType)
            {
                case ReturnType.Index0:
                    _generator.Set("ReturnType", "Index0");
                    break;
                case ReturnType.Index0Add1:
                    _generator.Set("ReturnType", "Index0Add1");
                    break;
                case ReturnType.Index0Sub1:
                    _generator.Set("ReturnType", "Index0Sub1");
                    break;
                case ReturnType.Index0Mul1:
                    _generator.Set("ReturnType", "Index0Mul1");
                    break;
                case ReturnType.Index0Div1:
                    _generator.Set("ReturnType", "Index0Div1");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(returnType), returnType, null);
            }
        }

    }
}
