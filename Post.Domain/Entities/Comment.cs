using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Domain.Entities;

public class Comment : BaseEntity
{
    public Guid CommentId { get; set; }

    public string Content { get; set; } = string.Empty;

    public Guid AuthorId { get; set; }

    public Guid PostId { get; set; }

    public Post? Post { get; set; }
}
