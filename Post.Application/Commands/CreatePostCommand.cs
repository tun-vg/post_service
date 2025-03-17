using MediatR;
using Post.Contract.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Application.Commands;

public class CreatePostCommand : IRequest<Result>
{
    public string Title { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public Guid AuthorId { get; set; }

    public Guid CategoryId { get; set; }

    public Guid[] PostTags { get; set; }
}
