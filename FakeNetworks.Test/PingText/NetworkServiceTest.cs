using FakeNetworks.Ping;
using FluentAssertions;
using Xunit;
using Assert = Xunit.Assert;

namespace FakeNetworks.Test.PingText;

public class NetworkServiceTest
{
    [Fact]
    public void NetworkService_SendPing_ReturnString()
    {
        // Arrange
        var pingService = new NetworkService();
        
        // Act
        var results = pingService.SendPing();

        // Assert
        results.Should().NotBeNullOrWhiteSpace();
        results.Should().Be("Success: Ping Sent");
        results.Should().Contain("Success", Exactly.Once());
        

    }
}