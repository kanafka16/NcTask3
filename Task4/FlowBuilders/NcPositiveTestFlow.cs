// ----------------------------------------------------------------------
// Here will be Header
// NcPositiveTestFlow.cs
// Copyright 2022
// ----------------------------------------------------------------------

namespace Task3.FlowBuilders
{
    #region Usings

    using System.Collections.Generic;
    using Task3.DataStructures;

    #endregion

    /// <summary>
    /// Flow builder. Overrides Prepare(), Run(), Clean() methods of the test template.
    /// </summary>
    public abstract class NcPositiveTestFlow : NcTestTemplate
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NcPositiveTestFlow" /> class.
        /// </summary>
        /// <param name="testName">
        /// Test name.
        /// </param>
        /// <param name="testDescription">
        /// Test descrition.
        /// </param>
        public NcPositiveTestFlow(string testName, string testDescription) : base(testName, testDescription)
        {
        }

        #endregion

        #region Properties and Indexers
        /// <summary>
        /// Dictionary "portsSpeed" containing Name of Port and Ports Speed depending on the launched Test Case; 
        /// Overrides with Test Case;
        /// </summary>
        protected override Dictionary<string, int> portsSpeed => new Dictionary<string, int>()
        {
        };

        /// <summary>
        /// Type of reset, which test is using.
        /// </summary>
        public override ResetTypes ResetTypeToTrigger => ResetTypes.AnyReset;

        #endregion

        #region Methods

        /// <summary>
        /// Method for clearing the number of ports and speeds.
        /// </summary>
        public void Clean()
        {
            // Stub.
        }

        /// <summary>
        /// Method for values substitution of ports and speeds.
        /// </summary>
        /// <returns>
        /// Boolean.
        /// </returns>
        public bool Prepare()
        {
            bool retVal = true;

            retVal &= this.TempTestMethod();
            retVal &= this.SetPortsSpeed(); // Return method of setting the port speed configurations.
            retVal &= this.SetQuantityOfPorts(); // Return method of ports number configuration setting value.

            return retVal;
        }

        /// <summary>
        /// Method for launching a test case.
        /// </summary>
        public void Run()
        {
            this.TotalPortsSpeed(); // Method that returns the correctness of the overall speed of the ports.
        }

        #endregion
    }
}