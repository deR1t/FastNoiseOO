﻿namespace FastNoiseOO.Generators
{

    /// <summary>
    /// This is the class that blends with a LHS and a RHS inherits from.<br/>
    /// Source implies that you cannot set the value of LHS, only plug in a generator.
    /// </summary>
    public abstract class OperatorSourceLHS : Generator
    {

        internal OperatorSourceLHS() : base()
        {
        }

        /// <summary>
        /// Sets the LHS (Left hand side).
        /// </summary>
        /// <param name="gen">Generator to get the LHS from.</param>
        public void SetLHS(Generator gen)
        {
            _generator.Set("LHS", gen._generator);
        }

        /// <summary>
        /// Sets the RHS (Right hand side).
        /// </summary>
        /// <param name="gen">Generator to get the RHS from.</param>
        public void SetRHS(Generator gen)
        {
            _generator.Set("RHS", gen._generator);
        }

        /// <summary>
        /// Sets the RHS (Right hand side).
        /// </summary>
        /// <param name="value">Value to set the RHS to.</param>
        public void SetRHS(float value)
        {
            _generator.Set("RHS", value);
        }

    }

}
