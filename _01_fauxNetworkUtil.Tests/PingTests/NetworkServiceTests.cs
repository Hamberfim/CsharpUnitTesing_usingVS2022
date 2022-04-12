using _01_fauxNetworkUtil.Ping;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _01_fauxNetworkUtil.Tests.PingTests
{
    public class NetworkServiceTests
    {
        // be mindful of naming conventions -  ClassName_MethodName_ExpectedResult
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange - get variables, classes, mocks, etc.
            var pingService = new NetworkService();

            // Act - call the method - execute
            var result = pingService.SendPing();

            // Assert
            result.Should().NotBeNullOrEmpty();
            result.Should().Be("Success: Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());

        }
        
        [Theory]
        [InlineData(1, 1, 2)]  // int a, int b, int expected
        [InlineData(2, 2, 4)]  // int a, int b, int expected
        public void NetworkService_PingTimeOut_ReturnInt(int a, int b, int expected)
        {
            // Arrange - get variables, classes, mocks, etc.
            var pingTimeOutService = new NetworkService();

            // Act - call the method - execute
            var result = pingTimeOutService.PingTimeOut(a, b);

            // Assert
            result.Should().Be(expected);  // [InlineData(1, 1, 2)]  // int a, int b, int expected
            result.Should().BeGreaterThanOrEqualTo(2);  // [InlineData(2, 2, 4)]  // int a, int b, int expected
            result.Should().NotBeInRange(-1000, 0);  // must be abouve zero

        }

    }
}
