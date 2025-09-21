using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Domain.Entities;

public class Category
{
    public Guid CategoryId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public ICollection<Post> Posts { get; set; } = new List<Post>();

    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}
