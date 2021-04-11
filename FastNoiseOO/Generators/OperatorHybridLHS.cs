using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FastNoiseSharp.Generators
{
    
    /// <summary>
    /// This is the class that blends with a LHS and a RHS inherits from.<br/>
    /// Hybrid implies that you can set LHS to a number, or plug in a source generator.
    /// </summary>
    public abstract class OperatorHybridLHS : Generator
    {

        internal OperatorHybridLHS() : base()
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
        /// Sets the LHS (Left hand side).
        /// </summary>
        /// <param name="value">Value to set the LHS to.</param>
        public void SetLHS(float value)
        {
            _generator.Set("LHS", value);
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
