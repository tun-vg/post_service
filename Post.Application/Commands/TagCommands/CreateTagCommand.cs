using MediatR;
using Post.Contract.Abstractions;

namespace Post.Application.Commands.TagCommands;

public class CreateTagCommand : IRequest<Result>
{
    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public CreateTagCommand(string name, string slug)
    {
        Name = name;
        Slug = slug;
    }
}
