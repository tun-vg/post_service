using MediatR;
using Post.Contract.Abstractions;

namespace Post.Application.Commands.CategoryCommands;

public class CreateCategoryCommand : IRequest<Result>
{
    public string Name { get; set; } = string.Empty;
}