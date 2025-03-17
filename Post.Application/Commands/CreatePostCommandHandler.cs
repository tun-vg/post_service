using MediatR;
using Post.Contract.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Application.Commands;

public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Result>
{
    public CreatePostCommandHandler()
    {

    }

    public async Task<Result> Handle (CreatePostCommand command, CancellationToken cancellationToken)
    {

        return Result.Success();
    }
}
