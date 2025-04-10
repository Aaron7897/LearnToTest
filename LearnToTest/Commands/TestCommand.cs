using MediatR;

namespace LearnToTest.Commands;

public class TestCommand: IRequest<string>
{
    public string Name { get; set; } = string.Empty;
}

public class TestCommandHandler : IRequestHandler<TestCommand, string>
{
    public Task<string> Handle(TestCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(request.Name);
    }
}