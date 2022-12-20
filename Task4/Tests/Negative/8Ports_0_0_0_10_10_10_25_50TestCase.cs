// ----------------------------------------------------------------------
// 8Ports_0_0_0_10_10_10_25_50TestCase.cs
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
    /// Test case: 8 ports, speed: 0, 0, 0, 10, 10, 10, 25, 50.
    /// Total speed: 105.
    /// </summary>
    public class _8Ports0_0_0_10_10_10_25_50TestCase : NcNegativeTestFlow
    {
        #region Fields and Constants

        /// <summary>
        /// Test case #1.
        /// </summary>
        public const string testName = "_8Ports0_0_0_10_10_10_25_50Test";

        /// <summary>
        /// The test case description.
        /// </summary>
        public const string testDescription = "Test flow:"
            + "\n 1) Set port configurations on Simics:"
            + "\n 8 ports; Total speed: 105 Gb/sec"
            + "\n 2) Start FW boot."
            + "\n 3) Check the number of ports, detected by FW."
            + "\n 4) Check the speed of each port, detected by FW.";

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="_8Ports0_0_0_10_10_10_25_50TestCase" /> class.
        /// </summary>
        /// <param name="testName">
        /// Test name.
        /// </param>
        /// <param name="testDescription">
        /// Test description.
        /// </param>
        public _8Ports0_0_0_10_10_10_25_50TestCase(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers

        /// <summary>
        /// Dictionary "portsSpeed" containing name of the port and ports speed.
        /// </summary>
        protected override Dictionary<string, int> portsSpeed => new Dictionary<string, int>()
        {
            {"PortSpeed1", 0},
            {"PortSpeed2", 0},
            {"PortSpeed3", 0},
            {"PortSpeed4", 10},
            {"PortSpeed1", 10},
            {"PortSpeed2", 10},
            {"PortSpeed3", 25},
            {"PortSpeed4", 50}
        };

        #endregion
    }
}
