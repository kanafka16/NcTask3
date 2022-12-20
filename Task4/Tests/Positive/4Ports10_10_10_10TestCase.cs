// ----------------------------------------------------------------------
// 4Ports10_10_10_10TestCase.cs
// Here will be Header
// Copyright 2022
// ----------------------------------------------------------------------

namespace Task3.Tests.Positive
{
    #region Usings

    using System.Collections.Generic;
    using Task3.FlowBuilders;

    #endregion

    /// <summary>
    /// Test case: 4 ports, speed: 10, 10, 10, 10.
    /// Total speed: 40.
    /// </summary>
    public class _4Ports10_10_10_10TestCase : NcPositiveTestFlow
    {
        #region Fields and Constants

        /// <summary>
        /// Test case #1.
        /// </summary>
        public const string testName = "4Ports10_10_10_10Test";

        /// <summary>
        /// The test case description.
        /// </summary>
        public const string testDescription = "Test flow:"
            + "\n 1) Set port configurations on Simics:"
            + "\n 4 ports; Total speed: 40 Gb/sec"
            + "\n 2) Start FW boot."
            + "\n 3) Check the number of ports, detected by FW."
            + "\n 4) Check the speed of each port, detected by FW.";

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="_4Ports10_10_10_10TestCase" /> class.
        /// </summary>
        /// <param name="testName">
        /// Test name.
        /// </param>
        /// <param name="testDescription">
        /// Test description.
        /// </param>
        public _4Ports10_10_10_10TestCase(string testName, string testDescription) : base(testName, testDescription)
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
            {"PortSpeed2", 10},
            {"PortSpeed3", 10},
            {"PortSpeed4", 10}
        };

        #endregion
    }
}
