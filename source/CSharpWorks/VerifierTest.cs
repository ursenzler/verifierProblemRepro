using System;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace CSharpWorks
{
    [UsesVerify]
    public class VerifierTest
    {
        [Fact]
        public async Task Bar()
        {
            await Verifier.Verify("works");
        }
    }
}