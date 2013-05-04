using System;

namespace Xunit.Abstractions
{
    /// <summary>
    /// Represents an implementation of the discovery part of a test framework.
    /// </summary>
    public interface ITestFrameworkDiscoverer : IDisposable
    {
        /// <summary>
        /// Starts the process of finding all tests in an assembly.
        /// </summary>
        /// <param name="includeSourceInformation">Whether to include source file information, if possible.</param>
        /// <param name="messageSink">The message sink to report results back to.</param>
        void Find(bool includeSourceInformation, IMessageSink messageSink);

        /// <summary>
        /// Starts the process of finding all tests in a class.
        /// </summary>
        /// <param name="typeName">The fully qualified type name to find tests in.</param>
        /// <param name="includeSourceInformation">Whether to include source file information, if possible.</param>
        /// <param name="messageSink">The message sink to report results back to.</param>
        void Find(string typeName, bool includeSourceInformation, IMessageSink messageSink);

        /// <summary>
        /// Serializes a test case into string form.
        /// </summary>
        /// <param name="testCase">The test case to be serialized.</param>
        /// <returns>The serialized representation of the test case.</returns>
        string Serialize(ITestCase testCase);
    }
}