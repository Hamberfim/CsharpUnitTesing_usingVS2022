using _01_fauxNetworkUtil.Ping;
using FluentAssertions;
using FluentAssertions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace _01_fauxNetworkUtil.Tests.PingTests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly NetworkService _pingTimeOutService;

        // ctor constructor
        public NetworkServiceTests()
        {
            // SUT
            _pingService = new NetworkService();
            _pingTimeOutService = new NetworkService();
        }


        // be mindful of naming conventions -  ClassName_MethodName_ExpectedResult
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange - get variables, classes, mocks, etc.
            // var pingService = new NetworkService();  moved to constructor

            // Act - call the method - execute
            var result = _pingService.SendPing();

            // Assert - exspected
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
            // var pingTimeOutService = new NetworkService(); moved to constructor

            // Act - call the method - execute
            var result = _pingTimeOutService.PingTimeOut(a, b);

            // Assert
            result.Should().Be(expected);  // [InlineData(1, 1, 2)]  // int a, int b, int expected
            result.Should().BeGreaterThanOrEqualTo(2);  // [InlineData(2, 2, 4)]  // int a, int b, int expected
            result.Should().NotBeInRange(-1000, 0);  // must be above zero

        }


        // for Testing Dates, Objects, and IEnumerable 
        // test date 
        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            // Arrange - get variables, classes, mocks, etc.
            // var pingService = new NetworkService();  moved to constructor

            // Act - call the method - execute
            var result = _pingService.LastPingDate();

            // Assert - exspected
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));

        }

        // test objects
        [Fact]
        public void NetowrkService_GetPingOptions_ReturnsObjects()
        {
            // Arrange - get variables, classes, mocks, etc.
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            // Act - call the method - execute
            var results = _pingService.GetPingOptions();

            //Assert - exspected  // Warning becareful with "BE" on reference types - use BeEquivelantTo
            results.Should().BeOfType<PingOptions>();
            results.Should().BeEquivalentTo(expected);
            results.Ttl.Should().Be(1);

        }

        // test IEnumerable
        [Fact]
        public void NetowrkService_MostRecentPings_ReturnsObjects()
        {
            // Arrange - get variables, classes, mocks, etc.
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            
            // Act - call the method - execute
            var results = _pingService.MostRecentPings();

            //Assert - exspected  // Warning becareful with "BE" on reference types - use BeEquivelantTo
            // results.Should().BeOfType<IEnumerable<PingOptions>>();
            results.Should().ContainEquivalentOf(expected);
            results.Should().Contain(x => x.DontFragment == true);

        }

    }
}
