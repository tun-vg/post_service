using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Domain.Entities;

public class Tag
{
    [Key]
    public Guid TagId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Slug { get; set; } = string.Empty;

    public ICollection<PostTag>? PostTags { get; set; }

    public Guid CategoryId { get; set; }

    public Category? Category { get; set; }

    public Tag()
    {

    }

    public Tag(Guid tagid ,string name, string slug)
    {
        TagId = tagid;
        Name = name;
        Slug = slug;
    }
}
