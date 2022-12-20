// ----------------------------------------------------------------------
// Here will be Header
// NcNegativeTestFlow.cs
// Copyright 2022
// ----------------------------------------------------------------------

namespace Task3.FlowBuilders
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Text;

    #endregion

    /// <summary>
    /// Negative Flow builder. Overrides Prepare(), Run(), Clean() methods of the test template.
    /// </summary>
    public abstract class NcNegativeTestFlow: NcTestTemplate
    {
        #region Fields and Constants

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NetCardNegativeFlowBuilder" /> class.
        /// </summary>
        /// <param name="testName">
        /// Test name.
        /// </param>
        /// <param name="testDescription">
        /// Test description.
        /// </param>
        public NcNegativeTestFlow(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers

        #endregion
    }
}