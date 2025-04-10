using LearnToTest.Commands;
using Xunit;

namespace UnitTests.Commands;

public class TestCommandHandlerTests
{
    
    [Fact]
    public async Task Handle_ShouldReturnName()
    {
        // Arrange
        var command = new TestCommand
        {
            Name = "Hello World"
        };
        var handler = new TestCommandHandler();

        // Act
        var result = await handler.Handle(command, CancellationToken.None);

        // Assert
        Assert.Equal("Hello World", result);
    }
    
}