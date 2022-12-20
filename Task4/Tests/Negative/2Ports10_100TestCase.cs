// ----------------------------------------------------------------------
// 2Ports10_100TestCase.cs
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace Task3.Tests.Negative
{
    #region Usings

    using System.Collections.Generic;
    using Task3.FlowBuilders;

    #endregion

    /// <summary>
    /// Test case: 2 ports, speed: 10, 100.
    /// Total speed: 110.
    /// </summary>
    public class _2Ports10_100TestCase : NcNegativeTestFlow
    {
        #region Fields and Constants

        /// <summary>
        /// Test case #1.
        /// </summary>
        public const string testName = "_2Ports10_100Test";

        /// <summary>
        /// The test case description.
        /// </summary>
        public const string testDescription = "Test flow:"
            + "\n 1) Set port configurations on Simics:"
            + "\n 2 ports; Total speed: 110 Gb/sec"
            + "\n 2) Start FW boot."
            + "\n 3) Check the number of ports, detected by FW."
            + "\n 4) Check the speed of each port, detected by FW.";

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="_2Ports10_100TestCase" /> class.
        /// </summary>
        /// <param name="testName">
        /// Test name.
        /// </param>
        /// <param name="testDescription">
        /// Test description.
        /// </param>
        public _2Ports10_100TestCase(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers

        /// <summary>
        /// Dictionary "portsSpeed" containing name of the port and ports speed.
        /// </summary>
        protected override Dictionary<string, int> portsSpeed => new Dictionary<string, int>()
        {
            {"PortSpeed1", 10},
            {"PortSpeed2", 100}
        };

        #endregion
    }
}
