using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Domain.Entities;

public class Tag
{
    public Guid TagId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public IEnumerable<PostTag> PostTags { get; set; } = new List<PostTag>();
}
